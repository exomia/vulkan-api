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
///     VkAccelerationStructureCreateFlagBitsKHR - Bitmask specifying additional creation parameters for acceleration
///     structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkAccelerationStructureCreateFlagBitsKHR
{
    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHRspecifies that the acceleration
    ///     structure&#8217;s address can be saved and reused on a subsequent run.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_CREATE_RESERVED_3_BIT_AMD<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccelerationStructureCreateFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccelerationStructureCreateFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_ACCELERATION_STRUCTURE_CREATE_RESERVED_3_BIT_AMD = 0x8,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccelerationStructureCreateFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkAccelerationStructureCreateFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV = 0x4
}