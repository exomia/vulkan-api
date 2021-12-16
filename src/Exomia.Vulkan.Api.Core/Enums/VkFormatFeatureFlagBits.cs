#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[Flags]
public enum VkFormatFeatureFlagBits
{
    SAMPLED_IMAGE_BIT                                                           = 0x00000001,
    STORAGE_IMAGE_BIT                                                           = 0x00000002,
    STORAGE_IMAGE_ATOMIC_BIT                                                    = 0x00000004,
    UNIFORM_TEXEL_BUFFER_BIT                                                    = 0x00000008,
    STORAGE_TEXEL_BUFFER_BIT                                                    = 0x00000010,
    STORAGE_TEXEL_BUFFER_ATOMIC_BIT                                             = 0x00000020,
    VERTEX_BUFFER_BIT                                                           = 0x00000040,
    COLOR_ATTACHMENT_BIT                                                        = 0x00000080,
    COLOR_ATTACHMENT_BLEND_BIT                                                  = 0x00000100,
    DEPTH_STENCIL_ATTACHMENT_BIT                                                = 0x00000200,
    BLIT_SRC_BIT                                                                = 0x00000400,
    BLIT_DST_BIT                                                                = 0x00000800,
    SAMPLED_IMAGE_FILTER_LINEAR_BIT                                             = 0x00001000,
    TRANSFER_SRC_BIT                                                            = 0x00004000,
    TRANSFER_DST_BIT                                                            = 0x00008000,
    MIDPOINT_CHROMA_SAMPLES_BIT                                                 = 0x00020000,
    SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT                            = 0x00040000,
    SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT           = 0x00080000,
    SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT           = 0x00100000,
    SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x00200000,
    DISJOINT_BIT                                                                = 0x00400000,
    COSITED_CHROMA_SAMPLES_BIT                                                  = 0x00800000,
    SAMPLED_IMAGE_FILTER_MINMAX_BIT                                             = 0x00010000,
    SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG                                          = 0x00002000,
    VIDEO_DECODE_OUTPUT_BIT_KHR                                                 = 0x02000000,
    VIDEO_DECODE_DPB_BIT_KHR                                                    = 0x04000000,
    ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR                                = 0x20000000,
    FRAGMENT_DENSITY_MAP_BIT_EXT                                                = 0x01000000,
    FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR                                    = 0x40000000,
    VIDEO_ENCODE_INPUT_BIT_KHR                                                  = 0x08000000,
    VIDEO_ENCODE_DPB_BIT_KHR                                                    = 0x10000000,
    TRANSFER_SRC_BIT_KHR                                                        = TRANSFER_SRC_BIT,
    TRANSFER_DST_BIT_KHR                                                        = TRANSFER_DST_BIT,
    SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT                                         = SAMPLED_IMAGE_FILTER_MINMAX_BIT,
    MIDPOINT_CHROMA_SAMPLES_BIT_KHR                                             = MIDPOINT_CHROMA_SAMPLES_BIT,
    SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR                        = SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,

    SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR =
        SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,

    SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR =
        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,

    SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR =
        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,
    DISJOINT_BIT_KHR                   = DISJOINT_BIT,
    COSITED_CHROMA_SAMPLES_BIT_KHR     = COSITED_CHROMA_SAMPLES_BIT,
    SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG,
    FLAG_BITS_MAX_ENUM                 = 0x7FFFFFFF
}