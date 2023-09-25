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
///     VkVideoEncodeH265CapabilityFlagBitsEXT - Video encode H.265 capability flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilityFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilityFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265CapabilityFlagBitsEXT
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT indicates if the implementation guarantees generating a
    ///     HRD compliant bitstream if nal_hrd_parameters_present_flag, vcl_hrd_parameters_present_flag, or
    ///     sub_pic_hrd_params_present_flag are enabled in StdVideoH265HrdFlags, or vui_hrd_parameters_present_flag is enabled
    ///     in StdVideoH265SpsVuiFlags.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXTindicates that when
    ///     weighted_pred_flag or weighted_bipred_flagin StdVideoH265PpsFlags are enabled, the implementation is able to
    ///     internally decide syntax for pred_weight_table.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXTindicates that each slice segment in a
    ///     frame with a single or multiple tiles per slice may begin or finish at any offset in a CTB row. If not supported,
    ///     all slice segments in such a frame must begin at the start of a CTB row (and hence each slice segment must finish
    ///     at the end of a CTB row). Also indicates that each slice segment in a frame with multiple slices per tile may begin
    ///     or finish at any offset within the enclosing tile&#8217;s CTB row. If not supported, slice segments in such a frame
    ///     must begin at the start of the enclosing tile&#8217;s CTB row (and hence each slice segment must finish at the end
    ///     of the enclosing tile&#8217;s CTB row).
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_EXTindicates that when a frame is encoded
    ///     with multiple slice segments, the implementation allows encoding each slice segment with a different
    ///     StdVideoEncodeH265SliceSegmentHeader::slice_type. If not supported, all slice segments of the frame must be encoded
    ///     with the same slice_type which corresponds to the picture type of the frame. For example, all slice segments of a
    ///     P-frame would be encoded as P-slices.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXTindicates support for using a B frame as L0
    ///     reference.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXTindicates support for using a B frame as L1
    ///     reference.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXTindicates support for specifying different
    ///     QP values in the members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QpEXT.html">VkVideoEncodeH265QpEXT</a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_EXTindicates support for specifying
    ///     different constant QP values for each slice segment.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_EXTindicates if encoding multiple tiles
    ///     per slice segment is supported. If not set, the implementation is only able to encode a single tile for each slice
    ///     segment.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_EXT = 0x100,

    /// <summary>
    ///     VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_EXTindicates if encoding multiple slice
    ///     segments per tile is supported. If not set, the implementation is only able to encode a single slice segment for
    ///     each tile.
    /// </summary>
    VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_EXT = 0x200
}