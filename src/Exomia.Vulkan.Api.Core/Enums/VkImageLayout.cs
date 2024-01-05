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
///     VkImageLayout - Layout of image and image subresources -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageLayout.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageLayout.html</a>
/// </summary>
public enum VkImageLayout
{
    /// <summary>
    ///     VK_IMAGE_LAYOUT_UNDEFINED specifies that the layout is unknown. Image memory cannot be transitioned into this
    ///     layout. This layout can be used as the initialLayout member of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateInfo.html">VkImageCreateInfo</a>
    ///     . This layout can be used in place of the current image layout in a layout transition, but doing so will cause the
    ///     contents of the image&#8217;s memory to be undefined.
    /// </summary>
    VK_IMAGE_LAYOUT_UNDEFINED = 0,

    /// <summary>VK_IMAGE_LAYOUT_GENERAL supports all types of device access.</summary>
    VK_IMAGE_LAYOUT_GENERAL = 1,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL must only be used as a color or resolve attachment in a
    ///     VkFramebuffer. This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL specifies a layout for both the depth and stencil aspects of
    ///     a depth/stencil format image allowing read and write access as a depth/stencil attachment. It is equivalent to
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL and VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL specifies a layout for both the depth and stencil aspects of a
    ///     depth/stencil format image allowing read only access as a depth/stencil attachment or in shaders as a sampled
    ///     image, combined image/sampler, or input attachment. It is equivalent to VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL and
    ///     VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL specifies a layout allowing read-only access in a shader as a sampled
    ///     image, combined image/sampler, or input attachment. This layout is valid only for image subresources of images
    ///     created with the VK_IMAGE_USAGE_SAMPLED_BIT or VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bits enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL must only be used as a source image of a transfer command (see the definition
    ///     of
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-pipeline-stages-transfer">
    ///         <code>VK_PIPELINE_STAGE_TRANSFER_BIT</code>
    ///     </a>
    ///     ). This layout is valid only for image subresources of images created with the VK_IMAGE_USAGE_TRANSFER_SRC_BIT
    ///     usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = 6,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL must only be used as a destination image of a transfer command. This
    ///     layout is valid only for image subresources of images created with the VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit
    ///     enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = 7,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_PREINITIALIZED specifies that an image&#8217;s memory is in a defined layout and can be
    ///     populated by data, but that it has not yet been initialized by the driver. Image memory cannot be transitioned into
    ///     this layout. This layout can be used as the initialLayout member of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateInfo.html">VkImageCreateInfo</a>
    ///     . This layout is intended to be used as the initial layout for an image whose contents are written by the host, and
    ///     hence the data can be written to memory immediately, without first executing a layout transition. Currently,
    ///     VK_IMAGE_LAYOUT_PREINITIALIZED is only useful with
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#glossary-linear-resource">linear</a>
    ///     images because there is not a standard layout defined for VK_IMAGE_TILING_OPTIMAL images.
    /// </summary>
    VK_IMAGE_LAYOUT_PREINITIALIZED = 8,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMALspecifies a layout for depth/stencil format images
    ///     allowing read and write access to the stencil aspect as a stencil attachment, and read only access to the depth
    ///     aspect as a depth attachment or in shaders as a sampled image, combined image/sampler, or input attachment. It is
    ///     equivalent to VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL and VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = 1000117000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMALspecifies a layout for depth/stencil format images
    ///     allowing read and write access to the depth aspect as a depth attachment, and read only access to the stencil
    ///     aspect as a stencil attachment or in shaders as a sampled image, combined image/sampler, or input attachment. It is
    ///     equivalent to VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL and VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = 1000117001,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL specifies a layout for the depth aspect of a depth/stencil format
    ///     image allowing read and write access as a depth attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = 1000241000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL specifies a layout for the depth aspect of a depth/stencil format
    ///     image allowing read-only access as a depth attachment or in shaders as a sampled image, combined image/sampler, or
    ///     input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = 1000241001,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL specifies a layout for the stencil aspect of a depth/stencil format
    ///     image allowing read and write access as a stencil attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = 1000241002,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL specifies a layout for the stencil aspect of a depth/stencil format
    ///     image allowing read-only access as a stencil attachment or in shaders as a sampled image, combined image/sampler,
    ///     or input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = 1000241003,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL specifies a layout allowing read only access as an attachment, or in shaders
    ///     as a sampled image, combined image/sampler, or input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = 1000314000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL specifies a layout that mustonly be used with attachment accesses in the
    ///     graphics pipeline.
    /// </summary>
    VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = 1000314001,

