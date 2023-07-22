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
///     VkCopyImageToMemoryInfoEXT - Structure specifying parameters of an image to host memory copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageToMemoryInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageToMemoryInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToMemoryInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkHostImageCopyFlagBitsEXT values describing additional copy parameters.</summary>
    public VkHostImageCopyFlagsEXT flags;

    /// <summary>srcImage is the source image.</summary>
    public VkImage srcImage;

    /// <summary>srcImageLayout is the layout of the source image subresources for the copy.</summary>
    public VkImageLayout srcImageLayout;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkImageToMemoryCopyEXTstructures specifying the regions to copy.</summary>
    public VkImageToMemoryCopyEXT* pRegions;
}