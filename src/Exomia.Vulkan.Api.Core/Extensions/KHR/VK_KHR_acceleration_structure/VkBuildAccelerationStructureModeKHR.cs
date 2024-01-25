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
///     VkBuildAccelerationStructureModeKHR - Enum specifying the type of build operation to perform -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureModeKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureModeKHR.html
///     </a>
/// </summary>
public enum VkBuildAccelerationStructureModeKHR
{
    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR specifies that the destination acceleration structure will be
    ///     built using the specified geometries.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR = 0,

    /// <summary>
    ///     VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR specifies that the destination acceleration structure will be
    ///     built using data in a source acceleration structure, updated by the specified geometries.
    /// </summary>
    VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR = 1
}