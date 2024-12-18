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
///     VkBuildAccelerationStructureFlagBitsKHR - Bitmask specifying additional parameters for acceleration structure
///     builds -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkBuildAccelerationStructureFlagBitsKHR
{
    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR specifies     that the specified acceleration structure can be
    ///     updated with     a mode of VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildGeometryInfoKHR.html">
    ///         VkAccelerationStructureBuildGeometryInfoKHR
    ///     </a>
    ///     or     an update of VK_TRUE in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html">
    ///         vkCmdBuildAccelerationStructureNV
    ///     </a>
    ///     .
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR specifies that the specified acceleration structure
    ///     can act as the source for a copy acceleration structure command with mode of
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR to produce a compacted acceleration structure.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHRspecifies that the given acceleration structure build
    ///     should prioritize trace performance over build time.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHRspecifies that the given acceleration structure build
    ///     should prioritize build time over trace performance.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR specifies that this acceleration structure should minimize
    ///     the size of the scratch memory and the final result acceleration structure, potentially at the expense of build
    ///     time or trace performance.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBuildAccelerationStructureFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBuildAccelerationStructureFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV = 0x20,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXTspecifies that the opacity micromaps
    ///     associated with the specified acceleration structure may change with an acceleration structure update.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT = 0x40,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXTspecifies that the specified acceleration
    ///     structure may be referenced in an instance with VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT set.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT = 0x80,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXTspecifies that the data of the opacity
    ///     micromaps associated with the specified acceleration structure may change with an acceleration structure update.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT = 0x100,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NVspecifies that the displacement micromaps
    ///     associated with the specified acceleration structure may change with an acceleration structure update.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV = 0x200,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR specifies that the specified acceleration structure can
    ///     be used when fetching the vertex positions of a hit triangle.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR = 0x800,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR specifies     that the specified acceleration structure can be
    ///     updated with     a mode of VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildGeometryInfoKHR.html">
    ///         VkAccelerationStructureBuildGeometryInfoKHR
    ///     </a>
    ///     or     an update of VK_TRUE in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html">
    ///         vkCmdBuildAccelerationStructureNV
    ///     </a>
    ///     .
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR specifies that the specified acceleration structure
    ///     can act as the source for a copy acceleration structure command with mode of
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR to produce a compacted acceleration structure.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHRspecifies that the given acceleration structure build
    ///     should prioritize trace performance over build time.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHRspecifies that the given acceleration structure build
    ///     should prioritize build time over trace performance.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR specifies that this acceleration structure should minimize
    ///     the size of the scratch memory and the final result acceleration structure, potentially at the expense of build
    ///     time or trace performance.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR
}