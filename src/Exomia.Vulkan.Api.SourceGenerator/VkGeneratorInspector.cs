#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    class VkGeneratorInspector
    {
        private const string VK_IGNORE_ATTRIBUTE = "Exomia.Vulkan.Api.SourceGenerator.VkIgnoreAttribute";

        internal static async Task<VkExtensionClass> InspectAsync(INamedTypeSymbol viewModelClassSymbol)
        {
            VkExtensionClass vkExtensionClass = new()
            {
                NamespaceName = viewModelClassSymbol.ContainingNamespace.ToDisplayString(), ClassName = viewModelClassSymbol.Name, Functions = new List<FunctionPointerInfo>()
            };

            foreach (ISymbol member in viewModelClassSymbol.GetMembers())
            {
                Console.WriteLine(member.Name);
                switch (member)
                {
                    case IMethodSymbol methodSymbol:
                        if (methodSymbol.Name == "Load")
                        {
                            vkExtensionClass.LoadFunction = methodSymbol;
                        }
                        break;
                    case IFieldSymbol fieldSymbol:
                        vkExtensionClass = await FindPropertiesToGenerateAsync(fieldSymbol, vkExtensionClass);
                        break;
                }
            }

            return vkExtensionClass;
        }

        private static async Task<VkExtensionClass> FindPropertiesToGenerateAsync(IFieldSymbol fieldSymbol, VkExtensionClass vkExtensionClass)
        {
            if (fieldSymbol.IsConst && fieldSymbol.Name.EndsWith("EXTENSION_NAME") && fieldSymbol.Type.Name == "String")
            {
                vkExtensionClass.VarExtensionName = fieldSymbol.Name;
                vkExtensionClass.ExtensionName    = fieldSymbol.ConstantValue as string ?? throw new NullReferenceException(nameof(fieldSymbol.ConstantValue));
                return vkExtensionClass;
            }

            ImmutableArray<AttributeData> attributeData      = fieldSymbol.GetAttributes();
            AttributeData?                fieldAttributeData = attributeData.FirstOrDefault(x => x.AttributeClass?.ToDisplayString() == VK_IGNORE_ATTRIBUTE);

            if (fieldAttributeData is not null) // vkIgnore is present 
            {
                return vkExtensionClass;
            }

            SyntaxNode?                fieldSyntax         = (await fieldSymbol.DeclaringSyntaxReferences[0].GetSyntaxAsync()).Parent;
            FunctionPointerTypeSyntax? fieldSyntaxChildren = fieldSyntax?.DescendantNodes().OfType<FunctionPointerTypeSyntax>().FirstOrDefault();
            if (fieldSyntaxChildren is null) // field is not a function pointer
            {
                return vkExtensionClass;
            }

            FunctionPointerInfo fpi;
            fpi.Name       = fieldSymbol.Name;
            fpi.Parameters = new List<FunctionPointerParameter>();

            SyntaxNodeOrToken[] properties = fieldSyntaxChildren.ParameterList.DescendantNodesAndTokens()
                                                                .Where(x => x.AsNode() is FunctionPointerParameterSyntax || x.AsToken().IsKind(SyntaxKind.CommaToken))
                                                                .ToArray();

            for (int i = 0; i < properties.Length - 1; i += 2)
            {
                FunctionPointerParameterSyntax parameterSyntax = properties[i].AsNode() as FunctionPointerParameterSyntax ?? throw new NullReferenceException(nameof(fieldSymbol.ConstantValue));
                SyntaxTrivia                   trivia          = properties[i + 1].AsToken().TrailingTrivia.First(x => x.IsKind(SyntaxKind.MultiLineCommentTrivia));

                FunctionPointerParameter fpp;
                fpp.IsReturnParameter = false;
                fpp.ParameterSyntax   = parameterSyntax;
                fpp.Name              = trivia.ToFullString().Trim(' ', '*', '/');
                fpp.Type              = parameterSyntax.ToString();

                fpi.Parameters.Add(fpp);
            }

            vkExtensionClass.Functions.Add(fpi);
            return vkExtensionClass;
        }
    }
}