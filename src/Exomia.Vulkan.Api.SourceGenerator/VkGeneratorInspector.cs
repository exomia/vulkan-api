using Exomia.Vulkan.Api.SourceGenerator.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    internal class VkGeneratorInspector
    {
        const string VK_IGNORE_ATTRIBUTE = "Exomia.Vulkan.Api.SourceGenerator.VkIgnoreAttribute";

        internal static async Task<VkExtensionClass> InspectAsync(INamedTypeSymbol viewModelClassSymbol)
        {
            VkExtensionClass vkExtentionClass = new()
            {
                ClassName = viewModelClassSymbol.Name,
                Functions = new List<FunctionPointerInfo>()
            };

            foreach (var member in viewModelClassSymbol.GetMembers())
            {
                Console.WriteLine(member.Name);
                switch (member)
                {
                    case IMethodSymbol methodSymbol:
                        if (methodSymbol.Name == "Load")
                        {
                            vkExtentionClass.LoadFunction = methodSymbol;
                        }
                        break;
                    case IFieldSymbol fieldSymbol:
                        vkExtentionClass = await FindPropertiesToGenerateAsync(fieldSymbol, vkExtentionClass);
                        break;
                }
            }

            return vkExtentionClass;
        }


        private static async Task<VkExtensionClass> FindPropertiesToGenerateAsync(IFieldSymbol fieldSymbol, VkExtensionClass vkExtentionClass)
        {

            if (fieldSymbol.IsConst && fieldSymbol.Name.EndsWith("EXTENSION_NAME") && fieldSymbol.Type.Name == "String")
            {
                vkExtentionClass.VarExtentionName = fieldSymbol.Name;
                vkExtentionClass.ExtentionName = fieldSymbol.ConstantValue as string;
                return vkExtentionClass;
            }

            var attributeDatas = fieldSymbol.GetAttributes();
            var fieldAttributeData = attributeDatas.FirstOrDefault(x => x.AttributeClass?.ToDisplayString() == VK_IGNORE_ATTRIBUTE);

            if(fieldAttributeData is not null) // vkIgnore is present 
            {
                return vkExtentionClass;
            }

            var fieldSyntax = (await fieldSymbol.DeclaringSyntaxReferences[0].GetSyntaxAsync()).Parent;
            var fieldSyntaxChilds = fieldSyntax.DescendantNodes()?.OfType<FunctionPointerTypeSyntax>()?.FirstOrDefault();
            if(fieldSyntaxChilds is null) // field is not a function pointer
            {
                return vkExtentionClass;
            }

            FunctionPointerInfo fpi;
            fpi.Name = fieldSymbol.Name;
            fpi.Parameters = new List<FunctionPointerParameter>();
           
            var properties = fieldSyntaxChilds.ParameterList.DescendantNodesAndTokens()
                .Where(x => x.AsNode() as FunctionPointerParameterSyntax is not null || x.AsToken().IsKind(SyntaxKind.CommaToken))
                .ToArray();
            
            for (int i = 0; i < properties.Length - 1; i += 2)
			{
                FunctionPointerParameterSyntax parameterSyntax = properties[i].AsNode() as FunctionPointerParameterSyntax;
                SyntaxTrivia trivias = properties[i + 1].AsToken().TrailingTrivia.Where(x => x.IsKind(SyntaxKind.MultiLineCommentTrivia)).First();

                FunctionPointerParameter fpp;
                fpp.IsReturnParameter = false;
                fpp.ParameterSyntax = parameterSyntax;
                fpp.Name = trivias.ToFullString().Trim(' ', '*', '/');
                fpp.Type = parameterSyntax.ToString();

                fpi.Parameters.Add(fpp);
            }

            vkExtentionClass.Functions.Add(fpi);
            return vkExtentionClass;
        }
    }
}