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
///     VkImageSubresourceLayers - Structure specifying an image subresource layers -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceLayers.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceLayers.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageSubresourceLayers
{
    /// <summary>
    ///     aspectMask is a combination of VkImageAspectFlagBits, selecting the color, depth and/or stencil aspects to be
    ///     copied.
    /// </summary>
    public VkImageAspectFlags aspectMask;

    /// <summary>mipLevel is the mipmap level to copy</summary>
    public uint mipLevel;

    /// <summary>baseArrayLayer and layerCount are the starting layer and number of layers to copy.</summary>
    public uint baseArrayLayer;

    /// <summary>baseArrayLayer and layerCount are the starting layer and number of layers to copy.</summary>
    public uint layerCount;
}