#region License

// Copyright (c) 2018-2023, exomia
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
public unsafe struct StdVideoEncodeH265LongTermRefPics
{
    public byte num_long_term_sps;

    public byte num_long_term_pics;

    public fixed byte lt_idx_sps[(int)STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS];

    public fixed byte poc_lsb_lt[(int)STD_VIDEO_H265_MAX_LONG_TERM_PICS];

    public ushort used_by_curr_pic_lt_flag;

    public fixed byte delta_poc_msb_present_flag[(int)STD_VIDEO_H265_MAX_DELTA_POC];

    public fixed byte delta_poc_msb_cycle_lt[(int)STD_VIDEO_H265_MAX_DELTA_POC];
}