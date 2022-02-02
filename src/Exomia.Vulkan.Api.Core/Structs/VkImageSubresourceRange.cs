#region License

// Copyright (c) 2018-2022, exomia
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
///     VkImageSubresourceRange - Structure specifying an image subresource range -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceRange.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceRange.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageSubresourceRange
{
    /// <summary>
    ///     aspectMask is a bitmask of VkImageAspectFlagBits specifying which aspect(s) of the image are included in the
    ///     view.
    /// </summary>
    public VkImageAspectFlags aspectMask;

    /// <summary>baseMipLevel is the first mipmap level accessible to the view.</summary>
    public uint baseMipLevel;

    /// <summary>levelCount is the number of mipmap levels (starting from baseMipLevel) accessible to the view.</summary>
    public uint levelCount;

    /// <summary>baseArrayLayer is the first array layer accessible to the view.</summary>
    public uint baseArrayLayer;

    /// <summary>layerCount is the number of array layers (starting from baseArrayLayer) accessible to the view.</summary>
    public uint layerCount;
}