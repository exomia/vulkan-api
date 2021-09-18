#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Text;
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            if (context.SyntaxContextReceiver is SyntaxReceiver syntaxReceiver)
            {
                foreach (VkExtensionClass className in syntaxReceiver.VkExtensionFunctionModel)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(
                        $@"using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core.Extensions 
{{
    {SourceCodeGenerator.GetExtensionClass(className)}
}}");

                    string sourceCode = stringBuilder.FormatCode();
                    context.AddSource($"{className.NamespaceName}.{className.ClassName}.g.cs", sourceCode);
                }
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForPostInitialization(CodeGenerationLibraryLoader.AddLibraryFilesToContext);
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }
    }
}