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
///     VkPhysicalDeviceTextureCompressionASTCHDRFeatures - Structure describing ASTC HDR features that can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTextureCompressionASTCHDRFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTextureCompressionASTCHDRFeatures.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceFeatures2,VkDeviceCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> textureCompressionASTC_HDR indicates whether all of the ASTC HDR compressed texture formats are supported. If this feature is enabled, then the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, VK_FORMAT_FEATURE_BLIT_SRC_BIT and VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT features mustbe supported in optimalTilingFeatures for the following formats:VK_FORMAT_ASTC_4x4_SFLOAT_BLOCKVK_FORMAT_ASTC_5x4_SFLOAT_BLOCKVK_FORMAT_ASTC_5x5_SFLOAT_BLOCKVK_FORMAT_ASTC_6x5_SFLOAT_BLOCKVK_FORMAT_ASTC_6x6_SFLOAT_BLOCKVK_FORMAT_ASTC_8x5_SFLOAT_BLOCKVK_FORMAT_ASTC_8x6_SFLOAT_BLOCKVK_FORMAT_ASTC_8x8_SFLOAT_BLOCKVK_FORMAT_ASTC_10x5_SFLOAT_BLOCKVK_FORMAT_ASTC_10x6_SFLOAT_BLOCKVK_FORMAT_ASTC_10x8_SFLOAT_BLOCKVK_FORMAT_ASTC_10x10_SFLOAT_BLOCKVK_FORMAT_ASTC_12x10_SFLOAT_BLOCKVK_FORMAT_ASTC_12x12_SFLOAT_BLOCKTo query for additional properties, or if the feature is not enabled, vkGetPhysicalDeviceFormatProperties and vkGetPhysicalDeviceImageFormatProperties can be used to check for supported properties of individual formats as normal. </summary>
    public VkBool32 textureCompressionASTC_HDR;
}