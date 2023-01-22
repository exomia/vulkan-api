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
///     VkBufferCreateFlagBits - Bitmask specifying additional parameters of a buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkBufferCreateFlagBits
{
    /// <summary>VK_BUFFER_CREATE_SPARSE_BINDING_BIT specifies that the buffer will be backed using sparse memory binding.</summary>
    VK_BUFFER_CREATE_SPARSE_BINDING_BIT = 0x1,

    /// <summary>
    ///     VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT specifies that the buffer can be partially backed using sparse memory
    ///     binding. Buffers created with this flag must also be created with the VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
    /// </summary>
    VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x2,

    /// <summary>
    ///     VK_BUFFER_CREATE_SPARSE_ALIASED_BIT specifies that the buffer will be backed using sparse memory binding with
    ///     memory ranges that might also simultaneously be backing another buffer (or another portion of the same buffer).
    ///     Buffers created with this flag must also be created with the VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
    /// </summary>
    VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x4,

    /// <summary>VK_BUFFER_CREATE_PROTECTED_BIT specifies that the buffer is a protected buffer.</summary>
    VK_BUFFER_CREATE_PROTECTED_BIT = 0x8,

    /// <summary>
    ///     VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT specifies that the buffer&#8217;s address can be saved and
    ///     reused on a subsequent run (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">
    ///         VkBufferOpaqueCaptureAddressCreateInfo
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = 0x10,

    /// <summary>
    ///     VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXTspecifies that the buffer can be used with descriptor
    ///     buffers when capturing and replaying (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">
    ///         VkOpaqueCaptureDescriptorDataCreateInfoEXT
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT specifies that the buffer&#8217;s address can be saved and
    ///     reused on a subsequent run (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">
    ///         VkBufferOpaqueCaptureAddressCreateInfo
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,

    /// <summary>
    ///     VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT specifies that the buffer&#8217;s address can be saved and
    ///     reused on a subsequent run (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">
    ///         VkBufferOpaqueCaptureAddressCreateInfo
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT
}