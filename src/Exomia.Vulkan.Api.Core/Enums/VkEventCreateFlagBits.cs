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
///     VkEventCreateFlagBits - Event creation flag bits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkEventCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkEventCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkEventCreateFlagBits
{
    /// <summary>VK_EVENT_CREATE_DEVICE_ONLY_BIT specifies that host event commands will not be used with this event.</summary>
    VK_EVENT_CREATE_DEVICE_ONLY_BIT = 0,

    /// <summary>VK_EVENT_CREATE_DEVICE_ONLY_BIT specifies that host event commands will not be used with this event.</summary>
    VK_EVENT_CREATE_DEVICE_ONLY_BIT_KHR = VK_EVENT_CREATE_DEVICE_ONLY_BIT
}