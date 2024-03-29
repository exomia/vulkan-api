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
public unsafe struct StdVideoH265HrdParameters
{
    public StdVideoH265HrdFlags flags;

    public byte tick_divisor_minus2;

    public byte du_cpb_removal_delay_increment_length_minus1;

    public byte dpb_output_delay_du_length_minus1;

    public byte bit_rate_scale;

    public byte cpb_size_scale;

    public byte cpb_size_du_scale;

    public byte initial_cpb_removal_delay_length_minus1;

    public byte au_cpb_removal_delay_length_minus1;

    public byte dpb_output_delay_length_minus1;

    public fixed byte cpb_cnt_minus1[(int)STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];

    public fixed ushort elemental_duration_in_tc_minus1[(int)STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];

    public VkArray3<ushort> reserved;

    public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;

    public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
}