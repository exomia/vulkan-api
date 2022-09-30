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
public unsafe struct StdVideoH264SequenceParameterSetVui
{
    public StdVideoH264SpsVuiFlags flags;

    public StdVideoH264AspectRatioIdc aspect_ratio_idc;

    public ushort sar_width;

    public ushort sar_height;

    public byte video_format;

    public byte colour_primaries;

    public byte transfer_characteristics;

    public byte matrix_coefficients;

    public uint num_units_in_tick;

    public uint time_scale;

    public byte max_num_reorder_frames;

    public byte max_dec_frame_buffering;

    public byte chroma_sample_loc_type_top_field;

    public byte chroma_sample_loc_type_bottom_field;

    public uint reserved1;

    public StdVideoH264HrdParameters* pHrdParameters;
}