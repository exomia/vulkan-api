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
///     VkSparseImageMemoryBind - Structure specifying sparse image memory bind -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryBind.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryBind.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSparseImageMemoryBind
{
    /// <summary>subresource is the image aspect and region of interest in the image.</summary>
    public VkImageSubresource subresource;

    /// <summary>offset are the coordinates of the first texel within the image subresource to bind.</summary>
    public VkOffset3D offset;

    /// <summary>
    ///     extent is the size in texels of the region within the image subresource to bind. The extent must be a multiple
    ///     of the sparse image block dimensions, except when binding sparse image blocks along the edge of an image
    ///     subresource it can instead be such that any coordinate of offset +  extent equals the corresponding dimensions of
    ///     the image subresource.
    /// </summary>
    public VkExtent3D extent;

    /// <summary>
    ///     memory is the VkDeviceMemory object that the sparse image blocks of the image are bound to. If memory is
    ///     VK_NULL_HANDLE, the sparse image blocks are unbound.
    /// </summary>
    public VkDeviceMemory memory;

    /// <summary>memoryOffset is an offset into VkDeviceMemory object. If memory is VK_NULL_HANDLE, this value is ignored.</summary>
    public VkDeviceSize memoryOffset;

    /// <summary>flags are sparse memory binding flags.</summary>
    public VkSparseMemoryBindFlags flags;
}