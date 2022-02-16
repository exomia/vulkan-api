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
///     VkPhysicalDevice4444FormatsFeaturesEXT - Structure describing additional 4444 formats supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice4444FormatsFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice4444FormatsFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     formatA4R4G4B4 indicates that the implementation must support using a VkFormat of
    ///     VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT with at least the following
    ///     VkFormatFeatureFlagBits:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BITVK_FORMAT_FEATURE_BLIT_SRC_BITVK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT
    /// </summary>
    public VkBool32 formatA4R4G4B4;

    /// <summary>
    ///     formatA4B4G4R4 indicates that the implementation must support using a VkFormat of
    ///     VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT with at least the following
    ///     VkFormatFeatureFlagBits:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BITVK_FORMAT_FEATURE_BLIT_SRC_BITVK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT
    /// </summary>
    public VkBool32 formatA4B4G4R4;
}