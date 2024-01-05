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
///     VkExtent2D - Structure specifying a two-dimensional extent -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtent2D.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtent2D.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkExtent2D
{
    /// <summary>width is the width of the extent.</summary>
    public uint width;

    /// <summary>height is the height of the extent.</summary>
    public uint height;
}