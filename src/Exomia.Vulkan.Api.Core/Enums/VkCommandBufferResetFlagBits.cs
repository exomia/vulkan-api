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
///     VkCommandBufferResetFlagBits - Bitmask controlling behavior of a command buffer reset -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferResetFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferResetFlagBits.html</a>
/// </summary>
[Flags]
public enum VkCommandBufferResetFlagBits
{
    /// <summary>
    ///     VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT specifies that most or all memory resources currently owned by the
    ///     command buffer should be returned to the parent command pool. If this flag is not set, then the command buffer may
    ///     hold onto memory resources and reuse them when recording commands. commandBuffer is moved to the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#commandbuffers-lifecycle">
    ///         initial
    ///         state
    ///     </a>
    ///     .
    /// </summary>
    VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = 0
}