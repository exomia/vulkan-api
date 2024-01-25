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
///     VkPhysicalDeviceMaintenance6FeaturesKHR - Structure describing whether the implementation supports maintenance6
///     functionality -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance6FeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance6FeaturesKHR.html
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
public unsafe struct VkPhysicalDeviceMaintenance6FeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maintenance6 indicates that the implementation supports the following:VK_NULL_HANDLE can be used when binding
    ///     an index bufferVkBindMemoryStatusKHR can be included in the pNext chain of the VkBindBufferMemoryInfo and
    ///     VkBindImageMemoryInfostructures, enabling applications to retrieve VkResult values for individual memory binding
    ///     operations.VkPhysicalDeviceMaintenance6PropertiesKHR::blockTexelViewCompatibleMultipleLayersproperty to indicate
    ///     that the implementation supports creating image views with VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT where
    ///     the layerCount member of subresourceRange is greater than
    ///     1.VkPhysicalDeviceMaintenance6PropertiesKHR::maxCombinedImageSamplerDescriptorCountproperty which indicates the
    ///     maximum descriptor size required for any format that requires a sampler Y′CBCR conversion supported by the
    ///     implementation.A VkPhysicalDeviceMaintenance6PropertiesKHR::fragmentShadingRateClampCombinerInputsproperty which
    ///     indicates whether the implementation clamps the inputs to fragment shading rate combiner operations.
    /// </summary>
    public VkBool32 maintenance6;
}