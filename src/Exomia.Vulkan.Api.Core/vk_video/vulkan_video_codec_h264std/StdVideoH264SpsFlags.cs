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
public struct StdVideoH264SpsFlags
{
    private uint _bitfield1;

    public uint constraint_set0_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint constraint_set1_flag
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint constraint_set2_flag
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint constraint_set3_flag
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint constraint_set4_flag
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint constraint_set5_flag
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint direct_8x8_inference_flag
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint mb_adaptive_frame_field_flag
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }

    public uint frame_mbs_only_flag
    {
        get { return (uint)((_bitfield1 >> 8) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFEFF) | (((uint)value & 0x00000001) << 8); }
    }

    public uint delta_pic_order_always_zero_flag
    {
        get { return (uint)((_bitfield1 >> 9) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFDFF) | (((uint)value & 0x00000001) << 9); }
    }

    public uint separate_colour_plane_flag
    {
        get { return (uint)((_bitfield1 >> 10) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFBFF) | (((uint)value & 0x00000001) << 10); }
    }

    public uint gaps_in_frame_num_value_allowed_flag
    {
        get { return (uint)((_bitfield1 >> 11) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF7FF) | (((uint)value & 0x00000001) << 11); }
    }

    public uint qpprime_y_zero_transform_bypass_flag
    {
        get { return (uint)((_bitfield1 >> 12) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFEFFF) | (((uint)value & 0x00000001) << 12); }
    }

    public uint frame_cropping_flag
    {
        get { return (uint)((_bitfield1 >> 13) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFDFFF) | (((uint)value & 0x00000001) << 13); }
    }

    public uint seq_scaling_matrix_present_flag
    {
        get { return (uint)((_bitfield1 >> 14) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFBFFF) | (((uint)value & 0x00000001) << 14); }
    }

    public uint vui_parameters_present_flag
    {
        get { return (uint)((_bitfield1 >> 15) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFF7FFF) | (((uint)value & 0x00000001) << 15); }
    }
}