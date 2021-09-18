using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    internal class SyntaxReceiver : ISyntaxContextReceiver
    {
        private const string SOURE_GENERATOR_ACTIVE_NAME = "Exomia.Vulkan.Api.SourceGenerator.VkExtGeneratorAttribute";

        public List<VkExtensionClass> VkExtentionFunctionModel { get; private set; } = new();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclaration)
            {
                var viewModelClassSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);
                var viewModelAttributeData = viewModelClassSymbol?.GetAttributes()
                    .SingleOrDefault(x
                        => x.AttributeClass?.ToDisplayString() == SOURE_GENERATOR_ACTIVE_NAME);

                if (viewModelClassSymbol is not null && viewModelAttributeData is not null)
                {
                    var res = VkGeneratorInspector.InspectAsync(viewModelClassSymbol)
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult();
                    
                    VkExtentionFunctionModel.Add(res);
                }

                var className = classDeclaration.Identifier.Text;
            }
        }
    }
}

