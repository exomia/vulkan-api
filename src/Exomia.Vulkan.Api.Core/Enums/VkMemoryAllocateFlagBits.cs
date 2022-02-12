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
///     VkMemoryAllocateFlagBits - Bitmask specifying flags for a device memory allocation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkMemoryAllocateFlagBits
{
    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT specifies that memory will be allocated for the devices in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagsInfo.html">VkMemoryAllocateFlagsInfo</a>
    ///     ::deviceMask.
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = 1 << 0,

    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT specifies that the memory can be attached to a buffer object created with the
    ///     VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT bit set in usage, and that the memory handle can be used to retrieve an
    ///     opaque address via
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html">
    ///         vkGetDeviceMemoryOpaqueCaptureAddress
    ///     </a>
    ///     .
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT = 1 << 1,

    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT specifies that the memory&#8217;s address can be saved and
    ///     reused on a subsequent run (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">
    ///         VkBufferOpaqueCaptureAddressCreateInfo
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = 1 << 2,

    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT specifies that memory will be allocated for the devices in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagsInfo.html">VkMemoryAllocateFlagsInfo</a>
    ///     ::deviceMask.
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT,

    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT specifies that the memory can be attached to a buffer object created with the
    ///     VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT bit set in usage, and that the memory handle can be used to retrieve an
    ///     opaque address via
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html">
    ///         vkGetDeviceMemoryOpaqueCaptureAddress
    ///     </a>
    ///     .
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT,

    /// <summary>
    ///     VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT specifies that the memory&#8217;s address can be saved and
    ///     reused on a subsequent run (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">
    ///         VkBufferOpaqueCaptureAddressCreateInfo
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT
}