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
///     VkDeviceAddressBindingFlagBitsEXT - Bitmask specifying the additional information about a binding event -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkDeviceAddressBindingFlagBitsEXT
{
    /// <summary>
    ///     VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT specifies that
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingCallbackDataEXT.html">
    ///         VkDeviceAddressBindingCallbackDataEXT
    ///     </a>
    ///     describes a Vulkan object that has not been made visible to the application via a Vulkan command.
    /// </summary>
    VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT = 0x1
}