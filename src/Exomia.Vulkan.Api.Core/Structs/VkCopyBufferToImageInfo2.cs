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
///     VkCopyBufferToImageInfo2 - Structure specifying parameters of a buffer to image copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyBufferToImageInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyBufferToImageInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferToImageInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcBuffer is the source buffer.</summary>
    public VkBuffer srcBuffer;

    /// <summary>dstImage is the destination image.</summary>
    public VkImage dstImage;

    /// <summary>dstImageLayout is the layout of the destination image subresources for the copy.</summary>
    public VkImageLayout dstImageLayout;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkBufferImageCopy2structures specifying the regions to copy.</summary>
    public VkBufferImageCopy2* pRegions;
}