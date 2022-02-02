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
///     VkAccelerationStructureTypeKHR - Type of acceleration structure -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTypeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTypeKHR.html</a>
/// </summary>
public enum VkAccelerationStructureTypeKHR
{
    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR is a top-level acceleration structure containing instance data
    ///     referring to bottom-level acceleration structures.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR = 0,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR is a bottom-level acceleration structure containing the AABBs
    ///     or geometry to be intersected.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR = 1,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR is an acceleration structure whose type is determined at build time
    ///     used for special circumstances.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR = 2,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR is a top-level acceleration structure containing instance data
    ///     referring to bottom-level acceleration structures.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR is a bottom-level acceleration structure containing the AABBs
    ///     or geometry to be intersected.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV = VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR
}