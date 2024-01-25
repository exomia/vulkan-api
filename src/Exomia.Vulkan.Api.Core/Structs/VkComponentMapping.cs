#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkComponentMapping - Structure specifying a color component mapping -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentMapping.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentMapping.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkComponentMapping
{
    /// <summary>r is a VkComponentSwizzle specifying the component value placed in the R component of the output vector.</summary>
    public VkComponentSwizzle r;

    /// <summary>g is a VkComponentSwizzle specifying the component value placed in the G component of the output vector.</summary>
    public VkComponentSwizzle g;

    /// <summary>b is a VkComponentSwizzle specifying the component value placed in the B component of the output vector.</summary>
    public VkComponentSwizzle b;

    /// <summary>a is a VkComponentSwizzle specifying the component value placed in the A component of the output vector.</summary>
    public VkComponentSwizzle a;
}