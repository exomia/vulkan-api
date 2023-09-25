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
///     VkVideoEncodeH264StdFlagBitsEXT - Video encode H.264 syntax capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264StdFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264StdFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH264StdFlagBitsEXT
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXTindicates if enabling separate_colour_plane_flag
    ///     in StdVideoH264SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_EXTindicates if enabling
    ///     qpprime_y_zero_transform_bypass_flag in StdVideoH264SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_EXTindicates if enabling
    ///     seq_scaling_matrix_present_flag in StdVideoH264SpsFlags or pic_scaling_matrix_present_flag in StdVideoH264PpsFlags
    ///     are supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_EXT indicates if setting non-zero chroma_qp_index_offset
    ///     in StdVideoH264PictureParameterSet is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_EXTindicates if setting non-zero
    ///     second_chroma_qp_index_offset in StdVideoH264PictureParameterSet is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_EXT indicates if setting non-zero pic_init_qp_minus26 in
    ///     StdVideoH264PictureParameterSet is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT indicates if enabling weighted_pred_flag in
    ///     StdVideoH264PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_EXTindicates if using
    ///     STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT from StdVideoH264WeightedBipredIdc is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_EXTindicates if using
    ///     STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT from StdVideoH264WeightedBipredIdc is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_EXT = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_EXTindicates if enabling transform_8x8_mode_flag in
    ///     StdVideoH264PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_EXTindicates if disabling
    ///     StdVideoEncodeH264SliceHeaderFlags::direct_spatial_mv_pred_flagis supported when it is present in the slice header.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_EXT = 0x400,

    /// <summary>VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_EXTindicates if CAVLC entropy coding is supported.</summary>
    VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_EXTindicates if CABAC entropy coding is supported.
    ///     An implementation must support at least one entropy coding mode.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_EXTindicates if disabling
    ///     direct_8x8_inference_flag in StdVideoH264SpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_EXT = 0x2000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXTindicates if enabling
    ///     constrained_intra_pred_flag in StdVideoH264PpsFlags is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT = 0x4000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_EXTindicates if using
    ///     STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED from StdVideoH264DisableDeblockingFilterIdc is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_EXT = 0x8000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_EXTindicates if using
    ///     STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED from StdVideoH264DisableDeblockingFilterIdc is supported.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_EXT = 0x10000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_EXTindicates if using
    ///     STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL from StdVideoH264DisableDeblockingFilterIdc is supported. An
    ///     implementation must support at least one deblocking filter mode.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_EXT = 0x20000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_EXT indicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::slice_qp_delta when that value is identical across
    ///     the slices of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_EXT = 0x80000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXTindicates whether the implementation supports using
    ///     the application-provided value for StdVideoEncodeH264SliceHeader::slice_qp_delta when that value is different
    ///     across the slices of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT = 0x100000
}