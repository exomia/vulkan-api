#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Collections.Generic;
using System.Linq;
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    class SyntaxReceiver : ISyntaxContextReceiver
    {
        private const string VK_EXT_GENERATOR_ATTRIBUTE      = "Exomia.Vulkan.Api.SourceGenerator.VkExtGeneratorAttribute";
        private const string VK_FUNCTION_GENERATOR_ATTRIBUTE = "Exomia.Vulkan.Api.SourceGenerator.VkFunctionGeneratorAttribute";

        public List<VkExtensionClass> VkExtensions { get; } = new();
        public List<VkFunctionClass>  VkFunctions  { get; } = new();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclaration)
            {
                INamedTypeSymbol? classSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);

                if (classSymbol is not null)
                {
                    AttributeData? vkExtensionAttributeData =
                        classSymbol.GetAttributes()
                                   .SingleOrDefault(x => x.AttributeClass?.ToDisplayString() == VK_EXT_GENERATOR_ATTRIBUTE);
                    if (vkExtensionAttributeData is not null)
                    {
                        VkExtensionClass vkExtensionClass = new()
                        {
                            NamespaceName = classSymbol.ContainingNamespace.ToDisplayString(),
                            ClassName     = classSymbol.Name,
                            Functions     = new List<FunctionPointerInfo>(),
                            Symbol        = classSymbol,
                            Syntax        = classDeclaration
                        };

                        foreach (ISymbol member in classSymbol.GetMembers())
                        {
                            switch (member)
                            {
                                case IMethodSymbol methodSymbol:
                                    if (methodSymbol.Name == "Load")
                                    {
                                        vkExtensionClass.LoadFunction = methodSymbol;
                                    }
                                    break;
                                case IFieldSymbol fieldSymbol:
                                    VkExtensionClassInspector.FindPropertiesToGenerate(fieldSymbol, ref vkExtensionClass);
                                    break;
                            }
                        }
                        VkExtensions.Add(vkExtensionClass);
                    }
                }
            }

            if (context.Node is StructDeclarationSyntax { AttributeLists: { Count: > 0 } } structDeclaration)
            {
                INamedTypeSymbol? structSymbol = context.SemanticModel.GetDeclaredSymbol(structDeclaration);

                if (structSymbol is not null)
                {
                    AttributeData? vkFunctionAttributeData =
                        structSymbol.GetAttributes()
                                    .SingleOrDefault(x => x.AttributeClass?.ToDisplayString() == VK_FUNCTION_GENERATOR_ATTRIBUTE);

                    if (vkFunctionAttributeData is not null)
                    {
                        VkFunctionClass vkFunctionClass = new()
                        {
                            NamespaceName = structSymbol.ContainingNamespace.ToDisplayString(), 
                            ClassName = structSymbol.Name,
                            Symbol = structSymbol,
                            Syntax = structDeclaration
                        };

                        VkFunctions.Add(vkFunctionClass);
                    }
                }
            }
        }
    }
}