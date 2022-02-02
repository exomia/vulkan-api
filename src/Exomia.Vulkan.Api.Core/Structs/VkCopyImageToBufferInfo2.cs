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
///     VkCopyImageToBufferInfo2 - Structure specifying parameters of an image to buffer copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageToBufferInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyImageToBufferInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToBufferInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcImage is the source image.</summary>
    public VkImage srcImage;

    /// <summary>srcImageLayout is the layout of the source image subresources for the copy.</summary>
    public VkImageLayout srcImageLayout;

    /// <summary>dstBuffer is the destination buffer.</summary>
    public VkBuffer dstBuffer;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkBufferImageCopy2structures specifying the regions to copy.</summary>
    public VkBufferImageCopy2* pRegions;
}