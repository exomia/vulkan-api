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
///     VkPipelineDepthStencilStateCreateFlagBits - Bitmask specifying additional depth/stencil state information. -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkPipelineDepthStencilStateCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARMindicates that access to
    ///     the depth aspects of depth/stencil and input attachments will have implicit framebuffer-local memory dependencies.
    ///     See
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-feedbackloop">
    ///         renderpass
    ///         feedback loops
    ///     </a>
    ///     for more information.
    /// </summary>
    VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM = 0,

    /// <summary>
    ///     VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARMindicates that access
    ///     to the stencil aspects of depth/stencil and input attachments will have implicit framebuffer-local memory
    ///     dependencies. See
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-feedbackloop">
    ///         renderpass
    ///         feedback loops
    ///     </a>
    ///     for more information.
    /// </summary>
    VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM = 1
}