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
///     VkDeviceGroupPresentModeFlagBitsKHR - Bitmask specifying supported device group present modes -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentModeFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentModeFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkDeviceGroupPresentModeFlagBitsKHR
{
    /// <summary>
    ///     VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR specifies that any physical device with a presentation engine can
    ///     present its own swapchain images.
    /// </summary>
    VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR specifies that any physical device with a presentation engine can
    ///     present swapchain images from any physical device in its presentMask.
    /// </summary>
    VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR specifies that any physical device with a presentation engine can
    ///     present the sum of swapchain images from any physical devices in its presentMask.
    /// </summary>
    VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR specifies that multiple physical devices with a
    ///     presentation engine can each present their own swapchain images.
    /// </summary>
    VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = 0x8
}