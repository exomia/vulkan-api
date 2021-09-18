#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace Exomia.Vulkan.Api.SourceGenerator
{
    class SourceCodeBuilder
    {
        private readonly StringBuilder _src;

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
            return SyntaxFactory.ParseSyntaxTree(SourceText.From(_src.ToString()))
                                .GetRoot()
                                .NormalizeWhitespace()
                                .ToFullString();
        }
    }
}