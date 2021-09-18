﻿#region License

// Copyright (c) 2018-2021, exomia
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

namespace Exomia.Vulkan.Api.SourceGenerator
{
    static class CodeGenerationLibraryLoader
    {
        internal static void AddLibraryFilesToContext(GeneratorPostInitializationContext context)
        {
            Assembly            assembly                 = typeof(CodeGenerationLibraryLoader).Assembly;
            IEnumerable<string> embeddedLibraryCodeFiles = assembly.GetManifestResourceNames().Where(x => x.EndsWith(nameof(Attribute) + ".cs"));

            foreach (var codeFile in embeddedLibraryCodeFiles)
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
    }
}