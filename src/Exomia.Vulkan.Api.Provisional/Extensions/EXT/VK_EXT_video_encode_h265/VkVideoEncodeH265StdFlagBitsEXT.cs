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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkVideoEncodeH265StdFlagBitsEXT - Video encode H.265 syntax capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265StdFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265StdFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265StdFlagBitsEXT
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXTindicates if enabling separate_colour_plane_flag
    ///     in StdVideoH265SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     sample_adaptive_offset_enabled_flag in StdVideoH265SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_EXTindicates if enabling
    ///     scaling_list_enabled_flag and sps_scaling_list_data_present_flag in StdVideoH265SpsFlags, or enabling
    ///     pps_scaling_list_data_present_flag in StdVideoH265PpsFlags are supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_EXT indicates if enabling pcm_enable_flag in
    ///     StdVideoH265SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     sps_temporal_mvp_enabled_flag in StdVideoH265SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_EXT indicates if setting non-zero init_qp_minus26 in
    ///     StdVideoH265PictureParameterSet is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT indicates if enabling weighted_pred_flag in
    ///     StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_EXTindicates if enabling weighted_bipred_flag in
    ///     StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXTindicates if setting non-zero value for
    ///     log2_parallel_merge_level_minus2 in StdVideoH265PictureParameterSet is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     sign_data_hiding_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     transform_skip_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXT = 0x400,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXTindicates if disabling
    ///     transform_skip_enabled_flag in StdVideoH265PpsFlags is supported. Implementations must report at least one of
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXTand
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXTas supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_EXTindicates if enabling
    ///     pps_slice_chroma_qp_offsets_present_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     transquant_bypass_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_EXT = 0x2000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXTindicates if enabling
    ///     constrained_intra_pred_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT = 0x4000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     entropy_coding_sync_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_EXT = 0x8000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     deblocking_filter_override_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_EXT = 0x10000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_EXTindicates if enabling
    ///     dependent_slice_segments_enabled_flag in StdVideoH265PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_EXT = 0x20000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_EXTindicates if enabling
    ///     dependent_slice_segment_flag in StdVideoEncodeH265SliceHeaderFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_EXT = 0x40000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_EXT indicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta when that value is identical
    ///     across the slice segments of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_EXT = 0x80000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXTindicates whether the implementation supports using
    ///     the application-provided value for StdVideoEncodeH265SliceSegmentHeader::slice_qp_delta when that value is
    ///     different across the slice segments of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT = 0x100000
}