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
///     VkAccelerationStructureInfoNV - Structure specifying the parameters of acceleration structure object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     type is a VkAccelerationStructureTypeNV value specifying the type of acceleration structure that will be
    ///     created.
    /// </summary>
    public VkAccelerationStructureTypeNV type;

    /// <summary>
    ///     flags is a bitmask of VkBuildAccelerationStructureFlagBitsNVspecifying additional parameters of the
    ///     acceleration structure.
    /// </summary>
    public VkBuildAccelerationStructureFlagsNV flags;

    /// <summary>instanceCount specifies the number of instances that will be in the new acceleration structure.</summary>
    public uint instanceCount;

    /// <summary>geometryCount specifies the number of geometries that will be in the new acceleration structure.</summary>
    public uint geometryCount;

    /// <summary>
    ///     pGeometries is a pointer to an array of geometryCountVkGeometryNV structures containing the scene data being
    ///     passed into the acceleration structure.
    /// </summary>
    public VkGeometryNV* pGeometries;
}