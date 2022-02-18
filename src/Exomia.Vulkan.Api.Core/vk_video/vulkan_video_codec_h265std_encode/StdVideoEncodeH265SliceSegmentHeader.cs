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
public unsafe struct StdVideoEncodeH265SliceSegmentHeader
{
    public StdVideoH265SliceType slice_type;

    public byte slice_pic_parameter_set_id;

    public byte num_short_term_ref_pic_sets;

    public uint slice_segment_address;

    public byte short_term_ref_pic_set_idx;

    public byte num_long_term_sps;

    public byte num_long_term_pics;

    public byte collocated_ref_idx;

    public byte num_ref_idx_l0_active_minus1;

    public byte num_ref_idx_l1_active_minus1;

    public byte luma_log2_weight_denom;

    public sbyte delta_chroma_log2_weight_denom;

    public fixed sbyte delta_luma_weight_l0[(int)STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE];

    public fixed sbyte luma_offset_l0[(int)STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE];

    public VkArray15<VkArray2<sbyte>> delta_chroma_weight_l0;

    public VkArray15<VkArray2<sbyte>> delta_chroma_offset_l0;

    public fixed sbyte delta_luma_weight_l1[(int)STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE];

    public fixed sbyte luma_offset_l1[(int)STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE];

    public VkArray15<VkArray2<sbyte>> delta_chroma_weight_l1;

    public VkArray15<VkArray2<sbyte>> delta_chroma_offset_l1;

    public byte MaxNumMergeCand;

    public sbyte slice_cb_qp_offset;

    public sbyte slice_cr_qp_offset;

    public sbyte slice_beta_offset_div2;

    public sbyte slice_tc_offset_div2;

    public sbyte slice_act_y_qp_offset;

    public sbyte slice_act_cb_qp_offset;

    public sbyte slice_act_cr_qp_offset;

    public StdVideoEncodeH265SliceSegmentHeaderFlags flags;
}