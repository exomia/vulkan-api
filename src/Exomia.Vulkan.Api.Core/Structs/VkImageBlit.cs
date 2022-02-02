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
///     VkImageBlit - Structure specifying an image blit operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageBlit.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageBlit.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageBlit
{
    /// <summary>srcSubresource is the subresource to blit from.</summary>
    public VkImageSubresourceLayers srcSubresource;

    /// <summary>
    ///     srcOffsets is a pointer to an array of two VkOffset3Dstructures specifying the bounds of the source region
    ///     within srcSubresource.
    /// </summary>
    public VkArray2<VkOffset3D> srcOffsets;

    /// <summary>dstSubresource is the subresource to blit into.</summary>
    public VkImageSubresourceLayers dstSubresource;

    /// <summary>
    ///     dstOffsets is a pointer to an array of two VkOffset3Dstructures specifying the bounds of the destination
    ///     region within dstSubresource.
    /// </summary>
    public VkArray2<VkOffset3D> dstOffsets;
}