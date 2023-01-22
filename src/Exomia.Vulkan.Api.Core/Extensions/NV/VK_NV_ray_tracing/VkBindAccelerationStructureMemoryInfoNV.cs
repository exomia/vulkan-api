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
///     VkBindAccelerationStructureMemoryInfoNV - Structure specifying acceleration structure memory binding -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindAccelerationStructureMemoryInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindAccelerationStructureMemoryInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>accelerationStructure is the acceleration structure to be attached to memory.</summary>
    public VkAccelerationStructureNV accelerationStructure;

    /// <summary>memory is a VkDeviceMemory object describing the device memory to attach.</summary>
    public VkDeviceMemory memory;

    /// <summary>
    ///     memoryOffset is the start offset of the region of memory that is to be bound to the acceleration structure.
    ///     The number of bytes returned in the VkMemoryRequirements::size member in memory, starting from memoryOffset bytes,
    ///     will be bound to the specified acceleration structure.
    /// </summary>
    public VkDeviceSize memoryOffset;

    /// <summary>deviceIndexCount is the number of elements in pDeviceIndices.</summary>
    public uint deviceIndexCount;

    /// <summary>pDeviceIndices is a pointer to an array of device indices.</summary>
    public uint* pDeviceIndices;
}