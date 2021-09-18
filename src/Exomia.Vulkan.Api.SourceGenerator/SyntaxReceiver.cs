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
        private const string SOURCE_GENERATOR_ACTIVE_NAME = "Exomia.Vulkan.Api.SourceGenerator.VkExtGeneratorAttribute";

        public List<VkExtensionClass> VkExtensionFunctionModel { get; } = new();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclaration)
            {
                INamedTypeSymbol? viewModelClassSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);
                AttributeData? viewModelAttributeData =
                    viewModelClassSymbol?
                        .GetAttributes()
                        .SingleOrDefault(x => x.AttributeClass?.ToDisplayString() == SOURCE_GENERATOR_ACTIVE_NAME);

                if (viewModelClassSymbol is not null && viewModelAttributeData is not null)
                {
                    VkExtensionClass res =
                        VkGeneratorInspector.InspectAsync(viewModelClassSymbol)
                                            .ConfigureAwait(false)
                                            .GetAwaiter()
                                            .GetResult();
                    VkExtensionFunctionModel.Add(res);
                }

                string? className = classDeclaration.Identifier.Text;
            }
        }
    }
}