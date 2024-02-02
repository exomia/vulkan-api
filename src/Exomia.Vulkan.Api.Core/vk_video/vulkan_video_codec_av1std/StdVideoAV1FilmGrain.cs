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
public unsafe struct StdVideoAV1FilmGrain
{
    public StdVideoAV1FilmGrainFlags flags;

    public byte grain_scaling_minus_8;

    public byte ar_coeff_lag;

    public byte ar_coeff_shift_minus_6;

    public byte grain_scale_shift;

    public ushort grain_seed;

    public byte film_grain_params_ref_idx;

    public byte num_y_points;

    public fixed byte point_y_value[(int)STD_VIDEO_AV1_MAX_NUM_Y_POINTS];

    public fixed byte point_y_scaling[(int)STD_VIDEO_AV1_MAX_NUM_Y_POINTS];

    public byte num_cb_points;

    public fixed byte point_cb_value[(int)STD_VIDEO_AV1_MAX_NUM_CB_POINTS];

    public fixed byte point_cb_scaling[(int)STD_VIDEO_AV1_MAX_NUM_CB_POINTS];

    public byte num_cr_points;

    public fixed byte point_cr_value[(int)STD_VIDEO_AV1_MAX_NUM_CR_POINTS];

    public fixed byte point_cr_scaling[(int)STD_VIDEO_AV1_MAX_NUM_CR_POINTS];

    public fixed sbyte ar_coeffs_y_plus_128[(int)STD_VIDEO_AV1_MAX_NUM_POS_LUMA];

    public fixed sbyte ar_coeffs_cb_plus_128[(int)STD_VIDEO_AV1_MAX_NUM_POS_CHROMA];

    public fixed sbyte ar_coeffs_cr_plus_128[(int)STD_VIDEO_AV1_MAX_NUM_POS_CHROMA];

    public byte cb_mult;

    public byte cb_luma_mult;

    public ushort cb_offset;

    public byte cr_mult;

    public byte cr_luma_mult;

    public ushort cr_offset;
}