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
///     VkDeviceGroupDeviceCreateInfo - Create a logical device from multiple physical devices -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupDeviceCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupDeviceCreateInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>physicalDeviceCount is the number of elements in the pPhysicalDevices array.</summary>
    public uint physicalDeviceCount;

    /// <summary>pPhysicalDevices is a pointer to an array of physical device handles belonging to the same device group.</summary>
    public VkPhysicalDevice* pPhysicalDevices;
}