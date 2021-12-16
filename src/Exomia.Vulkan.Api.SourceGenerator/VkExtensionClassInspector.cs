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
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exomia.Vulkan.Api.SourceGenerator;

class VkExtensionClassInspector
{
    private const string VK_IGNORE_ATTRIBUTE = "Exomia.Vulkan.Api.SourceGenerator.VkIgnoreAttribute";

    public static void FindPropertiesToGenerate(IFieldSymbol fieldSymbol, ref VkExtensionClass vkExtensionClass)
    {
        if (fieldSymbol.IsConst && fieldSymbol.Name.EndsWith("EXTENSION_NAME") && fieldSymbol.Type.Name == "String")
        {
            vkExtensionClass.VarExtensionName = fieldSymbol.Name;
            vkExtensionClass.ExtensionName    = fieldSymbol.ConstantValue as string ?? throw new NullReferenceException(nameof(fieldSymbol.ConstantValue));
        }

        ImmutableArray<AttributeData> attributeData         = fieldSymbol.GetAttributes();
        AttributeData?                vkIgnoreAttributeData = attributeData.FirstOrDefault(x => x.AttributeClass?.ToDisplayString() == VK_IGNORE_ATTRIBUTE);

        if (vkIgnoreAttributeData is not null) // vkIgnore is present 
        {
            return;
        }

        SyntaxNode?                fieldSyntax         = fieldSymbol.DeclaringSyntaxReferences[0].GetSyntax().Parent;
        FunctionPointerTypeSyntax? fieldSyntaxChildren = fieldSyntax?.DescendantNodes().OfType<FunctionPointerTypeSyntax>().FirstOrDefault();
        if (fieldSyntaxChildren is null) // field is not a function pointer
        {
            return;
        }

        FunctionPointerInfo fpi;
        fpi.Name       = fieldSymbol.Name;
        fpi.Parameters = new List<FunctionPointerParameter>();
        SyntaxNodeOrToken[] properties = fieldSyntaxChildren.ParameterList.DescendantNodesAndTokens()
                                                            .Where(x => x.AsNode() is FunctionPointerParameterSyntax || x.AsToken().IsKind(SyntaxKind.CommaToken))
                                                            .ToArray();

        for (int i = 0; i < properties.Length - 1; i += 2)
        {
            FunctionPointerParameterSyntax parameterSyntax = properties[i].AsNode() as FunctionPointerParameterSyntax ?? throw new NullReferenceException("AsNode() returned null!");
            SyntaxTrivia                   trivia          = properties[i + 1].AsToken().TrailingTrivia.First(x => x.IsKind(SyntaxKind.MultiLineCommentTrivia));

            FunctionPointerParameter fpp;
            fpp.ParameterSyntax = parameterSyntax;
            fpp.Name            = trivia.ToFullString().Trim(' ', '*', '/');
            fpp.Type            = parameterSyntax.ToString();

            fpi.Parameters.Add(fpp);
        }

        fpi.ReturnType = (properties[properties.Length - 1].AsNode() as FunctionPointerParameterSyntax ?? throw new NullReferenceException("AsNode() returned null!")).ToString();

        fpi.TypeSymbol = fieldSymbol.Type;

        vkExtensionClass.Functions.Add(fpi);
    }
}