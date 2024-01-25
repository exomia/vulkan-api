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
///     VkRect2D - Structure specifying a two-dimensional subregion -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRect2D.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRect2D.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkRect2D
{
    /// <summary>offset is a VkOffset2D specifying the rectangle offset.</summary>
    public VkOffset2D offset;

    /// <summary>extent is a VkExtent2D specifying the rectangle extent.</summary>
    public VkExtent2D extent;
}