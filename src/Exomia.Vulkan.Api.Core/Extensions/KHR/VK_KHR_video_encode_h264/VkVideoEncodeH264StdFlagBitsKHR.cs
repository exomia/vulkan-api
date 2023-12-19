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
///     VkVideoEncodeH264StdFlagBitsKHR - Video encode H.264 syntax capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264StdFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264StdFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH264StdFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264SpsFlags::separate_colour_plane_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHRindicates whether the implementation
    ///     supports using the application-provided value for StdVideoH264SpsFlags::qpprime_y_zero_transform_bypass_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-sps">SPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided values for StdVideoH264SpsFlags::seq_scaling_matrix_present_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-sps">SPS</a> and
    ///     StdVideoH264PpsFlags::pic_scaling_matrix_present_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     any of those values are 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR indicates whether the implementation supports using
    ///     the the application-provided value for StdVideoH264PictureParameterSet::chroma_qp_index_offset in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is non-zero.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264PictureParameterSet::second_chroma_qp_index_offsetin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is non-zero.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR indicates whether the implementation supports using the
    ///     application-provided value for StdVideoH264PictureParameterSet::pic_init_qp_minus26 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is non-zero.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_KHR = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR indicates whether the implementation supports using
    ///     the application-provided value for StdVideoH264PpsFlags::weighted_pred_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264PictureParameterSet::weighted_bipred_idc in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264PictureParameterSet::weighted_bipred_idc in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_KHR = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264PpsFlags::transform_8x8_mode_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_KHR = 0x200,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoEncodeH264SliceHeaderFlags::direct_spatial_mv_pred_flagin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is 0.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_KHR = 0x400,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHRindicates whether the implementation supports CAVLC
    ///     entropy coding, as defined in section 9.2 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h264">
    ///         ITU-T H.264
    ///         Specification
    ///     </a>
    ///     , and thus supports using the application-provided value for
    ///     StdVideoH264PpsFlags::entropy_coding_mode_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is 0.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_KHR = 0x800,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHRindicates whether the implementation supports CABAC
    ///     entropy coding, as defined in section 9.3 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h264">
    ///         ITU-T H.264
    ///         Specification
    ///     </a>
    ///     , and thus supports using the application-provided value for
    ///     StdVideoH264PpsFlags::entropy_coding_mode_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_KHR = 0x1000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264SpsFlags::direct_8x8_inference_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-sps">SPS</a> when
    ///     that value is 0.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_KHR = 0x2000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHRindicates whether the implementation supports
    ///     using the application-provided value for StdVideoH264PpsFlags::constrained_intra_pred_flag in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-pps">PPS</a> when
    ///     that value is 1.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHRindicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idcin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_KHR = 0x8000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHRindicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idcin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHRindicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::disable_deblocking_filter_idcin the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_KHR = 0x20000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR indicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::slice_qp_delta in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is identical across the slices of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_KHR = 0x80000,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHRindicates whether the implementation supports using the
    ///     application-provided value for StdVideoEncodeH264SliceHeader::slice_qp_delta in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     when that value is different across the slices of the encoded frame.
    /// </summary>
    VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_KHR = 0x100000
}