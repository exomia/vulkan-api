#region License

// Copyright (c) 2018-2024, exomia
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
    public StdVideoEncodeH265SliceSegmentHeaderFlags flags;

    public StdVideoH265SliceType slice_type;

    public uint slice_segment_address;

    public byte collocated_ref_idx;

    public byte MaxNumMergeCand;

    public sbyte slice_cb_qp_offset;

    public sbyte slice_cr_qp_offset;

    public sbyte slice_beta_offset_div2;

    public sbyte slice_tc_offset_div2;

    public sbyte slice_act_y_qp_offset;

    public sbyte slice_act_cb_qp_offset;

    public sbyte slice_act_cr_qp_offset;

    public sbyte slice_qp_delta;

    public ushort reserved1;

    public StdVideoEncodeH265WeightTable* pWeightTable;
}