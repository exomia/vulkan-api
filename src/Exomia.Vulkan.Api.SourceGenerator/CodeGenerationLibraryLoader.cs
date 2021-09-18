using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    internal static class CodeGenerationLibraryLoader
    {
        internal static void AddLibraryFilesToContext(GeneratorPostInitializationContext context)
        {
            var assembly = typeof(CodeGenerationLibraryLoader).Assembly;
            var embeddedLibraryCodeFiles = assembly.GetManifestResourceNames().Where(x => x.EndsWith(nameof(Attribute) + ".cs"));

            foreach (var codeFile in embeddedLibraryCodeFiles)
            {
                var codeFileContent = GetContentOfEmbeddedResource(assembly, codeFile);
                var fileNameHint = codeFile.Replace(".cs", ".g.cs");

                context.AddSource(fileNameHint, codeFileContent);
            }
        }

        private static string GetContentOfEmbeddedResource(Assembly assembly, string resourceName)
        {
            using var resourceStream = assembly.GetManifestResourceStream(resourceName);
            using var streamReader = new StreamReader(resourceStream);

            return streamReader.ReadToEnd();
        }
    }
}
