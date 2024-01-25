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
///     VkAccelerationStructureBuildGeometryInfoKHR - Structure specifying the geometry data used to build an acceleration
///     structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildGeometryInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildGeometryInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>type is a VkAccelerationStructureTypeKHR value specifying the type of acceleration structure being built.</summary>
    public VkAccelerationStructureTypeKHR type;

    /// <summary>
    ///     flags is a bitmask of VkBuildAccelerationStructureFlagBitsKHR specifying additional parameters of the
    ///     acceleration structure.
    /// </summary>
    public VkBuildAccelerationStructureFlagsKHR flags;

    /// <summary>mode is a VkBuildAccelerationStructureModeKHR value specifying the type of operation to perform.</summary>
    public VkBuildAccelerationStructureModeKHR mode;

    /// <summary>
    ///     srcAccelerationStructure is a pointer to an existing acceleration structure that is to be used to update the
    ///     dst acceleration structure when mode is VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR.
    /// </summary>
    public VkAccelerationStructureKHR srcAccelerationStructure;

    /// <summary>dstAccelerationStructure is a pointer to the target acceleration structure for the build.</summary>
    public VkAccelerationStructureKHR dstAccelerationStructure;

    /// <summary>geometryCount specifies the number of geometries that will be built into dstAccelerationStructure.</summary>
    public uint geometryCount;

    /// <summary>pGeometries is a pointer to an array of VkAccelerationStructureGeometryKHR structures.</summary>
    public VkAccelerationStructureGeometryKHR* pGeometries;

    /// <summary>ppGeometries is a pointer to an array of pointers to VkAccelerationStructureGeometryKHR structures.</summary>
    public VkAccelerationStructureGeometryKHR** ppGeometries;

    /// <summary>scratchData is the device or host address to memory that will be used as scratch memory for the build.</summary>
    public VkDeviceOrHostAddressKHR scratchData;
}