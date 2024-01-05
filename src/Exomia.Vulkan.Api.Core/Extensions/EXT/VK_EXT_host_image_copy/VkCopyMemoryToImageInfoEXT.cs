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
///     VkCopyMemoryToImageInfoEXT - Structure specifying parameters of host memory to image copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToImageInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkHostImageCopyFlagBitsEXT values describing additional copy parameters.</summary>
    public VkHostImageCopyFlagsEXT flags;

    /// <summary>dstImage is the destination image.</summary>
    public VkImage dstImage;

    /// <summary>dstImageLayout is the layout of the destination image subresources for the copy.</summary>
    public VkImageLayout dstImageLayout;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkMemoryToImageCopyEXTstructures specifying the regions to copy.</summary>
    public VkMemoryToImageCopyEXT* pRegions;
}