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
///     VkCommandPoolCreateFlagBits - Bitmask specifying usage behavior for a command pool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandPoolCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandPoolCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkCommandPoolCreateFlagBits
{
    /// <summary>
    ///     VK_COMMAND_POOL_CREATE_TRANSIENT_BIT specifies that command buffers allocated from the pool will be
    ///     short-lived, meaning that they will be reset or freed in a relatively short timeframe. This flag may be used by the
    ///     implementation to control memory allocation behavior within the pool.
    /// </summary>
    VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = 0x1,

    /// <summary>
    ///     VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT allows any command buffer allocated from a pool to be individually
    ///     reset to the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#commandbuffers-lifecycle">
    ///         initial
    ///         state
    ///     </a>
    ///     ; either by calling
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html">vkResetCommandBuffer</a>
    ///     , or via the implicit reset when calling
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html">vkBeginCommandBuffer</a>
    ///     . If this flag is not set on a pool, then vkResetCommandBuffer mustnot be called for any command buffer allocated
    ///     from that pool.
    /// </summary>
    VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x2,

    /// <summary>
    ///     VK_COMMAND_POOL_CREATE_PROTECTED_BIT specifies that command buffers allocated from the pool are protected
    ///     command buffers.
    /// </summary>
    VK_COMMAND_POOL_CREATE_PROTECTED_BIT = 0x4
}