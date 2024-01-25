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
public struct StdVideoH264PpsFlags
{
    private uint _bitfield1;

    public uint transform_8x8_mode_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint redundant_pic_cnt_present_flag
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint constrained_intra_pred_flag
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint deblocking_filter_control_present_flag
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint weighted_pred_flag
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint bottom_field_pic_order_in_frame_present_flag
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint entropy_coding_mode_flag
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint pic_scaling_matrix_present_flag
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }
}