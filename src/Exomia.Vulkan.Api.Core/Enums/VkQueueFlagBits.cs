﻿#region License

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
///     VkQueueFlagBits - Bitmask specifying capabilities of queues in a queue family -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFlagBits.html</a>
/// </summary>
[Flags]
public enum VkQueueFlagBits
{
    /// <summary>VK_QUEUE_GRAPHICS_BIT specifies that queues in this queue family support graphics operations.</summary>
    VK_QUEUE_GRAPHICS_BIT = 0,

    /// <summary>VK_QUEUE_COMPUTE_BIT specifies that queues in this queue family support compute operations.</summary>
    VK_QUEUE_COMPUTE_BIT = 1,

    /// <summary>VK_QUEUE_TRANSFER_BIT specifies that queues in this queue family support transfer operations.</summary>
    VK_QUEUE_TRANSFER_BIT = 2,

    /// <summary>
    ///     VK_QUEUE_SPARSE_BINDING_BIT specifies that queues in this queue family support sparse memory management
    ///     operations (see
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#sparsememory">
    ///         Sparse
    ///         Resources
    ///     </a>
    ///     ). If any of the sparse resource features are enabled, then at least one queue family must support
    ///     this bit.
    /// </summary>
    VK_QUEUE_SPARSE_BINDING_BIT = 3,

    /// <summary>
    ///     VK_QUEUE_PROTECTED_BIT specifies that queues in this queue family support the VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT
    ///     bit. (see
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#memory-protected-memory">
    ///         Protected
    ///         Memory
    ///     </a>
    ///     ). If the physical device supports the protectedMemory feature, at least one of its queue families
    ///     must support this bit.
    /// </summary>
    VK_QUEUE_PROTECTED_BIT = 4,

    /// <summary>VK_QUEUE_VIDEO_DECODE_BIT_KHR specifies that queues in this queue family support Video Decode operations.</summary>
    VK_QUEUE_VIDEO_DECODE_BIT_KHR = 5,

    /// <summary>VK_QUEUE_VIDEO_ENCODE_BIT_KHR specifies that queues in this queue family support Video Encode operations.</summary>
    VK_QUEUE_VIDEO_ENCODE_BIT_KHR = 6,

    /// <summary>
    ///     VK_QUEUE_RESERVED_7_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkQueueFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkQueueFlagBits</a>
    /// </summary>
    VK_QUEUE_RESERVED_7_BIT_QCOM = 7
}