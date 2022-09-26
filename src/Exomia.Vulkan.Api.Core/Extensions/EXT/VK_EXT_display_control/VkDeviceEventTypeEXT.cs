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
///     VkDeviceEventTypeEXT - Events that can occur on a device object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceEventTypeEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceEventTypeEXT.html </a>
/// </summary>
public enum VkDeviceEventTypeEXT
{
    /// <summary> VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT specifies that the fence is signaled when a display is plugged into or unplugged from the specified device. Applications can use this notification to determine when they need to re-enumerate the available displays on a device. </summary>
    VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT = 0
}