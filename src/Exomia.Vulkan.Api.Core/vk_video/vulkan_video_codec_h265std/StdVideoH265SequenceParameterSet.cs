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
public unsafe struct StdVideoH265SequenceParameterSet
{
    public StdVideoH265ProfileIdc profile_idc;

    public StdVideoH265Level level_idc;

    public uint pic_width_in_luma_samples;

    public uint pic_height_in_luma_samples;

    public byte sps_video_parameter_set_id;

    public byte sps_max_sub_layers_minus1;

    public byte sps_seq_parameter_set_id;

    public byte chroma_format_idc;

    public byte bit_depth_luma_minus8;

    public byte bit_depth_chroma_minus8;

    public byte log2_max_pic_order_cnt_lsb_minus4;

    public byte sps_max_dec_pic_buffering_minus1;

    public byte log2_min_luma_coding_block_size_minus3;

    public byte log2_diff_max_min_luma_coding_block_size;

    public byte log2_min_luma_transform_block_size_minus2;

    public byte log2_diff_max_min_luma_transform_block_size;

    public byte max_transform_hierarchy_depth_inter;

    public byte max_transform_hierarchy_depth_intra;

    public byte num_short_term_ref_pic_sets;

    public byte num_long_term_ref_pics_sps;

    public byte pcm_sample_bit_depth_luma_minus1;

    public byte pcm_sample_bit_depth_chroma_minus1;

    public byte log2_min_pcm_luma_coding_block_size_minus3;

    public byte log2_diff_max_min_pcm_luma_coding_block_size;

    public uint conf_win_left_offset;

    public uint conf_win_right_offset;

    public uint conf_win_top_offset;

    public uint conf_win_bottom_offset;

    public StdVideoH265DecPicBufMgr* pDecPicBufMgr;

    public StdVideoH265SpsFlags flags;

    public StdVideoH265ScalingLists* pScalingLists;

    public StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui;

    public byte palette_max_size;

    public byte delta_palette_max_predictor_size;

    public byte motion_vector_resolution_control_idc;

    public byte sps_num_palette_predictor_initializer_minus1;

    public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}