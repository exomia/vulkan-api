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
public unsafe struct StdVideoEncodeH264SliceHeader
{
    public StdVideoEncodeH264SliceHeaderFlags flags;

    public uint first_mb_in_slice;

    public StdVideoH264SliceType slice_type;

    public sbyte slice_alpha_c0_offset_div2;

    public sbyte slice_beta_offset_div2;

    public sbyte slice_qp_delta;

    public byte reserved1;

    public StdVideoH264CabacInitIdc cabac_init_idc;

    public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;

    public StdVideoEncodeH264WeightTable* pWeightTable;
}