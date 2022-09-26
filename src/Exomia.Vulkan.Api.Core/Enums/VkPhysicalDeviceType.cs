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
///     VkPhysicalDeviceType - Supported physical device types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceType.html </a>
/// </summary>
public enum VkPhysicalDeviceType
{
    /// <summary> VK_PHYSICAL_DEVICE_TYPE_OTHER - the device does not match any other available types. </summary>
    VK_PHYSICAL_DEVICE_TYPE_OTHER = 0,

    /// <summary> VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU - the device is typically one embedded in or tightly coupled with the host. </summary>
    VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = 1,

    /// <summary> VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU - the device is typically a separate processor connected to the host via an interlink. </summary>
    VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = 2,

    /// <summary> VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU - the device is typically a virtual node in a virtualization environment. </summary>
    VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = 3,

    /// <summary> VK_PHYSICAL_DEVICE_TYPE_CPU - the device is typically running on the same processors as the host. </summary>
    VK_PHYSICAL_DEVICE_TYPE_CPU = 4
}