    /// <summary>VK_IMAGE_LAYOUT_PRESENT_SRC_KHR must only be used for presenting a presentable image for display.</summary>
    VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = 1000001002,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR must only be used as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#decode-output-picture">
    ///         decode
    ///         output picture
    ///     </a>
    ///     in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     . This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = 1000024000,

    /// <summary>VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR is reserved for future use.</summary>
    VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = 1000024001,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR must only be used as an output
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reconstructed-picture">
    ///         reconstructed
    ///         picture
    ///     </a>
    ///     or an input
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operation
    ///     </a>
    ///     . This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = 1000024002,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR is valid only for shared presentable images, and must be used for any usage
    ///     the image supports.
    /// </summary>
    VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = 1000111000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT must only be used as a fragment density map attachment in a
    ///     VkRenderPass. This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = 1000218000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR must    only be used as a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    ///     .     This layout is valid only for image subresources of images created with     the
    ///     VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR usage     bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = 1000164003,

    /// <summary>VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR is reserved for future use.</summary>
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = 1000299000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR must only be used as an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-input-picture">
    ///         encode
    ///         input picture
    ///     </a>
    ///     in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     . This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = 1000299001,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR must only be used as an output
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reconstructed-picture">
    ///         reconstructed
    ///         picture
    ///     </a>
    ///     or an input
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     in a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operation
    ///     </a>
    ///     . This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR usage bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = 1000299002,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT must only be used as either a color attachment or
    ///     depth/stencil attachment in a VkFramebuffer and/or read-only access in a shader as a sampled image, combined
    ///     image/sampler, or input attachment. This layout is valid only for image subresources of images created with the
    ///     VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT usage bit enabled and either the
    ///     VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT or VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT and either the
    ///     VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT or VK_IMAGE_USAGE_SAMPLED_BIT usage bits enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = 1000339000,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMALspecifies a layout for depth/stencil format images
    ///     allowing read and write access to the stencil aspect as a stencil attachment, and read only access to the depth
    ///     aspect as a depth attachment or in shaders as a sampled image, combined image/sampler, or input attachment. It is
    ///     equivalent to VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL and VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMALspecifies a layout for depth/stencil format images
    ///     allowing read and write access to the depth aspect as a depth attachment, and read only access to the stencil
    ///     aspect as a stencil attachment or in shaders as a sampled image, combined image/sampler, or input attachment. It is
    ///     equivalent to VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL and VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR must    only be used as a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    ///     .     This layout is valid only for image subresources of images created with     the
    ///     VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR usage     bit enabled.
    /// </summary>
    VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL specifies a layout for the depth aspect of a depth/stencil format
    ///     image allowing read and write access as a depth attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL specifies a layout for the depth aspect of a depth/stencil format
    ///     image allowing read-only access as a depth attachment or in shaders as a sampled image, combined image/sampler, or
    ///     input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL specifies a layout for the stencil aspect of a depth/stencil format
    ///     image allowing read and write access as a stencil attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL specifies a layout for the stencil aspect of a depth/stencil format
    ///     image allowing read-only access as a stencil attachment or in shaders as a sampled image, combined image/sampler,
    ///     or input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL specifies a layout allowing read only access as an attachment, or in shaders
    ///     as a sampled image, combined image/sampler, or input attachment.
    /// </summary>
    VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL,

    /// <summary>
    ///     VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL specifies a layout that mustonly be used with attachment accesses in the
    ///     graphics pipeline.
    /// </summary>
    VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL
}