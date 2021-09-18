using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    class SourceCodeBuilder
    {
        private StringBuilder _src;
        public SourceCodeBuilder()
        {
            _src = new StringBuilder();
        }
       
        public void InsertCode(string code)
        {
              _src.Append(code);
        }

        public string Build()
        {
            return 
                SyntaxFactory.ParseSyntaxTree(
                    SourceText.From(
                        _src.ToString()))
                    .GetRoot()
                    .NormalizeWhitespace()
                    .ToFullString();
        }
    }
}
