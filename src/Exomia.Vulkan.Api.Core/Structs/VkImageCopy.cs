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
///     VkImageCopy - Structure specifying an image copy operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCopy.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCopy.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageCopy
{
    /// <summary>
    ///     srcSubresource and dstSubresource are VkImageSubresourceLayers structures specifying the image subresources of
    ///     the images used for the source and destination image data, respectively.
    /// </summary>
    public VkImageSubresourceLayers srcSubresource;

    /// <summary>
    ///     srcOffset and dstOffset select the initial x, y, and z offsets in texels of the sub-regions of the source and
    ///     destination image data.
    /// </summary>
    public VkOffset3D srcOffset;

    /// <summary>
    ///     srcSubresource and dstSubresource are VkImageSubresourceLayers structures specifying the image subresources of
    ///     the images used for the source and destination image data, respectively.
    /// </summary>
    public VkImageSubresourceLayers dstSubresource;

    /// <summary>
    ///     srcOffset and dstOffset select the initial x, y, and z offsets in texels of the sub-regions of the source and
    ///     destination image data.
    /// </summary>
    public VkOffset3D dstOffset;

    /// <summary>extent is the size in texels of the image to copy in width, height and depth.</summary>
    public VkExtent3D extent;
}