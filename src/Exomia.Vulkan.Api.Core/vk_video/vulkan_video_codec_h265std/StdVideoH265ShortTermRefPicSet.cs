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
public unsafe struct StdVideoH265ShortTermRefPicSet
{
    public StdVideoH265ShortTermRefPicSetFlags flags;

    public uint delta_idx_minus1;

    public ushort use_delta_flag;

    public ushort abs_delta_rps_minus1;

    public ushort used_by_curr_pic_flag;

    public ushort used_by_curr_pic_s0_flag;

    public ushort used_by_curr_pic_s1_flag;

    public ushort reserved1;

    public byte reserved2;

    public byte reserved3;

    public byte num_negative_pics;

    public byte num_positive_pics;

    public fixed ushort delta_poc_s0_minus1[(int)STD_VIDEO_H265_MAX_DPB_SIZE];

    public fixed ushort delta_poc_s1_minus1[(int)STD_VIDEO_H265_MAX_DPB_SIZE];
}