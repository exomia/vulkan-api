#region License

// Copyright (c) 2018-2023, exomia
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
///     VkDeviceAddressBindingTypeEXT - Enum describing a change in device address bindings -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingTypeEXT.html</a>
/// </summary>
public enum VkDeviceAddressBindingTypeEXT
{
    /// <summary>
    ///     VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT specifies that a new GPU-accessible virtual address range has been
    ///     bound.
    /// </summary>
    VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT = 0,

    /// <summary>
    ///     VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT specifies that a GPU-accessible virtual address range has been
    ///     unbound.
    /// </summary>
    VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT = 1
}