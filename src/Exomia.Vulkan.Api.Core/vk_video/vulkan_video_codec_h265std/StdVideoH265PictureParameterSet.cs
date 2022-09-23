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
public unsafe struct StdVideoH265PictureParameterSet
{
    public StdVideoH265PpsFlags flags;

    public byte pps_pic_parameter_set_id;

    public byte pps_seq_parameter_set_id;

    public byte sps_video_parameter_set_id;

    public byte num_extra_slice_header_bits;

    public byte num_ref_idx_l0_default_active_minus1;

    public byte num_ref_idx_l1_default_active_minus1;

    public sbyte init_qp_minus26;

    public byte diff_cu_qp_delta_depth;

    public sbyte pps_cb_qp_offset;

    public sbyte pps_cr_qp_offset;

    public byte num_tile_columns_minus1;

    public byte num_tile_rows_minus1;

    public fixed ushort column_width_minus1[(int)STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE];

    public fixed ushort row_height_minus1[(int)STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE];

    public sbyte pps_beta_offset_div2;

    public sbyte pps_tc_offset_div2;

    public byte log2_parallel_merge_level_minus2;

    public StdVideoH265ScalingLists* pScalingLists;

    public byte log2_max_transform_skip_block_size_minus2;

    public byte diff_cu_chroma_qp_offset_depth;

    public byte chroma_qp_offset_list_len_minus1;

    public fixed sbyte cb_qp_offset_list[(int)STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];

    public fixed sbyte cr_qp_offset_list[(int)STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];

    public byte log2_sao_offset_scale_luma;

    public byte log2_sao_offset_scale_chroma;

    public sbyte pps_act_y_qp_offset_plus5;

    public sbyte pps_act_cb_qp_offset_plus5;

    public sbyte pps_act_cr_qp_offset_plus3;

    public byte pps_num_palette_predictor_initializers;

    public byte luma_bit_depth_entry_minus8;

    public byte chroma_bit_depth_entry_minus8;

    public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}