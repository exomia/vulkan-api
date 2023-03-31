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
///     VkFormatFeatureFlagBits2 - Bitmask specifying features supported by a buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits2.html</a>
/// </summary>
[Flags]
public enum VkFormatFeatureFlagBits2 : ulong
{
    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT specifies that an image view can be
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage">
    ///         sampled
    ///         from
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT = 0x1,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT specifies that an image view can be used as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT = 0x2,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT specifies that an image view can be used as storage image that
    ///     supports atomic operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT = 0x4,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view
    ///     that can be bound to a VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT = 0x8,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view
    ///     that can be bound to a VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT = 0x10,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT specifies that atomic operations are supported on
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x20,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT specifies that the format can be used as a vertex attribute format
    ///     (VkVertexInputAttributeDescription::format).
    /// </summary>
    VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT = 0x40,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT = 0x80,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment that supports blending.
    /// </summary>
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT = 0x100,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer
    ///     depth/stencil attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT = 0x200,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT specifies that an image can be     used as the srcImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_BLIT_SRC_BIT = 0x400,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BLIT_DST_BIT specifies that an image can be     used as the dstImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_BLIT_DST_BIT = 0x800,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT specifies that     if
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT is also set, an image     view can be used with a sampler that has either of
    ///     magFilter or     minFilter set to VK_FILTER_LINEAR, or mipmapMode set     to VK_SAMPLER_MIPMAP_MODE_LINEAR.     If
    ///     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT is also set, an image can be     used as the srcImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and     vkCmdBlitImage with a filter of VK_FILTER_LINEAR.     This bit must only be exposed for formats that also
    ///     support the     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT or     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 0x1000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT specifies that VkImage can be used with a sampler that has
    ///     either of magFilter or minFilter set to VK_FILTER_CUBIC_EXT, or be the source image for a blit with filter set to
    ///     VK_FILTER_CUBIC_EXT. This bit must only be exposed for formats that also support the
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT. If the format being queried is a depth/stencil format, this only specifies
    ///     that the depth aspect is cubic filterable.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT = 0x2000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT specifies that an image canbe used as a source image for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT = 0x4000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT specifies that an image canbe used as a destination image for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a> and
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT = 0x8000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT specifies VkImage can be used as a sampled image with a
    ///     min or max
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html">VkSamplerReductionMode</a>
    ///     . This bit must only be exposed for formats that also support the VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 0x10000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
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
    ///     the implementation must set VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT = 0x20000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BITspecifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source with chromaFilter set to
    ///     VK_FILTER_LINEAR.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 0x40000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BITspecifies that the format
    ///     can have different chroma, min, and mag filters.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 0x80000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITspecifies that reconstruction
    ///     is explicit, as described in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction
    ///     </a>
    ///     . If this bit is not present, reconstruction is implicit by default.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 0x100000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BITspecifies that
    ///     reconstruction can be forcibly made explicit by setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     ::forceExplicitReconstructionto VK_TRUE. If the format being queried supports
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITit must also support
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x200000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_DISJOINT_BIT specifies that a multi-planar image can have the VK_IMAGE_CREATE_DISJOINT_BIT
    ///     set during image creation. An implementation must not set VK_FORMAT_FEATURE_2_DISJOINT_BITfor single-plane formats.
    /// </summary>
    VK_FORMAT_FEATURE_2_DISJOINT_BIT = 0x400000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
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
    ///     yChromaOffset must be VK_CHROMA_LOCATION_MIDPOINT. If neither VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT nor
    ///     VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT is set, the application must not define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source.
    /// </summary>
    VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT = 0x800000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT specifies that image views or buffer views created with this
    ///     format can be used as
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         images
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffers
    ///     </a>
    ///     respectively for read operations without specifying a format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT = 0x80000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT specifies that image views or buffer views created with this
    ///     format can be used as
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         images
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffers
    ///     </a>
    ///     respectively for write operations without specifying a format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT = 0x100000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT specifies that image views created with this format can
    ///     be used for depth comparison performed by OpImage*Dref* instructions.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT = 0x200000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR specifies that an image view with this format can be used as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#decode-output-picture">
    ///         decode
    ///         output picture
    ///     </a>
    ///     in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR = 0x2000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR specifies that an image view with this format can be used as an output
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reconstructed-picture">
    ///         reconstructed
    ///         picture
    ///     </a>
    ///     or an input
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-decode-operations">
    ///         video
    ///         decode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR = 0x4000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHRspecifies that the format can be used as the vertex
    ///     format when creating an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#acceleration-structure">
    ///         acceleration
    ///         structure
    ///     </a>
    ///     (VkAccelerationStructureGeometryTrianglesDataKHR::vertexFormat). This format can also be used as
    ///     the vertex format in host memory when doing
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#host-acceleration-structure">
    ///         host
    ///         acceleration structure
    ///     </a>
    ///     builds.
    /// </summary>
    VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 0x20000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT specifies that an image view can be used as a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#renderpass-fragmentdensitymapattachment">
    ///         fragment
    ///         density map attachment
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x1000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRspecifies that an image view can be used as a
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-fragment-shading-rate-attachment">
    ///         fragment
    ///         shading rate attachment
    ///     </a>
    ///     . An implementation must not set this feature for formats with numeric type other
    ///     than *UINT, or set it as a buffer feature.
    /// </summary>
    VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x40000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR specifies that an image view with this format can be used as an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-input-picture">
    ///         encode
    ///         input picture
    ///     </a>
    ///     in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR = 0x8000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR specifies that an image view with this format can be used as an output
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reconstructed-picture">
    ///         reconstructed
    ///         picture
    ///     </a>
    ///     or an input
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#reference-picture">
    ///         reference
    ///         picture
    ///     </a>
    ///     in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR = 0x10000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV specifies that    the format is supported as a renderable
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#glossary-linear-color-attachment">
    ///         Linear
    ///         Color Attachment
    ///     </a>
    ///     .    This bit will be set for renderable color formats in the    linearTilingFeatures. This
    ///     must not be set in the optimalTilingFeatures or bufferFeatures members.
    /// </summary>
    VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV = 0x4000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM specifies that image views created with this format can be used as the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-weightimage">
    ///         weight
    ///         image
    ///     </a>
    ///     input to
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-weightimage">
    ///         weight
    ///         image sampling
    ///     </a>
    ///     operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM = 0x400000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM specifies that image views created with this format can be
    ///     sampled in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-weightimage">
    ///         weight
    ///         image sampling
    ///     </a>
    ///     operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM = 0x800000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM specifies that image views created with this format can be used in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-blockmatch">
    ///         block
    ///         matching
    ///     </a>
    ///     operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM = 0x1000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM specifies that image views created with this format can be sampled
    ///     in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-boxfilter">
    ///         box filter
    ///         sampling
    ///     </a>
    ///     operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM = 0x2000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV specifies that an image view with this format can be used as an input
    ///     or reference to
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#opticalflow-operations">
    ///         optical
    ///         flow operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV = 0x10000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV specifies that an image view with this format can be used as a flow
    ///     vector map (either as hint, output or global flow) for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#opticalflow-operations">
    ///         optical
    ///         flow operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV = 0x20000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV specifies that an image view with this format can be used as an output
    ///     cost map for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#opticalflow-operations">
    ///         optical
    ///         flow operations
    ///     </a>
    /// </summary>
    VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV = 0x40000000000,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT specifies that an image view can be
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-sampledimage">
    ///         sampled
    ///         from
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT specifies that an image view can be used as a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         image
    ///     </a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT specifies that an image view can be used as storage image that
    ///     supports atomic operations.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view
    ///     that can be bound to a VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT specifies that the format can be used to create a buffer view
    ///     that can be bound to a VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT specifies that atomic operations are supported on
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT specifies that the format can be used as a vertex attribute format
    ///     (VkVertexInputAttributeDescription::format).
    /// </summary>
    VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR = VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR = VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT specifies that an image view can be used as a framebuffer color
    ///     attachment that supports blending.
    /// </summary>
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR = VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT specifies that an image view can be used as a framebuffer
    ///     depth/stencil attachment and as an input attachment.
    /// </summary>
    VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR = VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT specifies that an image can be     used as the srcImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR = VK_FORMAT_FEATURE_2_BLIT_SRC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_BLIT_DST_BIT specifies that an image can be     used as the dstImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html">vkCmdBlitImage</a>
    ///     .
    /// </summary>
    VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR = VK_FORMAT_FEATURE_2_BLIT_DST_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT specifies that     if
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT is also set, an image     view can be used with a sampler that has either of
    ///     magFilter or     minFilter set to VK_FILTER_LINEAR, or mipmapMode set     to VK_SAMPLER_MIPMAP_MODE_LINEAR.     If
    ///     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT is also set, an image can be     used as the srcImage for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">vkCmdBlitImage2</a>
    ///     and     vkCmdBlitImage with a filter of VK_FILTER_LINEAR.     This bit must only be exposed for formats that also
    ///     support the     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT or     VK_FORMAT_FEATURE_2_BLIT_SRC_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT specifies that VkImage can be used with a sampler that has
    ///     either of magFilter or minFilter set to VK_FILTER_CUBIC_EXT, or be the source image for a blit with filter set to
    ///     VK_FILTER_CUBIC_EXT. This bit must only be exposed for formats that also support the
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT. If the format being queried is a depth/stencil format, this only specifies
    ///     that the depth aspect is cubic filterable.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT specifies that an image canbe used as a source image for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR = VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT specifies that an image canbe used as a destination image for
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#copies">copy commands</a> and
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#clears">clear commands</a>.
    /// </summary>
    VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR = VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT specifies VkImage can be used as a sampled image with a
    ///     min or max
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html">VkSamplerReductionMode</a>
    ///     . This bit must only be exposed for formats that also support the VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
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
    ///     the implementation must set VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BITspecifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source with chromaFilter set to
    ///     VK_FILTER_LINEAR.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BITspecifies that the format
    ///     can have different chroma, min, and mag filters.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITspecifies that reconstruction
    ///     is explicit, as described in
    ///     <a class="bare"
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction">
    ///         https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#textures-chroma-reconstruction
    ///     </a>
    ///     . If this bit is not present, reconstruction is implicit by default.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BITspecifies that
    ///     reconstruction can be forcibly made explicit by setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionCreateInfo.html">
    ///         VkSamplerYcbcrConversionCreateInfo
    ///     </a>
    ///     ::forceExplicitReconstructionto VK_TRUE. If the format being queried supports
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BITit must also support
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR =
        VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_DISJOINT_BIT specifies that a multi-planar image can have the VK_IMAGE_CREATE_DISJOINT_BIT
    ///     set during image creation. An implementation must not set VK_FORMAT_FEATURE_2_DISJOINT_BITfor single-plane formats.
    /// </summary>
    VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR = VK_FORMAT_FEATURE_2_DISJOINT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT specifies that an application can define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
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
    ///     yChromaOffset must be VK_CHROMA_LOCATION_MIDPOINT. If neither VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT nor
    ///     VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT is set, the application must not define a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#samplers-YCbCr-conversion">
    ///         sampler
    ///         Y′C<sub>B</sub>C<sub>R</sub> conversion
    ///     </a>
    ///     using this format as a source.
    /// </summary>
    VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT specifies that image views or buffer views created with this
    ///     format can be used as
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         images
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffers
    ///     </a>
    ///     respectively for read operations without specifying a format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT specifies that image views or buffer views created with this
    ///     format can be used as
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">
    ///         storage
    ///         images
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storagetexelbuffer">
    ///         storage
    ///         texel buffers
    ///     </a>
    ///     respectively for write operations without specifying a format.
    /// </summary>
    VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR = VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT,

    /// <summary>
    ///     VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT specifies that image views created with this format can
    ///     be used for depth comparison performed by OpImage*Dref* instructions.
    /// </summary>
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR = VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT
}