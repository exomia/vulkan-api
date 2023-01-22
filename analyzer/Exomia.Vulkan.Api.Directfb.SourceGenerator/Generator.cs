#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.Directfb.SourceGenerator;

/// <summary> A generator. </summary>
[Generator(LanguageNames.CSharp)]
public class Generator : IIncrementalGenerator
{
    private static void AddLibraryFilesToContext(IncrementalGeneratorPostInitializationContext context)
    {
        Assembly assembly                 = typeof(Generator).Assembly;
        string[] embeddedLibraryCodeFiles = assembly.GetManifestResourceNames();

        StringBuilder sbg = new(4096);
        StringBuilder sbb = new(4096);
        foreach (string codeFile in embeddedLibraryCodeFiles)
        {
            string codeFileContent = GetContentOfEmbeddedResource(assembly, codeFile);

            if (codeFile.EndsWith(".global-alias.cs"))
            {
                sbg.AppendLine(codeFileContent);
            }
            else if (codeFile.EndsWith(".bitmasks.cs"))
            {
                sbb.AppendLine(codeFileContent);
            }
        }
        context.AddSource("vk.global-alias.g.cs", sbg.ToString());
        context.AddSource("vk.bitmasks.g.cs",     sbb.ToString());
    }

    private static string GetContentOfEmbeddedResource(Assembly assembly, string resourceName)
    {
        using Stream       resourceStream = assembly.GetManifestResourceStream(resourceName) ?? throw new NullReferenceException(nameof(resourceName));
        using StreamReader streamReader   = new StreamReader(resourceStream);
        return streamReader.ReadToEnd();
    }

    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(AddLibraryFilesToContext);
    }
}