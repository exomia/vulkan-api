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
///     VkVideoEncodeH265CapabilityFlagBitsKHR - Video encode H.265 capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilityFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilityFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265CapabilityFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_KHR specifies whether the implementation may be able to
    ///     generate HRD compliant bitstreams if any of the nal_hrd_parameters_present_flag, vcl_hrd_parameters_present_flag,
    ///     or sub_pic_hrd_params_present_flag members of StdVideoH265HrdFlags are set to 1 in the HRD parameters of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-active-vps">
    ///         active
    ///         VPS
    ///     </a>
    ///     or
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-active-sps">
    ///         active
    ///         SPS
    ///     </a>
    ///     , or if StdVideoH265SpsVuiFlags::vui_hrd_parameters_present_flag is set to 1 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-active-sps">
    ///         active
    ///         SPS
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHRspecifies that if the weighted_pred_flag
    ///     or the weighted_bipred_flag member of StdVideoH265PpsFlags is set to 1 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-active-pps">
    ///         active
    ///         PPS
    ///     </a>
    ///     when encoding a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-p-pic">P picture</a>
    ///     or
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-b-pic">B picture</a>
    ///     , respectively, then the implementation is able to internally decide syntax for pred_weight_table, as defined in
    ///     section 7.4.7.3 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h265">
    ///         ITU-T H.265
    ///         Specification
    ///     </a>
    ///     , and the application is not required to provide a weight table in the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-slice-segment-header-params">
    ///         H.265
    ///         slice segment header parameters
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_KHRspecifies that each slice segment in a
    ///     frame with a single or multiple tiles per slice may begin or finish at any offset in a CTB row. If not supported,
    ///     all slice segments in such a frame must begin at the start of a CTB row (and hence each slice segment must finish
    ///     at the end of a CTB row). Also indicates that each slice segment in a frame with multiple slices per tile may begin
    ///     or finish at any offset within the enclosing tile&#8217;s CTB row. If not supported, slice segments in such a frame
    ///     must begin at the start of the enclosing tile&#8217;s CTB row (and hence each slice segment must finish at the end
    ///     of the enclosing tile&#8217;s CTB row).
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_KHRspecifies that when a frame is encoded with
    ///     multiple slice segments, the implementation allows encoding each slice segment with a different
    ///     StdVideoEncodeH265SliceSegmentHeader::slice_type specified in the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-slice-segment-header-params">
    ///         H.265
    ///         slice segment header parameters
    ///     </a>
    ///     . If not supported, all slice segments of the frame must be encoded with the
    ///     same slice_type which corresponds to the picture type of the frame.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHRspecifies support for using a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-b-pic">B frame</a>
    ///     as L0 reference, as specified in StdVideoEncodeH265ReferenceListsInfo::RefPicList0 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-picture-info">
    ///         H.265
    ///         picture information
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHRspecifies support for using a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-b-pic">B frame</a>
    ///     as L1 reference, as specified in StdVideoEncodeH265ReferenceListsInfo::RefPicList1 in the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-h265-picture-info">
    ///         H.265
    ///         picture information
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHRspecifies support for specifying different
    ///     QP values in the members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QpKHR.html">VkVideoEncodeH265QpKHR</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_KHRspecifies support for specifying
    ///     different constant QP values for each slice segment.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_KHRspecifies whether encoding multiple tiles
    ///     per slice segment, as defined in section 6.3.1 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h265">
    ///         ITU-T H.265
    ///         Specification
    ///     </a>
    ///     , is supported. If this capability flag is not present, then the implementation is only able
    ///     to encode a single tile for each slice segment.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_KHR = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_KHRspecifies whether encoding multiple slice
    ///     segments per tile, as defined in section 6.3.1 of the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#itu-t-h265">
    ///         ITU-T H.265
    ///         Specification
    ///     </a>
    ///     , is supported. If this capability flag is not present, then the implementation is only able
    ///     to encode a single slice segment for each tile.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_KHR = 0x200,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_CU_QP_DIFF_WRAPAROUND_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeH265CapabilityFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeH265CapabilityFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_CU_QP_DIFF_WRAPAROUND_BIT_KHR = 0x400
}