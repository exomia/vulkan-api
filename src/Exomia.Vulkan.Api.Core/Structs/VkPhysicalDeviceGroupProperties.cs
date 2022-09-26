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
///     VkPhysicalDeviceGroupProperties - Structure specifying physical device group properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGroupProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGroupProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGroupProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> physicalDeviceCount is the number of physical devices in the group. </summary>
    public uint physicalDeviceCount;

    /// <summary> physicalDevices is an array of VK_MAX_DEVICE_GROUP_SIZEVkPhysicalDevice handles representing all physical devices in the group. The first physicalDeviceCount elements of the array will be valid. </summary>
    public VkArray32<VkPhysicalDevice> physicalDevices;

    /// <summary> subsetAllocation specifies whether logical devices created from the group support allocating device memory on a subset of devices, via the deviceMask member of the VkMemoryAllocateFlagsInfo. If this is VK_FALSE, then all device memory allocations are made across all physical devices in the group. If physicalDeviceCount is 1, then subsetAllocation mustbe VK_FALSE. </summary>
    public VkBool32 subsetAllocation;
}