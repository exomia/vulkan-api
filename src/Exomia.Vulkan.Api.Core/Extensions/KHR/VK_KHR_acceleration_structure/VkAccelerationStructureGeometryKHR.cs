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
///     VkAccelerationStructureGeometryKHR - Structure specifying geometries to be built into an acceleration
///     structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureGeometryKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>geometryType describes which type of geometry this VkAccelerationStructureGeometryKHR refers to.</summary>
    public VkGeometryTypeKHR geometryType;

    /// <summary>
    ///     geometry is a VkAccelerationStructureGeometryDataKHR union describing the geometry data for the relevant
    ///     geometry type.
    /// </summary>
    public VkAccelerationStructureGeometryDataKHR geometry;

    /// <summary>
    ///     flags is a bitmask of VkGeometryFlagBitsKHR values describing additional properties of how the geometry should
    ///     be built.
    /// </summary>
    public VkGeometryFlagsKHR flags;
}