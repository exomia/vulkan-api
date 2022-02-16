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
///     VkBlitImageInfo2 - Structure specifying parameters of blit image command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlitImageInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlitImageInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcImage is the source image.</summary>
    public VkImage srcImage;

    /// <summary>srcImageLayout is the layout of the source image subresources for the blit.</summary>
    public VkImageLayout srcImageLayout;

    /// <summary>dstImage is the destination image.</summary>
    public VkImage dstImage;

    /// <summary>dstImageLayout is the layout of the destination image subresources for the blit.</summary>
    public VkImageLayout dstImageLayout;

    /// <summary>regionCount is the number of regions to blit.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkImageBlit2 structures specifying the regions to blit.</summary>
    public VkImageBlit2* pRegions;

    /// <summary>filter is a VkFilter specifying the filter to apply if the blits require scaling.</summary>
    public VkFilter filter;
}