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
///     VkPipelineColorBlendStateCreateFlagBits - Bitmask specifying additional parameters of an image -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkPipelineColorBlendStateCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXTspecifies that access to
    ///     color and input attachments will have implicit framebuffer-local memory dependencies, allowing applications to
    ///     express custom blending operations in a fragment shader.
    /// </summary>
    VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXTspecifies that access to
    ///     color and input attachments will have implicit framebuffer-local memory dependencies, allowing applications to
    ///     express custom blending operations in a fragment shader.
    /// </summary>
    VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_ARM = VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT
}