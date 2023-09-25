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
///     VkVideoEncodeH264CapabilityFlagBitsEXT - Video encode H.264 capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH264CapabilityFlagBitsEXT
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT indicates if the implementation guarantees generating a
    ///     HRD compliant bitstream if nal_hrd_parameters_present_flag or vcl_hrd_parameters_present_flag are enabled in
    ///     StdVideoH264SpsVuiFlags.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXTindicates that when
    ///     weighted_pred_flag is enabled or STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT from StdVideoH264WeightedBipredIdc is
    ///     used, the implementation is able to internally decide syntax for pred_weight_table.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXTindicates that each slice in a frame with multiple
    ///     slices may begin or finish at any offset in a macroblock row. If not supported, all slices in the frame must begin
    ///     at the start of a macroblock row (and hence each slice must finish at the end of a macroblock row).
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXTindicates that when a frame is encoded with
    ///     multiple slices, the implementation allows encoding each slice with a different
    ///     StdVideoEncodeH264SliceHeader::slice_type. If not supported, all slices of the frame must be encoded with the same
    ///     slice_type which corresponds to the picture type of the frame. For example, all slices of a P-frame would be
    ///     encoded as P-slices.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXTindicates support for using a B frame as L0
    ///     reference.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXTindicates support for using a B frame as L1
    ///     reference.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXTindicates support for specifying different
    ///     QP values in the members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QpEXT.html">VkVideoEncodeH264QpEXT</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_EXTindicates support for specifying different
    ///     constant QP values for each slice.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_EXTindicates support for generating prefix NALUs by
    ///     setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoEXT.html">
    ///         VkVideoEncodeH264PictureInfoEXT
    ///     </a>
    ///     ::generatePrefixNalu to VK_TRUE.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_EXT = 0x100
}