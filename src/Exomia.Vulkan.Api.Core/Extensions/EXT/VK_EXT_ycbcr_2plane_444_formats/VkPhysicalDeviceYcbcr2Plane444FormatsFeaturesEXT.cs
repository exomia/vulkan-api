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
///     VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT - Structure describing whether the implementation supports
///     additional 2-plane 444 Y′CBCR formats -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     ycbcr2plane444Formats indicates that the implementation supports the following 2-plane 444
    ///     Y′CBCRformats:VK_FORMAT_G8_B8R8_2PLANE_444_UNORMVK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16VK_FORMAT_G16_B16R16_2PLANE_444_UNORM
    /// </summary>
    public VkBool32 ycbcr2plane444Formats;
}