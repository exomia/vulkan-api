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
public unsafe struct StdVideoH265SequenceParameterSetVui
{
    public StdVideoH265SpsVuiFlags flags;

    public StdVideoH265AspectRatioIdc aspect_ratio_idc;

    public ushort sar_width;

    public ushort sar_height;

    public byte video_format;

    public byte colour_primaries;

    public byte transfer_characteristics;

    public byte matrix_coeffs;

    public byte chroma_sample_loc_type_top_field;

    public byte chroma_sample_loc_type_bottom_field;

    public byte reserved1;

    public byte reserved2;

    public ushort def_disp_win_left_offset;

    public ushort def_disp_win_right_offset;

    public ushort def_disp_win_top_offset;

    public ushort def_disp_win_bottom_offset;

    public uint vui_num_units_in_tick;

    public uint vui_time_scale;

    public uint vui_num_ticks_poc_diff_one_minus1;

    public ushort min_spatial_segmentation_idc;

    public ushort reserved3;

    public byte max_bytes_per_pic_denom;

    public byte max_bits_per_min_cu_denom;

    public byte log2_max_mv_length_horizontal;

    public byte log2_max_mv_length_vertical;

    public StdVideoH265HrdParameters* pHrdParameters;
}