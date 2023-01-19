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
///     VkSubpassContents - Specify how commands in the first subpass of a render pass are provided -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassContents.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassContents.html</a>
/// </summary>
public enum VkSubpassContents
{
    /// <summary>
    ///     VK_SUBPASS_CONTENTS_INLINE specifies that the contents of the subpass will be recorded inline in the primary
    ///     command buffer, and secondary command buffers must not be executed within the subpass.
    /// </summary>
    VK_SUBPASS_CONTENTS_INLINE = 0,

    /// <summary>
    ///     VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS specifies that the contents are recorded in secondary command
    ///     buffers that will be called from the primary command buffer, and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html">vkCmdExecuteCommands</a>
    ///     is the only valid command on the command buffer until
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass.html">vkCmdNextSubpass</a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass.html">vkCmdEndRenderPass</a>
    ///     .
    /// </summary>
    VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = 1
}