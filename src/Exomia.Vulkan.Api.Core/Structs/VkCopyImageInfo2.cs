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
///     VkCopyImageInfo2 - Structure specifying parameters of an image copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcImage is the source image.</summary>
    public VkImage srcImage;

    /// <summary>srcImageLayout is the current layout of the source image subresource.</summary>
    public VkImageLayout srcImageLayout;

    /// <summary>dstImage is the destination image.</summary>
    public VkImage dstImage;

    /// <summary>dstImageLayout is the current layout of the destination image subresource.</summary>
    public VkImageLayout dstImageLayout;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkImageCopy2 structures specifying the regions to copy.</summary>
    public VkImageCopy2* pRegions;
}