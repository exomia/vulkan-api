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
///     VkPhysicalDeviceSubgroupProperties - Structure describing subgroup support for an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPhysicalDeviceProperties2 </description>
///         </item>
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> subgroupSize is the default number of invocations in each subgroup. subgroupSize is at least 1 if any of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. subgroupSize is a power-of-two. </summary>
    public uint subgroupSize;

    /// <summary> supportedStages is a bitfield of VkShaderStageFlagBits describing the shader stages that group operations with subgroup scope are supported in. supportedStages will have the VK_SHADER_STAGE_COMPUTE_BITbit set if any of the physical device&#8217;s queues support VK_QUEUE_COMPUTE_BIT. </summary>
    public VkShaderStageFlags supportedStages;

    /// <summary> supportedOperations is a bitmask of VkSubgroupFeatureFlagBits specifying the sets of group operations with subgroup scope supported on this device. supportedOperations will have the VK_SUBGROUP_FEATURE_BASIC_BIT bit set if any of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. </summary>
    public VkSubgroupFeatureFlags supportedOperations;

    /// <summary> quadOperationsInAllStages is a boolean specifying whether quad group operations are available in all stages, or are restricted to fragment and compute stages. </summary>
    public VkBool32 quadOperationsInAllStages;
}