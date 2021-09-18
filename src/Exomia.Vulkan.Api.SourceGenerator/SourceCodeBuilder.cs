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
    static class StringBuilderExtensions
    {
        public static string FormatCode(this StringBuilder stringBuilder)
        {
            return SyntaxFactory.ParseSyntaxTree(SourceText.From(stringBuilder.ToString()))
                                .GetRoot()
                                .NormalizeWhitespace()
                                .ToFullString();
        }
    }
}