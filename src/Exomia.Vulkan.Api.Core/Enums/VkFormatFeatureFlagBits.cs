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
///     VkFormatFeatureFlagBits - Bitmask specifying features supported by a buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits.html</a>
/// </summary>
[Flags]
public enum VkFormatFeatureFlagBits
{
    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT specifies that an image view can be
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage">
    ///         sampled
    ///         from
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 0x1,

    /// <summary>
    ///     VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT specifies that an image view can be used as a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 0x2,

    /// <summary>
    ///     VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT specifies that an image view can be used as storage image that
    ///     supports atomic operations.
    /// </summary>
    VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 0x4,

    /// <summary>
    ///     VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view that
    ///     can be bound to a VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 0x8,

    /// <summary>
    ///     VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view that
    ///     can be bound to a VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 0x10,

    /// <summary>
    ///     VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT specifies that atomic operations are supported on
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </summary>
    VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x20,

    /// <summary>
    ///     VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT specifies that the format canbe used as a vertex attribute format
    ///     (VkVertexInputAttributeDescription::format).
    /// </summary>
    VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 0x40,

    /// <summary>
    ///     VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 0x80,

    /// <summary>
    ///     VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment that supports blending and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 0x100,

    /// <summary>
    ///     VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer
    ///     depth/stencil attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x200,

    /// <summary>
    ///     VK_FORMAT_FEATURE_BLIT_SRC_BIT specifies that an image can be used as srcImage for the vkCmdBlitImage2 and
    ///     vkCmdBlitImage commands.
    /// </summary>
    VK_FORMAT_FEATURE_BLIT_SRC_BIT = 0x400,

