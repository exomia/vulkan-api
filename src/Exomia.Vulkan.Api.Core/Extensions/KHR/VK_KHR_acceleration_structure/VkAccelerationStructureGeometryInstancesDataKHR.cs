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
///     VkAccelerationStructureGeometryInstancesDataKHR - Structure specifying a geometry consisting of instances of other
///     acceleration structures -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryInstancesDataKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryInstancesDataKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>arrayOfPointers specifies whether data is used as an array of addresses or just an array.</summary>
    public VkBool32 arrayOfPointers;

    /// <summary>
    ///     data is either the address of an array of device or host addresses referencing individual
    ///     VkAccelerationStructureInstanceKHRstructures or packed motion instance information as described in motion
    ///     instancesif arrayOfPointers is VK_TRUE, or the address of an array of VkAccelerationStructureInstanceKHRor
    ///     VkAccelerationStructureMotionInstanceNVstructures. Addresses and VkAccelerationStructureInstanceKHR structures are
    ///     tightly packed. VkAccelerationStructureMotionInstanceNV structures have a stride of 160 bytes.
    /// </summary>
    public VkDeviceOrHostAddressConstKHR data;
}