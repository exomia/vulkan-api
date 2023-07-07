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
///     VkImageMemoryBarrier - Structure specifying the parameters of an image memory barrier -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcAccessMask is a bitmask of VkAccessFlagBits specifying a source access mask.</summary>
    public VkAccessFlags srcAccessMask;

    /// <summary>dstAccessMask is a bitmask of VkAccessFlagBits specifying a destination access mask.</summary>
    public VkAccessFlags dstAccessMask;

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