    /// <summary>
    ///     VK_FORMAT_FEATURE_BLIT_DST_BIT specifies that an image can be used as dstImage for the vkCmdBlitImage2 and
    ///     vkCmdBlitImage commands.
    /// </summary>
    VK_FORMAT_FEATURE_BLIT_DST_BIT = 0x800,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT specifies that if VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is
    ///     also set, an image view can be used with a sampler that has either of magFilter or minFilter set to
    ///     VK_FILTER_LINEAR, or mipmapMode set to VK_SAMPLER_MIPMAP_MODE_LINEAR. If VK_FORMAT_FEATURE_BLIT_SRC_BIT is also
    ///     set, an image can be used as the srcImage to vkCmdBlitImage2 and vkCmdBlitImagewith a filter of VK_FILTER_LINEAR.
    ///     This bit must only be exposed for formats that also support the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or
    ///     VK_FORMAT_FEATURE_BLIT_SRC_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 0x1000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_TRANSFER_SRC_BIT specifies that an image can be used as a source image for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_TRANSFER_SRC_BIT = 0x4000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_TRANSFER_DST_BIT specifies that an image can be used as a destination image for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_TRANSFER_DST_BIT = 0x8000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub>conversion
    ///     </a>
    ///     using this format as a source, and that an image of this format can
    ///     be used with a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     xChromaOffset and/or yChromaOffset of VK_CHROMA_LOCATION_MIDPOINT. Otherwise both xChromaOffset and yChromaOffset
    ///     must be VK_CHROMA_LOCATION_COSITED_EVEN. If a format does not incorporate chroma downsampling (it is not a &#8220;
    ///     422&#8221; or &#8220;420&#8221; format) but the implementation supports sampler Y′CBCR conversion for this format,
    ///     the implementation must set VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT = 0x20000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BITspecifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source with chromaFilter set to
    ///     VK_FILTER_LINEAR.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 0x40000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BITspecifies that the format
    ///     can have different chroma, min, and mag filters.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 0x80000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITspecifies that reconstruction is
    ///     explicit, as described in
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction
    ///     </a>
    ///     . If this bit is not present, reconstruction is implicit by default.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 0x100000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BITspecifies that
    ///     reconstruction can be forcibly made explicit by setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     ::forceExplicitReconstructionto VK_TRUE. If the format being queried supports
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITit must also support
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x200000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_DISJOINT_BIT specifies that a multi-planar image can have the VK_IMAGE_CREATE_DISJOINT_BIT
    ///     set during image creation. An implementation must not set VK_FORMAT_FEATURE_DISJOINT_BIT for single-plane formats.
    /// </summary>
    VK_FORMAT_FEATURE_DISJOINT_BIT = 0x400000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub>conversion
    ///     </a>
    ///     using this format as a source, and that an image of this format can
    ///     be used with a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     xChromaOffset and/or yChromaOffset of VK_CHROMA_LOCATION_COSITED_EVEN. Otherwise both xChromaOffset and
    ///     yChromaOffset must be VK_CHROMA_LOCATION_MIDPOINT. If neither VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT nor
    ///     VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT is set, the application must not define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source.
    /// </summary>
    VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT = 0x800000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT specifies VkImage can be used as a sampled image with a min
    ///     or max
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html">VkSamplerReductionMode</a>
    ///     . This bit must only be exposed for formats that also support the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 0x10000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR specifies that an image view with this format can be used as an
    ///     output for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR = 0x2000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR specifies that an image view with this format can be used as a DPB for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR = 0x4000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHRspecifies that the format can be used as the vertex
    ///     format when creating an
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure">
    ///         acceleration
    ///         structure
    ///     </a>
    ///     (VkAccelerationStructureGeometryTrianglesDataKHR::vertexFormat). This format can also be used as
    ///     the vertex format in host memory when doing
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#host-acceleration-structure">
    ///         host
    ///         acceleration structure
    ///     </a>
    ///     builds.
    /// </summary>
    VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 0x20000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT specifies that VkImage can be used with a sampler that
    ///     has either of magFilter or minFilter set to VK_FILTER_CUBIC_EXT, or be the source image for a blit with filter set
    ///     to VK_FILTER_CUBIC_EXT. This bit must only be exposed for formats that also support the
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT. If the format being queried is a depth/stencil format, this only specifies
    ///     that the depth aspect is cubic filterable.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = 0x2000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT specifies that an image view can be used as a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-fragmentdensitymapattachment">
    ///         fragment
    ///         density map attachment
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x1000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRspecifies that an image view can be used as a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate attachment
    ///     </a>
    ///     . An implementation must not set this feature for formats with numeric type other
    ///     than *UINT, or set it as a buffer feature.
    /// </summary>
    VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x40000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR specifies that an image view with this format can be used as an input
    ///     to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR = 0x8000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR specifies that an image view with this format can be used as a DPB for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR = 0x10000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT specifies that VkImage can be used with a sampler that
    ///     has either of magFilter or minFilter set to VK_FILTER_CUBIC_EXT, or be the source image for a blit with filter set
    ///     to VK_FILTER_CUBIC_EXT. This bit must only be exposed for formats that also support the
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT. If the format being queried is a depth/stencil format, this only specifies
    ///     that the depth aspect is cubic filterable.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG = VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_TRANSFER_SRC_BIT specifies that an image can be used as a source image for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_SRC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_TRANSFER_DST_BIT specifies that an image can be used as a destination image for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_DST_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT specifies VkImage can be used as a sampled image with a min
    ///     or max
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html">VkSamplerReductionMode</a>
    ///     . This bit must only be exposed for formats that also support the VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT = VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub>conversion
    ///     </a>
    ///     using this format as a source, and that an image of this format can
    ///     be used with a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     xChromaOffset and/or yChromaOffset of VK_CHROMA_LOCATION_MIDPOINT. Otherwise both xChromaOffset and yChromaOffset
    ///     must be VK_CHROMA_LOCATION_COSITED_EVEN. If a format does not incorporate chroma downsampling (it is not a &#8220;
    ///     422&#8221; or &#8220;420&#8221; format) but the implementation supports sampler Y′CBCR conversion for this format,
    ///     the implementation must set VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BITspecifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source with chromaFilter set to
    ///     VK_FILTER_LINEAR.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BITspecifies that the format
    ///     can have different chroma, min, and mag filters.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITspecifies that reconstruction is
    ///     explicit, as described in
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction
    ///     </a>
    ///     . If this bit is not present, reconstruction is implicit by default.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BITspecifies that
    ///     reconstruction can be forcibly made explicit by setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     ::forceExplicitReconstructionto VK_TRUE. If the format being queried supports
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITit must also support
    ///     VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_DISJOINT_BIT specifies that a multi-planar image can have the VK_IMAGE_CREATE_DISJOINT_BIT
    ///     set during image creation. An implementation must not set VK_FORMAT_FEATURE_DISJOINT_BIT for single-plane formats.
    /// </summary>
    VK_FORMAT_FEATURE_DISJOINT_BIT_KHR = VK_FORMAT_FEATURE_DISJOINT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub>conversion
    ///     </a>
    ///     using this format as a source, and that an image of this format can
    ///     be used with a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     xChromaOffset and/or yChromaOffset of VK_CHROMA_LOCATION_COSITED_EVEN. Otherwise both xChromaOffset and
    ///     yChromaOffset must be VK_CHROMA_LOCATION_MIDPOINT. If neither VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT nor
    ///     VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT is set, the application must not define a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source.
    /// </summary>
    VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT
}