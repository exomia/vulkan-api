#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Linq;
using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    /// <summary> A generator. </summary>
    [Generator]
    public class Generator : ISourceGenerator
    {
        /// <inheritdoc />
        public void Execute(GeneratorExecutionContext context)
        {
            if (context.SyntaxContextReceiver is SyntaxReceiver syntaxReceiver)
            {
                foreach (VkExtensionClass vkExtensionClass in syntaxReceiver.VkExtensions)
                {
                    {
                        string sourceCode = $@"using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace {vkExtensionClass.NamespaceName}
{{
    {SourceCodeGenerator.GetExtensionClass(vkExtensionClass)}
}}".FormatCode();
                        context.AddSource($"{vkExtensionClass.NamespaceName}.{vkExtensionClass.ClassName}.g.cs", sourceCode);
                    }

                    if (vkExtensionClass.Functions.Any()) // *.Delegates.g.cs
                    {
                        string sourceCode = $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace {vkExtensionClass.NamespaceName} 
{{
    {string.Join(Environment.NewLine, vkExtensionClass.Functions.Select(SourceCodeGenerator.GetDelegates))}
}}".FormatCode();
                        context.AddSource($"{vkExtensionClass.NamespaceName}.{vkExtensionClass.ClassName}.Delegates.g.cs", sourceCode);
                    }

                    if (vkExtensionClass.Functions.Any()) // *.Structs.Delegates.g.cs
                    {
                        string sourceCode = $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace {vkExtensionClass.NamespaceName}
{{
    {string.Join(Environment.NewLine, vkExtensionClass.Functions.Select(SourceCodeGenerator.GetStructsDelegates))}
}}".FormatCode();
                        context.AddSource($"{vkExtensionClass.NamespaceName}.{vkExtensionClass.ClassName}.Structs.Delegates.g.cs", sourceCode);
                    }
                }

                foreach (VkFunctionClass vkFunctionClass in syntaxReceiver.VkFunctions)
                {
                    string sourceCode = $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace {vkFunctionClass.NamespaceName}
{{
    {SourceCodeGenerator.GetStructDeclaration(vkFunctionClass)}
    {{
        {string.Join(Environment.NewLine, syntaxReceiver.VkExtensions.SelectMany(e => e.Functions).Select(SourceCodeGenerator.GetVkFunctions))}
    }}
}}".FormatCode();
                    context.AddSource($"{vkFunctionClass.NamespaceName}.{vkFunctionClass.ClassName}.g.cs", sourceCode);
                }
            }
        }

        /// <inheritdoc />
        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForPostInitialization(CodeGenerationLibraryLoader.AddLibraryFilesToContext);
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }
    }
}