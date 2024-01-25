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
///     VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR - Structure describing the ray tracing maintenance features that
///     can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR.html
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
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     rayTracingMaintenance1indicates that the implementation supports the following:The CullMaskKHR SPIR-V builtin
    ///     using the SPV_KHR_ray_cull_maskSPIR-V extension.Additional acceleration structure property queries:
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHRand
    ///     VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR.A new access flag VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR.A new
    ///     pipeline stage flag bit VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR
    /// </summary>
    public VkBool32 rayTracingMaintenance1;

    /// <summary>
    ///     rayTracingPipelineTraceRaysIndirect2 indicates whether the implementation supports the extended indirect ray
    ///     tracing command vkCmdTraceRaysIndirect2KHR.
    /// </summary>
    public VkBool32 rayTracingPipelineTraceRaysIndirect2;
}