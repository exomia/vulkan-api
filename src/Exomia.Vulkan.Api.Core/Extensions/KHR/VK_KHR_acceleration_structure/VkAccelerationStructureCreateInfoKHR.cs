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
///     VkAccelerationStructureCreateInfoKHR - Structure specifying the parameters of a newly created acceleration
///     structure object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     createFlags is a bitmask of VkAccelerationStructureCreateFlagBitsKHR specifying additional creation parameters
    ///     of the acceleration structure.
    /// </summary>
    public VkAccelerationStructureCreateFlagsKHR createFlags;

    /// <summary>buffer is the buffer on which the acceleration structure will be stored.</summary>
    public VkBuffer buffer;

    /// <summary>
    ///     offset is an offset in bytes from the base address of the buffer at which the acceleration structure will be
    ///     stored, and must be a multiple of 256.
    /// </summary>
    public VkDeviceSize offset;

    /// <summary>size is the size required for the acceleration structure.</summary>
    public VkDeviceSize size;

    /// <summary>
    ///     type is a VkAccelerationStructureTypeKHR value specifying the type of acceleration structure that will be
    ///     created.
    /// </summary>
    public VkAccelerationStructureTypeKHR type;

    /// <summary>
    ///     deviceAddress is the device address requested for the acceleration structure if the
    ///     accelerationStructureCaptureReplay feature is being used.
    /// </summary>
    public VkDeviceAddress deviceAddress;
}