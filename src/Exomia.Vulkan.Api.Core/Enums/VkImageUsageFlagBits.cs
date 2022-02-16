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
///     VkImageUsageFlagBits - Bitmask specifying intended usage of an image -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlagBits.html</a>
/// </summary>
[Flags]
public enum VkImageUsageFlagBits
{
    /// <summary>VK_IMAGE_USAGE_TRANSFER_SRC_BIT specifies that the image can be used as the source of a transfer command.</summary>
    VK_IMAGE_USAGE_TRANSFER_SRC_BIT = 0x1,

    /// <summary>VK_IMAGE_USAGE_TRANSFER_DST_BIT specifies that the image can be used as the destination of a transfer command.</summary>
    VK_IMAGE_USAGE_TRANSFER_DST_BIT = 0x2,

    /// <summary>
    ///     VK_IMAGE_USAGE_SAMPLED_BIT specifies that the image can be used to create a VkImageView suitable for occupying
    ///     a VkDescriptorSet slot either of type VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by a shader.
    /// </summary>
    VK_IMAGE_USAGE_SAMPLED_BIT = 0x4,

    /// <summary>
    ///     VK_IMAGE_USAGE_STORAGE_BIT specifies that the image can be used to create a VkImageView suitable for occupying
    ///     a VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_STORAGE_IMAGE.
    /// </summary>
    VK_IMAGE_USAGE_STORAGE_BIT = 0x8,

    /// <summary>
    ///     VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT specifies that the image canbe used to create a VkImageView suitable for
    ///     use as a color or resolve attachment in a VkFramebuffer.
    /// </summary>
    VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 0x10,

    /// <summary>
    ///     VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT specifies that the image can be used to create a VkImageView
    ///     suitable for use as a depth/stencil or depth/stencil resolve attachment in a VkFramebuffer.
    /// </summary>
    VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x20,

    /// <summary>
    ///     VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT specifies that implementations may support using
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#memory">memory allocations</a>
    ///     with the VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT to back an image with this usage. This bit can be set for any
    ///     image that can be used to create a VkImageView suitable for use as a color, resolve, depth/stencil, or input
    ///     attachment.
    /// </summary>
    VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 0x40,

    /// <summary>
    ///     VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT specifies that the image canbe used to create a VkImageView suitable for
    ///     occupying VkDescriptorSet slot of type VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as an input
    ///     attachment; and be used as an input attachment in a framebuffer.
    /// </summary>
    VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 0x80,

    /// <summary>
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    ///     can use the image as an output picture for video decode operations.
    /// </summary>
    VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR = 0x400,

    /// <summary>VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR is reserved for future use.</summary>
    VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR = 0x800,

    /// <summary>
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    ///     can use the image as a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-picture-resources">
    ///         DPB
    ///         Video Picture Resource
    ///     </a>
    ///     , representing a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     . If an implementation requires separate allocations for DPB and decode output, indicating this by
    ///     returning VK_ERROR_FORMAT_NOT_SUPPORTEDto any
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html">
    ///         vkGetPhysicalDeviceVideoFormatPropertiesKHR
    ///     </a>
    ///     call with both VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR and VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR usage bits, then
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR must not be combined with any other VK_IMAGE_USAGE_* flags. Otherwise,
    ///     VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR must be combined with VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR, if the DPB
    ///     image is required to coincide with the decoded output picture. In the case where DPB coincides with the decoded
    ///     output picture, image resources can be used as
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         pictures
    ///     </a>
    ///     only after acting as targets for video decode operations, where its image view must be set to both
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html">VkVideoDecodeInfoKHR</a>
    ///     ::pSetupReferenceSlot-&gt;pPictureResource-&gt;imageViewBindingand
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeInfoKHR.html">VkVideoDecodeInfoKHR</a>
    ///     ::dstPictureResource.imageViewBinding.
    /// </summary>
    VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR = 0x1000,

    /// <summary>
    ///     VK_IMAGE_USAGE_RESERVED_16_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_RESERVED_16_BIT_QCOM = 0x10000,

    /// <summary>
    ///     VK_IMAGE_USAGE_RESERVED_17_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_RESERVED_17_BIT_QCOM = 0x20000,

    /// <summary>
    ///     VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT specifies that the image can be used to create a VkImageView suitable
    ///     for use as a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#fragmentdensitymapops">
    ///         fragment
    ///         density map image
    ///     </a>
    ///     .
    /// </summary>
    VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR specifies     that the image can be used to create a
    ///     VkImageView suitable for     use as a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    /// </summary>
    VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x100,

    /// <summary>VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR is reserved for future use.</summary>
    VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR = 0x2000,

    /// <summary>
    ///     VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR specifies that the image can be used as an
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#input-encode-picture">
    ///         input
    ///         picture
    ///     </a>
    ///     for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR specifies that
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     can use the image as an output to hold a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-picture-resources">
    ///         reconstructed
    ///         picture
    ///     </a>
    ///     that can subsequently act as an input
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     .
    /// </summary>
    VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR = 0x8000,

    /// <summary>
    ///     VK_IMAGE_USAGE_RESERVED_19_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_RESERVED_19_BIT_EXT = 0x80000,

    /// <summary>
    ///     VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI = 0x40000,

    /// <summary>
    ///     VK_IMAGE_USAGE_RESERVED_20_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_RESERVED_20_BIT_QCOM = 0x100000,

    /// <summary>
    ///     VK_IMAGE_USAGE_RESERVED_21_BIT_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageUsageFlagBits</a>
    /// </summary>
    VK_IMAGE_USAGE_RESERVED_21_BIT_QCOM = 0x200000,

    /// <summary>
    ///     VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR specifies     that the image can be used to create a
    ///     VkImageView suitable for     use as a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate     attachment
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-shading-rate-image">
    ///         shading
    ///         rate image
    ///     </a>
    /// </summary>
    VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR
}