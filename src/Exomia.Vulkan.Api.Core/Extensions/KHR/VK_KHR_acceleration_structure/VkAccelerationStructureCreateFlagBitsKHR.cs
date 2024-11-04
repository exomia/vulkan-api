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
    ///     VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXTspecifies that the acceleration structure
    ///     can be used with descriptor buffers when capturing and replaying (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">
    ///         VkOpaqueCaptureDescriptorDataCreateInfoEXT
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV specifies that the acceleration structure will be used with motion
    ///     information, see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInfoNV.html">
    ///         VkAccelerationStructureMotionInfoNV
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV = 0x4
}