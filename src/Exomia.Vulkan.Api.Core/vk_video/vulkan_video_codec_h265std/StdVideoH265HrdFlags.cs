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
public struct StdVideoH265HrdFlags
{
    private uint _bitfield1;

    public uint nal_hrd_parameters_present_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint vcl_hrd_parameters_present_flag
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint sub_pic_hrd_params_present_flag
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint sub_pic_cpb_params_in_pic_timing_sei_flag
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint fixed_pic_rate_general_flag
    {
        get { return (uint)((_bitfield1 >> 4) & 0x000000FF); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF00F) | (((uint)value & 0x000000FF) << 4); }
    }

    public uint fixed_pic_rate_within_cvs_flag
    {
        get { return (uint)((_bitfield1 >> 12) & 0x000000FF); }
        set { _bitfield1 = (_bitfield1 & 0xFFF00FFF) | (((uint)value & 0x000000FF) << 12); }
    }

    public uint low_delay_hrd_flag
    {
        get { return (uint)((_bitfield1 >> 20) & 0x000000FF); }
        set { _bitfield1 = (_bitfield1 & 0xF00FFFFF) | (((uint)value & 0x000000FF) << 20); }
    }
}