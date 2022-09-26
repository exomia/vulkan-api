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
///     VkDeviceQueueCreateFlagBits - Bitmask specifying behavior of the queue -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateFlagBits.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateFlagBits.html </a>
/// </summary>
[Flags]
public enum VkDeviceQueueCreateFlagBits
{
    /// <summary> VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT specifies that the device queue is a protected-capable queue. </summary>
    VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = 0x1,

    /// <summary>
    ///     VK_DEVICE_QUEUE_CREATE_RESERVED_1_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDeviceQueueCreateFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDeviceQueueCreateFlagBits </a>
    /// </summary>
    VK_DEVICE_QUEUE_CREATE_RESERVED_1_BIT_QCOM = 0x2
}