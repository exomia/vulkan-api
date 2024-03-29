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
///     VkSubpassDescriptionFlagBits - Bitmask specifying usage of a subpass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSubpassDescriptionFlagBits
{
    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX specifies that shaders compiled for this subpass write the
    ///     attributes for all views in a single invocation of each
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#pipelines-graphics-subsets-pre-rasterization">
    ///         pre-rasterization
    ///         shader stage
    ///     </a>
    ///     . All pipelines compiled against a subpass that includes this bit mustwrite per-view attributes
    ///     to the *PerViewNV[] shader outputs, in addition to the non-per-view (e.g. Position) outputs.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = 0x1,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX specifies that shaders compiled for this subpass use
    ///     per-view positions which only differ in value in the x component. Per-view viewport mask can also be used.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = 0x2,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM specifies that the framebuffer region is the fragment region,
    ///     that is, the minimum region dependencies are by pixel rather than by sample, such that any fragment shader
    ///     invocation can access any sample associated with that fragment shader invocation.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM = 0x4,

    /// <summary>VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM specifies that the subpass performs shader resolve operations.</summary>
    VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM = 0x8,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXTspecifies that this subpass supports
    ///     pipelines created with VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXTspecifies that this subpass supports
    ///     pipelines created with VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXTspecifies that this subpass
    ///     supports pipelines created with
    ///     VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT specifies that
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#interfaces-legacy-dithering">
    ///         Legacy
    ///         Dithering
    ///     </a>
    ///     is enabled for this subpass.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXTspecifies that this subpass supports
    ///     pipelines created with VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXTspecifies that this subpass supports
    ///     pipelines created with VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT,

    /// <summary>
    ///     VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXTspecifies that this subpass
    ///     supports pipelines created with
    ///     VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT.
    /// </summary>
    VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM = VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT
}