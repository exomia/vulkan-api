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
///     VkInstanceCreateFlagBits - Bitmask specifying behavior of the instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkInstanceCreateFlagBits
{
    /// <summary>
    ///     VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR specifies that the instance will enumerate available Vulkan
    ///     Portability-compliant physical devices and groups in addition to the Vulkan physical devices and groups that are
    ///     enumerated by default.
    /// </summary>
    VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = 0x1
}