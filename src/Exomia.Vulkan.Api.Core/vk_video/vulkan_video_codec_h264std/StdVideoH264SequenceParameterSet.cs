#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct StdVideoH264SequenceParameterSet
{
    public StdVideoH264SpsFlags flags;

    public StdVideoH264ProfileIdc profile_idc;

    public StdVideoH264LevelIdc level_idc;

    public byte seq_parameter_set_id;

    public StdVideoH264ChromaFormatIdc chroma_format_idc;

    public byte bit_depth_luma_minus8;

    public byte bit_depth_chroma_minus8;

    public byte log2_max_frame_num_minus4;

    public StdVideoH264PocType pic_order_cnt_type;

    public byte log2_max_pic_order_cnt_lsb_minus4;

    public int offset_for_non_ref_pic;

    public int offset_for_top_to_bottom_field;

    public byte num_ref_frames_in_pic_order_cnt_cycle;

    public byte max_num_ref_frames;

    public uint pic_width_in_mbs_minus1;

    public uint pic_height_in_map_units_minus1;

    public uint frame_crop_left_offset;

    public uint frame_crop_right_offset;

    public uint frame_crop_top_offset;

    public uint frame_crop_bottom_offset;

    public int* pOffsetForRefFrame;

    public StdVideoH264ScalingLists* pScalingLists;

    public StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui;
}