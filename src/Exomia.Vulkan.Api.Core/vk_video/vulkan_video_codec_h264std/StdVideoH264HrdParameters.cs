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
public unsafe struct StdVideoH264HrdParameters
{
    public byte cpb_cnt_minus1;

    public byte bit_rate_scale;

    public byte cpb_size_scale;

    public fixed uint bit_rate_value_minus1[(int)STD_VIDEO_H264_CPB_CNT_LIST_SIZE];

    public fixed uint cpb_size_value_minus1[(int)STD_VIDEO_H264_CPB_CNT_LIST_SIZE];

    public fixed byte cbr_flag[(int)STD_VIDEO_H264_CPB_CNT_LIST_SIZE];

    public uint initial_cpb_removal_delay_length_minus1;

    public uint cpb_removal_delay_length_minus1;

    public uint dpb_output_delay_length_minus1;

    public uint time_offset_length;
}