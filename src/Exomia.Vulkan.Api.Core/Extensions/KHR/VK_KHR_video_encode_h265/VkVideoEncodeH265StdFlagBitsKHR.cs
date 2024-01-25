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
///     VkVideoEncodeH265StdFlagBitsKHR - Video encode H.265 syntax capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265StdFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265StdFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265StdFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH265SpsFlags::separate_colour_plane_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265SpsFlags::sample_adaptive_offset_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for the scaling_list_enabled_flag and
    ///     sps_scaling_list_data_present_flag members of StdVideoH265SpsFlags in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-sps">SPS</a>, and
    ///     the application-provided value for StdVideoH265PpsFlags::pps_scaling_list_data_present_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     those values are 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR indicates whether the implementation supports using the
    ///     application-provided value for StdVideoH265SpsFlags::pcm_enable_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265SpsFlags::sps_temporal_mvp_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR indicates whether the implementation supports using the
    ///     application-provided value for StdVideoH265PictureParameterSet::init_qp_minus26 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is non-zero.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_KHR = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR indicates whether the implementation supports using
    ///     the application-provided value for StdVideoH265PpsFlags::weighted_pred_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHRindicates whether the implementation supports using
    ///     the application-provided value for StdVideoH265PpsFlags::weighted_bipred_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH265PictureParameterSet::log2_parallel_merge_level_minus2in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is non-zero.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_KHR = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265PpsFlags::sign_data_hiding_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_KHR = 0x200,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH265PpsFlags::transform_skip_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_KHR = 0x400,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265PpsFlags::transform_skip_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 0.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_KHR = 0x800,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHRindicates whether the
    ///     implementation supports using the application-provided value for
    ///     StdVideoH265PpsFlags::pps_slice_chroma_qp_offsets_present_flagin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_KHR = 0x1000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265PpsFlags::transquant_bypass_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_KHR = 0x2000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH265PpsFlags::constrained_intra_pred_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265PpsFlags::entropy_coding_sync_enabled_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_KHR = 0x8000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHRindicates whether the
    ///     implementation supports using the application-provided value for
    ///     StdVideoH265PpsFlags::deblocking_filter_override_enabled_flagin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH265PpsFlags::dependent_slice_segments_enabled_flag in
    ///     the <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-pps">PPS</a>
    ///     when that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_KHR = 0x20000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoEncodeH265SliceSegmentHeader::dependent_slice_segment_flagin the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-slice-segment-header-params">
    ///         H.265
    ///         slice segment header parameters
    ///     </a>
    ///     when that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_KHR = 0x40000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR indicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta in the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-slice-segment-header-params">
    ///         H.265
    ///         slice segment header parameters
    ///     </a>
    ///     when that value is identical across the slice segments of the encoded
    ///     frame.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_KHR = 0x80000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHRindicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta in the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-slice-segment-header-params">
    ///         H.265
    ///         slice segment header parameters
    ///     </a>
    ///     when that value is different across the slice segments of the encoded
    ///     frame.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR = 0x100000
}