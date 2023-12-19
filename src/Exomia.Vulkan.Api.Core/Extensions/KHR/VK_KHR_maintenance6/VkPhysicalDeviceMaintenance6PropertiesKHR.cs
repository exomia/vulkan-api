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
///     VkPhysicalDeviceMaintenance6PropertiesKHR - Structure describing various implementation-defined properties
///     introduced with VK_KHR_maintenance6 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance6PropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance6PropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance6PropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     blockTexelViewCompatibleMultipleLayers is a boolean value indicating that an implementation supports creating
    ///     image views with VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT where the layerCount member of subresourceRange is
    ///     greater than 1.
    /// </summary>
    public VkBool32 blockTexelViewCompatibleMultipleLayers;

    /// <summary>
    ///     maxCombinedImageSamplerDescriptorCount is the maximum number of combined image sampler descriptors that the
    ///     implementation uses to access any of the formats that require a sampler Y′CBCR conversion supported by the
    ///     implementation.
    /// </summary>
    public uint maxCombinedImageSamplerDescriptorCount;

    /// <summary>
    ///     fragmentShadingRateClampCombinerInputs is a boolean value indicating that an implementation clamps the inputs
    ///     to combiner operations.
    /// </summary>
    public VkBool32 fragmentShadingRateClampCombinerInputs;
}