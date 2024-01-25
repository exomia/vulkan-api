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
///     VkPhysicalDeviceMaintenance5FeaturesKHR - Structure describing whether the implementation supports maintenance5
///     functionality -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance5FeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance5FeaturesKHR.html
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
public unsafe struct VkPhysicalDeviceMaintenance5FeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maintenance5 indicates that the implementation supports the following:The ability to expose support for the
    ///     optional format VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR.The ability to expose support for the optional format
    ///     VK_FORMAT_A8_UNORM_KHR.A property to indicate that multisample coverage operations are performed after sample
    ///     counting in EarlyFragmentTests mode.Creating a VkBufferView with a subset of the associated VkBuffer usage using
    ///     VkBufferUsageFlags2CreateInfoKHR.A new function vkCmdBindIndexBuffer2KHR, allowing a range of memory to be bound as
    ///     an index buffer.vkGetDeviceProcAddr will return NULL for function pointers of core functions for versions higher
    ///     than the version requested by the application.vkCmdBindVertexBuffers2 supports using VK_WHOLE_SIZE in the pSizes
    ///     parameter.If PointSize is not written, a default value of 1.0 is used for the size of
    ///     points.VkShaderModuleCreateInfo can be added as a chained structure to pipeline creation via
    ///     VkPipelineShaderStageCreateInfo, rather than having to create a shader module.A function
    ///     vkGetRenderingAreaGranularityKHR to query the optimal render area for a dynamic rendering instance.A property to
    ///     indicate that depth/stencil texturing operations with VK_COMPONENT_SWIZZLE_ONE have defined
    ///     behavior.vkGetDeviceImageSubresourceLayoutKHR allows an application to perform a vkGetImageSubresourceLayout query
    ///     without having to create an image.VK_REMAINING_ARRAY_LAYERS as the layerCount member of VkImageSubresourceLayers.A
    ///     property to indicate whether PointSize controls the final rasterization of polygons if polygon mode is
    ///     VK_POLYGON_MODE_POINT.Two properties to indicate the non-strict line rasterization algorithm used.Two new flags
    ///     words VkPipelineCreateFlagBits2KHR and VkBufferUsageFlagBits2KHR.Physical-device-level functions can now be called
    ///     with any value in the valid range for a type beyond the defined enumerants, such that applications can avoid
    ///     checking individual features, extensions, or versions before querying supported properties of a particular
    ///     enumerant.Copies between images of any type are allowed, with 1D images treated as 2D images with a height of 1.
    /// </summary>
    public VkBool32 maintenance5;
}