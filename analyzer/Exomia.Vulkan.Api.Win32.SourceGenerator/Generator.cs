#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.Win32.SourceGenerator;

/// <summary> A generator. </summary>
[Generator]
public class Generator : ISourceGenerator
{
    private static void AddLibraryFilesToContext(GeneratorPostInitializationContext context)
    {
        Assembly            assembly                 = typeof(Generator).Assembly;
        IEnumerable<string> embeddedLibraryCodeFiles = assembly.GetManifestResourceNames().Where(x => x.EndsWith(".cs"));

        foreach (string codeFile in embeddedLibraryCodeFiles)
        {
            string codeFileContent = GetContentOfEmbeddedResource(assembly, codeFile);
            string fileNameHint    = codeFile.Replace(".cs", ".g.cs");

            context.AddSource(fileNameHint, codeFileContent);
        }
    }

    private static string GetContentOfEmbeddedResource(Assembly assembly, string resourceName)
    {
        using Stream       resourceStream = assembly.GetManifestResourceStream(resourceName) ?? throw new NullReferenceException(nameof(resourceName));
        using StreamReader streamReader   = new StreamReader(resourceStream);
        return streamReader.ReadToEnd();
    }

    /// <inheritdoc />
    public void Execute(GeneratorExecutionContext _) { }

    /// <inheritdoc />
    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForPostInitialization(AddLibraryFilesToContext);
    }
}