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
///     VkVideoEncodeH264CapabilityFlagBitsKHR - H.264 encode capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilityFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH264CapabilityFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR indicates whether the implementation may be able to
    ///     generate HRD compliant bitstreams if any of the nal_hrd_parameters_present_flag or vcl_hrd_parameters_present_flag
    ///     members of StdVideoH264SpsVuiFlags are set to 1 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-active-sps">
    ///         active
    ///         SPS
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHRindicates that if
    ///     StdVideoH264PpsFlags::weighted_pred_flag is set to 1 or StdVideoH264PictureParameterSet::weighted_bipred_idc is set
    ///     to STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-active-pps">
    ///         active
    ///         PPS
    ///     </a>
    ///     when encoding a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-p-pic">P picture</a>
    ///     or
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-b-pic">B picture</a>
    ///     , respectively, then the implementation is able to internally decide syntax for pred_weight_table, as defined in
    ///     section 7.4.3.2 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h264">
    ///         ITU-T H.264
    ///         Specification
    ///     </a>
    ///     , and the application is not required to provide a weight table in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHRindicates that each slice in a frame with multiple
    ///     slices may begin or finish at any offset in a macroblock row. If not supported, all slices in the frame must begin
    ///     at the start of a macroblock row (and hence each slice must finish at the end of a macroblock row).
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHRindicates that when a frame is encoded with multiple
    ///     slices, the implementation allows encoding each slice with a different StdVideoEncodeH264SliceHeader::slice_type
    ///     specified in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-slice-header-params">
    ///         H.264
    ///         slice header parameters
    ///     </a>
    ///     . If not supported, all slices of the frame must be encoded with the same slice_type
    ///     which corresponds to the picture type of the frame.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHRindicates support for using a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-b-pic">B frame</a>
    ///     as L0 reference, as specified in StdVideoEncodeH264ReferenceListsInfo::RefPicList0 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-picture-info">
    ///         H.264
    ///         picture information
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHRindicates support for using a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-b-pic">B frame</a>
    ///     as L1 reference, as specified in StdVideoEncodeH264ReferenceListsInfo::RefPicList1 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h264-picture-info">
    ///         H.264
    ///         picture information
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHRindicates support for specifying different
    ///     QP values in the members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QpKHR.html">VkVideoEncodeH264QpKHR</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHRindicates support for specifying different
    ///     constant QP values for each slice.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHRindicates support for generating prefix NAL units
    ///     by setting
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoKHR.html">
    ///         VkVideoEncodeH264PictureInfoKHR
    ///     </a>
    ///     ::generatePrefixNalu to VK_TRUE.
    /// </summary>
    VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR = 0x100
}