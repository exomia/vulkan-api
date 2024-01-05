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
///     VkDeviceFaultAddressTypeEXT - Page fault access types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressTypeEXT.html</a>
/// </summary>
public enum VkDeviceFaultAddressTypeEXT
{
    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoEXT.html">VkDeviceFaultAddressInfoEXT</a>
    ///     does not describe a page fault, or an instruction address.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT = 0,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoEXT.html">VkDeviceFaultAddressInfoEXT</a>
    ///     describes a page fault triggered by an invalid read operation.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT = 1,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoEXT.html">VkDeviceFaultAddressInfoEXT</a>
    ///     describes a page fault triggered by an invalid write operation.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT = 2,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT describes a page fault triggered by an attempt to execute
    ///     non-executable memory.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT = 3,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXTspecifies an instruction pointer value at the time
    ///     the fault occurred. This may or may not be related to a fault.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT = 4,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXTspecifies an instruction pointer value associated
    ///     with an invalid instruction fault.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT = 5,

    /// <summary>
    ///     VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXTspecifies an instruction pointer value associated
    ///     with a fault.
    /// </summary>
    VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT = 6
}