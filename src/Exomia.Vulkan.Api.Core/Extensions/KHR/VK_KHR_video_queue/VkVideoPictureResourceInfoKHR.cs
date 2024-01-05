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
///     VkVideoPictureResourceInfoKHR - Structure specifying the parameters of a video picture resource -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoPictureResourceInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoPictureResourceInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoPictureResourceInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>codedOffset is the offset in texels of the image subregion to use.</summary>
    public VkOffset2D codedOffset;

    /// <summary>codedExtent is the size in pixels of the coded image data.</summary>
    public VkExtent2D codedExtent;

    /// <summary>
    ///     baseArrayLayer is the array layer of the image view specified in imageViewBinding to use as the video picture
    ///     resource.
    /// </summary>
    public uint baseArrayLayer;

    /// <summary>imageViewBinding is an image view representing the video picture resource.</summary>
    public VkImageView imageViewBinding;
}