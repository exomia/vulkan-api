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
///     VkCopyMemoryToAccelerationStructureInfoKHR - Parameters for deserializing an acceleration structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToAccelerationStructureInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToAccelerationStructureInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>src is the device or host address to memory containing the source data for the copy.</summary>
    public VkDeviceOrHostAddressConstKHR src;

    /// <summary>dst is the target acceleration structure for the copy.</summary>
    public VkAccelerationStructureKHR dst;

    /// <summary>
    ///     mode is a VkCopyAccelerationStructureModeKHR value specifying additional operations to perform during the
    ///     copy.
    /// </summary>
    public VkCopyAccelerationStructureModeKHR mode;
}