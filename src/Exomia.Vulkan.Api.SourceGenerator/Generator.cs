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
                foreach (VkExtensionClass className in syntaxReceiver.VkExtensionFunctionModel)
                {
                    {
                        string sourceCode = $@"using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core.Extensions 
{{
    {SourceCodeGenerator.GetExtensionClass(className)}
}}".FormatCode();
                        context.AddSource($"{className.NamespaceName}.{className.ClassName}.g.cs", sourceCode);
                    }

                    if (className.Functions.Any()) // *.Delegates.g.cs
                    {
                        string sourceCode = $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions 
{{
    {string.Join(Environment.NewLine, className.Functions.Select(SourceCodeGenerator.GetDelegates))}
}}".FormatCode();
                        context.AddSource($"{className.NamespaceName}.{className.ClassName}.Delegates.g.cs", sourceCode);
                    }

                    if (className.Functions.Any()) // *.Structs.Delegates.g.cs
                    {
                        string sourceCode = $@"#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions 
{{
    {string.Join(Environment.NewLine, className.Functions.Select(SourceCodeGenerator.GetStructsDelegates))}
}}".FormatCode();
                        context.AddSource($"{className.NamespaceName}.{className.ClassName}.Structs.Delegates.g.cs", sourceCode);
                    }
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