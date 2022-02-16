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
///     VkImageMemoryBarrier2 - Structure specifying an image memory barrier -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     srcStageMask is a VkPipelineStageFlags2 mask of pipeline stages to be included in the first synchronization
    ///     scope.
    /// </summary>
    public VkPipelineStageFlags2 srcStageMask;

    /// <summary>srcAccessMask is a VkAccessFlags2 mask of access flags to be included in the first access scope.</summary>
    public VkAccessFlags2 srcAccessMask;

    /// <summary>
    ///     dstStageMask is a VkPipelineStageFlags2 mask of pipeline stages to be included in the second synchronization
    ///     scope.
    /// </summary>
    public VkPipelineStageFlags2 dstStageMask;

    /// <summary>dstAccessMask is a VkAccessFlags2 mask of access flags to be included in the second access scope.</summary>
    public VkAccessFlags2 dstAccessMask;

    /// <summary>oldLayout is the old layout in an image layout transition.</summary>
    public VkImageLayout oldLayout;

    /// <summary>newLayout is the new layout in an image layout transition.</summary>
    public VkImageLayout newLayout;

    /// <summary>srcQueueFamilyIndex is the source queue family for a queue family ownership transfer.</summary>
    public uint srcQueueFamilyIndex;

    /// <summary>dstQueueFamilyIndex is the destination queue family for a queue family ownership transfer.</summary>
    public uint dstQueueFamilyIndex;

    /// <summary>image is a handle to the image affected by this barrier.</summary>
    public VkImage image;

    /// <summary>subresourceRange describes the image subresource range within image that is affected by this barrier.</summary>
    public VkImageSubresourceRange subresourceRange;
}