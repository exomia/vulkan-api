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
///     VkRenderingFlagBits - Bitmask specifying additional properties of a dynamic render pass instance -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingFlagBits.html</a>
/// </summary>
[Flags]
public enum VkRenderingFlagBits
{
    /// <summary>
    ///     VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT specifies that draw calls for the render pass instance will be
    ///     recorded in secondary command buffers. If the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-nestedCommandBuffer">
    ///         <code>nestedCommandBuffer</code>
    ///     </a>
    ///     feature is enabled, the draw calls can come from both inline and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html">vkCmdExecuteCommands</a>
    ///     .
    /// </summary>
    VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = 0x1,

    /// <summary>VK_RENDERING_SUSPENDING_BIT specifies that the render pass instance will be suspended.</summary>
    VK_RENDERING_SUSPENDING_BIT = 0x2,

    /// <summary>
    ///     VK_RENDERING_RESUMING_BIT specifies that the render pass instance is resuming an earlier suspended render pass
    ///     instance.
    /// </summary>
    VK_RENDERING_RESUMING_BIT = 0x4,

    /// <summary>
    ///     VK_RENDERING_CONTENTS_INLINE_BIT_EXT specifies that draw calls for the render pass instance can be recorded inline
    ///     within the current command buffer. When the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-nestedCommandBuffer">
    ///         <code>nestedCommandBuffer</code>
    ///     </a>
    ///     feature is enabled this can be combined with the VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT bit to allow
    ///     draw calls to be recorded both inline and in secondary command buffers.
    /// </summary>
    VK_RENDERING_CONTENTS_INLINE_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT specifies that
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#interfaces-legacy-dithering">
    ///         Legacy
    ///         Dithering
    ///     </a>
    ///     is enabled for the render pass instance.
    /// </summary>
    VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT specifies that draw calls for the render pass instance will be
    ///     recorded in secondary command buffers. If the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#features-nestedCommandBuffer">
    ///         <code>nestedCommandBuffer</code>
    ///     </a>
    ///     feature is enabled, the draw calls can come from both inline and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html">vkCmdExecuteCommands</a>
    ///     .
    /// </summary>
    VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR = VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT,

    /// <summary>VK_RENDERING_SUSPENDING_BIT specifies that the render pass instance will be suspended.</summary>
    VK_RENDERING_SUSPENDING_BIT_KHR = VK_RENDERING_SUSPENDING_BIT,

    /// <summary>
    ///     VK_RENDERING_RESUMING_BIT specifies that the render pass instance is resuming an earlier suspended render pass
    ///     instance.
    /// </summary>
    VK_RENDERING_RESUMING_BIT_KHR = VK_RENDERING_RESUMING_BIT
}