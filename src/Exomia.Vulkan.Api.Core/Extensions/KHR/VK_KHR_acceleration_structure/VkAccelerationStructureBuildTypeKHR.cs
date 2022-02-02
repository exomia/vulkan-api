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
///     VkAccelerationStructureBuildTypeKHR - Acceleration structure build type -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildTypeKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildTypeKHR.html
///     </a>
/// </summary>
public enum VkAccelerationStructureBuildTypeKHR
{
    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR requests the memory requirement for operations performed by the
    ///     host.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = 0,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR requests the memory requirement for operations performed by
    ///     the device.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = 1,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR requests the memory requirement for operations
    ///     performed by either the host, or the device.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = 2
}