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
///     VkImageCreateFlagBits - Bitmask specifying additional parameters of an image -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkImageCreateFlagBits
{
    /// <summary>VK_IMAGE_CREATE_SPARSE_BINDING_BIT specifies that the image will be backed using sparse memory binding.</summary>
    VK_IMAGE_CREATE_SPARSE_BINDING_BIT = 0x1,

    /// <summary>
    ///     VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT specifies that the image canbe partially backed using sparse memory
    ///     binding. Images created with this flag must also be created with the VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag.
    /// </summary>
    VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x2,

    /// <summary>
    ///     VK_IMAGE_CREATE_SPARSE_ALIASED_BIT specifies that the image will be backed using sparse memory binding with
    ///     memory ranges that might also simultaneously be backing another image (or another portion of the same image).
    ///     Images created with this flag must also be created with the VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag.
    /// </summary>
    VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x4,

    /// <summary>
    ///     VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT specifies that the image canbe used to create a VkImageView with a different
    ///     format from the image. For
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-requiring-sampler-ycbcr-conversion">
    ///         multi-planar
    ///     </a>
    ///     formats, VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT specifies that a VkImageView can be created of a plane of the image.
    /// </summary>
    VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x8,

    /// <summary>
    ///     VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT specifies that the image canbe used to create a VkImageView of type
    ///     VK_IMAGE_VIEW_TYPE_CUBE or VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.
    /// </summary>
    VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x10,

    /// <summary>
    ///     VK_IMAGE_CREATE_ALIAS_BIT specifies that two images created with     the same creation parameters and aliased to
    ///     the same memory can    interpret the contents of the memory consistently with each other,     subject to the rules
    ///     described in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#resources-memory-aliasing">
    ///         Memory
    ///         Aliasing
    ///     </a>
    ///     section.     This flag further specifies that each plane of a disjoint image can    share an
    ///     in-memory non-linear representation with single-plane images,     and that a single-plane image can share an
    ///     in-memory non-linear     representation with a plane of a multi-planar disjoint image, according     to the rules
    ///     in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-compatible-planes">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-compatible-planes
    ///     </a>
    ///     .     If the pNext chain includes a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfo.html">
    ///         VkExternalMemoryImageCreateInfo
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfoNV.html">
    ///         VkExternalMemoryImageCreateInfoNV
    ///     </a>
    ///     structure whose handleTypes member is not 0, it is as if     VK_IMAGE_CREATE_ALIAS_BIT is set.
    /// </summary>
    VK_IMAGE_CREATE_ALIAS_BIT = 0x400,

    /// <summary>
    ///     VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT specifies that the image can be used with a non-zero value of
    ///     the splitInstanceBindRegionCount member of a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryDeviceGroupInfo.html">
    ///         VkBindImageMemoryDeviceGroupInfo
    ///     </a>
    ///     structure passed into
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html">vkBindImageMemory2</a>
    ///     . This flag also has the effect of making the image use the standard sparse image block dimensions.
    /// </summary>
    VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT = 0x40,

    /// <summary>
    ///     VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT specifies that the image can be used to create a VkImageView of type
    ///     VK_IMAGE_VIEW_TYPE_2D or VK_IMAGE_VIEW_TYPE_2D_ARRAY.
    /// </summary>
    VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT = 0x20,

    /// <summary>
    ///     VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT specifies that the image having a compressed format can be
    ///     used to create a VkImageView with an uncompressed format where each texel in the image view corresponds to a
    ///     compressed texel block of the image.
    /// </summary>
    VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT = 0x80,

    /// <summary>
    ///     VK_IMAGE_CREATE_EXTENDED_USAGE_BIT specifies that the image canbe created with usage flags that are not
    ///     supported for the format the image is created with but are supported for at least one format a VkImageView created
    ///     from the image can have.
    /// </summary>
    VK_IMAGE_CREATE_EXTENDED_USAGE_BIT = 0x100,

    /// <summary>VK_IMAGE_CREATE_PROTECTED_BIT specifies that the image is a protected image.</summary>
    VK_IMAGE_CREATE_PROTECTED_BIT = 0x800,

    /// <summary>
    ///     VK_IMAGE_CREATE_DISJOINT_BIT specifies that an image with a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-requiring-sampler-ycbcr-conversion">
    ///         multi-planar
    ///         format
    ///     </a>
    ///     musthave each plane separately bound to memory, rather than having a single memory binding for the
    ///     whole image; the presence of this bit distinguishes a disjoint image from an image without this bit set.
    /// </summary>
    VK_IMAGE_CREATE_DISJOINT_BIT = 0x200,

    /// <summary>
    ///     VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV specifies that the image is a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#resources-images-corner-sampled">
    ///         corner-sampled
    ///         image
    ///     </a>
    ///     .
    /// </summary>
    VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = 0x2000,

    /// <summary>
    ///     VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXTspecifies that an image with a depth or depth/stencil
    ///     format can be used with custom sample locations when used as a depth/stencil attachment.
    /// </summary>
    VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT specifies that an image can be in a subsampled format which may be more optimal
    ///     when written as an attachment by a render pass that has a fragment density map attachment. Accessing a subsampled
    ///     image has additional considerations:<br />
    ///     Image data read as an image sampler will have undefined values if the sampler was not created with flags containing
    ///     VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT or was not sampled through the use of a combined image sampler with an
    ///     immutable sampler in VkDescriptorSetLayoutBinding.<br />
    ///     Image data read with an input attachment will have undefined values if the contents were not written as an
    ///     attachment in an earlier subpass of the same render pass.<br />
    ///     Image data read as an image sampler in the fragment shader will be additionally be read by the device during
    ///     VK_PIPELINE_STAGE_VERTEX_SHADER_BIT if
    ///     VkPhysicalDeviceFragmentDensityMap2PropertiesEXT::subsampledCoarseReconstructionEarlyAccessis VK_TRUE and the
    ///     sampler was created with flagscontaining VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT.<br />
    ///     Image data read with load operations are resampled to the fragment density of the render pass if
    ///     VkPhysicalDeviceFragmentDensityMap2PropertiesEXT::subsampledLoadsis VK_TRUE. Otherwise, values of image data are
    ///     undefined.<br />
    ///     Image contents outside of the render area take on undefined values if the image is stored as a render pass
    ///     attachment.<br />
    /// </summary>
    VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = 0x4000,

    /// <summary>
    ///     VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT specifies that the image can be used with descriptor
    ///     buffers when capturing and replaying (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">
    ///         VkOpaqueCaptureDescriptorDataCreateInfoEXT
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x10000,

    /// <summary>
    ///     VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXTspecifies that an image can be used with
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#multisampled-render-to-single-sampled">
    ///         multisampled
    ///         rendering as a single-sampled framebuffer attachment
    ///     </a>
    /// </summary>
    VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT = 0x40000,

    /// <summary>
    ///     VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT specifies that the image can be used to create a VkImageView of
    ///     type VK_IMAGE_VIEW_TYPE_2D.
    /// </summary>
    VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT = 0x20000,

    /// <summary>
    ///     VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM specifies that an image can be used in a render pass with
    ///     non-zero
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-fragmentdensitymapoffsets">
    ///         fragment
    ///         density map offsets
    ///     </a>
    ///     . In a render pass with non-zero offsets, fragment density map attachments, input
    ///     attachments, color attachments, depth/stencil attachment, resolve attachments, and preserve attachments must be
    ///     created with VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM.
    /// </summary>
    VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM = 0x8000,

    /// <summary>
    ///     VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR specifies that the image can be used in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-coding">
    ///         video coding
    ///         operations
    ///     </a>
    ///     without having to specify at image creation time the set of video profiles the image will be used
    ///     with, except for images used only as
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#dpb">DPB</a> pictures, as long
    ///     as the image is otherwise
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-profile-compatibility">compatible</a>
    ///     with the video profile in question.
    /// </summary>
    VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR = 0x100000,

    /// <summary>
    ///     VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT specifies that the image can be used with a non-zero value of
    ///     the splitInstanceBindRegionCount member of a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryDeviceGroupInfo.html">
    ///         VkBindImageMemoryDeviceGroupInfo
    ///     </a>
    ///     structure passed into
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html">vkBindImageMemory2</a>
    ///     . This flag also has the effect of making the image use the standard sparse image block dimensions.
    /// </summary>
    VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT,

    /// <summary>
    ///     VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT specifies that the image can be used to create a VkImageView of type
    ///     VK_IMAGE_VIEW_TYPE_2D or VK_IMAGE_VIEW_TYPE_2D_ARRAY.
    /// </summary>
    VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT,

    /// <summary>
    ///     VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT specifies that the image having a compressed format can be
    ///     used to create a VkImageView with an uncompressed format where each texel in the image view corresponds to a
    ///     compressed texel block of the image.
    /// </summary>
    VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,

    /// <summary>
    ///     VK_IMAGE_CREATE_EXTENDED_USAGE_BIT specifies that the image canbe created with usage flags that are not
    ///     supported for the format the image is created with but are supported for at least one format a VkImageView created
    ///     from the image can have.
    /// </summary>
    VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR = VK_IMAGE_CREATE_EXTENDED_USAGE_BIT,

    /// <summary>
    ///     VK_IMAGE_CREATE_DISJOINT_BIT specifies that an image with a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-requiring-sampler-ycbcr-conversion">
    ///         multi-planar
    ///         format
    ///     </a>
    ///     musthave each plane separately bound to memory, rather than having a single memory binding for the
    ///     whole image; the presence of this bit distinguishes a disjoint image from an image without this bit set.
    /// </summary>
    VK_IMAGE_CREATE_DISJOINT_BIT_KHR = VK_IMAGE_CREATE_DISJOINT_BIT,

    /// <summary>
    ///     VK_IMAGE_CREATE_ALIAS_BIT specifies that two images created with     the same creation parameters and aliased to
    ///     the same memory can    interpret the contents of the memory consistently with each other,     subject to the rules
    ///     described in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#resources-memory-aliasing">
    ///         Memory
    ///         Aliasing
    ///     </a>
    ///     section.     This flag further specifies that each plane of a disjoint image can    share an
    ///     in-memory non-linear representation with single-plane images,     and that a single-plane image can share an
    ///     in-memory non-linear     representation with a plane of a multi-planar disjoint image, according     to the rules
    ///     in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-compatible-planes">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-compatible-planes
    ///     </a>
    ///     .     If the pNext chain includes a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfo.html">
    ///         VkExternalMemoryImageCreateInfo
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfoNV.html">
    ///         VkExternalMemoryImageCreateInfoNV
    ///     </a>
    ///     structure whose handleTypes member is not 0, it is as if     VK_IMAGE_CREATE_ALIAS_BIT is set.
    /// </summary>
    VK_IMAGE_CREATE_ALIAS_BIT_KHR = VK_IMAGE_CREATE_ALIAS_BIT
}