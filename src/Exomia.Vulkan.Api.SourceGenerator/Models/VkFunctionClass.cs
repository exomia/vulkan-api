#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exomia.Vulkan.Api.SourceGenerator.Models;

struct VkFunctionClass
{
    public string                  NamespaceName;
    public string                  ClassName;
    public INamedTypeSymbol        Symbol;
    public StructDeclarationSyntax Syntax;
}