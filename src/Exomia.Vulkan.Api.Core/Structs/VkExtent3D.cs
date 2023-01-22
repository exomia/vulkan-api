#region License

// Copyright (c) 2018-2023, exomia
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
///     VkExtent3D - Structure specifying a three-dimensional extent -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtent3D.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtent3D.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkExtent3D
{
    /// <summary>width is the width of the extent.</summary>
    public uint width;

    /// <summary>height is the height of the extent.</summary>
    public uint height;

    /// <summary>depth is the depth of the extent.</summary>
    public uint depth;
}