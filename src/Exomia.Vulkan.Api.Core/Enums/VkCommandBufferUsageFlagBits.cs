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
///     VkCommandBufferUsageFlagBits - Bitmask specifying usage behavior for command buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferUsageFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferUsageFlagBits.html</a>
/// </summary>
[Flags]
public enum VkCommandBufferUsageFlagBits
{
    /// <summary>
    ///     VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT specifies that each recording of the command buffer will only be
    ///     submitted once, and the command buffer will be reset and recorded again between each submission.
    /// </summary>
    VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = 0x1,

    /// <summary>
    ///     VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT specifies that a secondary command buffer is considered to be
    ///     entirely inside a render pass. If this is a primary command buffer, then this bit is ignored.
    /// </summary>
    VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = 0x2,

    /// <summary>
    ///     VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT specifies that a command buffer can be resubmitted to a queue
    ///     while it is in the pending state, and recorded into multiple primary command buffers.
    /// </summary>
    VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = 0x4
}