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
///     VkPhysicalDeviceSubgroupSizeControlProperties - Structure describing the control subgroup size properties of an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupSizeControlProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupSizeControlProperties.html
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
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     minSubgroupSize is the minimum subgroup size supported by this device. minSubgroupSize is at least one if any
    ///     of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. minSubgroupSize is a
    ///     power-of-two. minSubgroupSize is less than or equal to maxSubgroupSize. minSubgroupSize is less than or equal to
    ///     subgroupSize.
    /// </summary>
    public uint minSubgroupSize;

    /// <summary>
    ///     minSubgroupSize is the minimum subgroup size supported by this device. minSubgroupSize is at least one if any
    ///     of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. minSubgroupSize is a
    ///     power-of-two. minSubgroupSize is less than or equal to maxSubgroupSize. minSubgroupSize is less than or equal to
    ///     subgroupSize.
    /// </summary>
    public uint maxSubgroupSize;

    /// <summary>
    ///     maxComputeWorkgroupSubgroups is the maximum number of subgroups supported by the implementation within a
    ///     workgroup.
    /// </summary>
    public uint maxComputeWorkgroupSubgroups;

    /// <summary>
    ///     requiredSubgroupSizeStages is a bitfield of what shader stages support having a required subgroup size
    ///     specified.
    /// </summary>
    public VkShaderStageFlags requiredSubgroupSizeStages;
}