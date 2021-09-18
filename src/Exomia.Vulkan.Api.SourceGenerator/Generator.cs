using Microsoft.CodeAnalysis;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var mainMethod = context.Compilation.GetEntryPoint(context.CancellationToken);

            if (context.SyntaxContextReceiver is SyntaxReceiver syntaxReceiver)
            {
                foreach (var className in syntaxReceiver.VkExtentionFunctionModel)
                {
                    SourceCodeBuilder codeBuilder = new SourceCodeBuilder();
                    codeBuilder.InsertCode($@"using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core.Extensions 
{{
    {SourceCodeGenerator.GetExtentionClass(className)}
}}");

                    string sourceCode = codeBuilder.Build();
                    context.AddSource($"{className.ClassName}.g.cs", sourceCode);
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

