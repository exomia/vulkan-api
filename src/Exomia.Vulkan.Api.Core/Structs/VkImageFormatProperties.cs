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
///     VkImageFormatProperties - Structure specifying an image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkImageFormatProperties
{
    /// <summary>
    ///     maxExtent are the maximum image dimensions. See the Allowed Extent Values section below for how these values
    ///     are constrained by type.
    /// </summary>
    public VkExtent3D maxExtent;

    /// <summary>
    ///     maxMipLevels is the maximum number of mipmap levels. maxMipLevels must be equal to the number of levels in the
    ///     complete mipmap chain based on the maxExtent.width, maxExtent.height, and maxExtent.depth, except when one of the
    ///     following conditions is true, in which case it mayinstead be 1:vkGetPhysicalDeviceImageFormatProperties::tiling was
    ///     VK_IMAGE_TILING_LINEARVkPhysicalDeviceImageFormatInfo2::tiling was VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXTthe
    ///     VkPhysicalDeviceImageFormatInfo2::pNext chain included a VkPhysicalDeviceExternalImageFormatInfo structure with a
    ///     handle type included in the handleTypes member for which mipmap image support is not requiredimage format is one of
    ///     the formats that require a sampler Y′CBCR conversionflags contains VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT
    /// </summary>
    public uint maxMipLevels;

    /// <summary>
    ///     maxArrayLayers is the maximum number of array layers. maxArrayLayers must be no less than
    ///     VkPhysicalDeviceLimits::maxImageArrayLayers, except when one of the following conditions is true, in which case it
    ///     may instead be 1:tiling is VK_IMAGE_TILING_LINEARtiling is VK_IMAGE_TILING_OPTIMAL and type is
    ///     VK_IMAGE_TYPE_3Dformat is one of the formats that require a sampler Y′CBCR conversion
    /// </summary>
    public uint maxArrayLayers;

    /// <summary>
    ///     sampleCounts is a bitmask of VkSampleCountFlagBitsspecifying all the supported sample counts for this image as
    ///     described below.
    /// </summary>
    public VkSampleCountFlags sampleCounts;

    /// <summary>
    ///     maxResourceSize is an upper bound on the total image size in bytes, inclusive of all image subresources.
    ///     Implementations may have an address space limit on total size of a resource, which is advertised by this property.
    ///     maxResourceSize must be at least 231.
    /// </summary>
    public VkDeviceSize maxResourceSize;
}