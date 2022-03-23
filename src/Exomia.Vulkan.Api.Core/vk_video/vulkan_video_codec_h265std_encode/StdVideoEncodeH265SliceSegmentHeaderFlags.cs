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
public struct StdVideoEncodeH265SliceSegmentHeaderFlags
{
    private uint _bitfield1;

    public uint first_slice_segment_in_pic_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint no_output_of_prior_pics_flag
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint dependent_slice_segment_flag
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint pic_output_flag
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint short_term_ref_pic_set_sps_flag
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint slice_temporal_mvp_enable_flag
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint slice_sao_luma_flag
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint slice_sao_chroma_flag
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }

    public uint num_ref_idx_active_override_flag
    {
        get { return (uint)((_bitfield1 >> 8) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFEFF) | (((uint)value & 0x00000001) << 8); }
    }

    public uint mvd_l1_zero_flag
    {
        get { return (uint)((_bitfield1 >> 9) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFDFF) | (((uint)value & 0x00000001) << 9); }
    }

    public uint cabac_init_flag
    {
        get { return (uint)((_bitfield1 >> 10) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFBFF) | (((uint)value & 0x00000001) << 10); }
    }

    public uint slice_deblocking_filter_disable_flag
    {
        get { return (uint)((_bitfield1 >> 11) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF7FF) | (((uint)value & 0x00000001) << 11); }
    }

    public uint collocated_from_l0_flag
    {
        get { return (uint)((_bitfield1 >> 12) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFEFFF) | (((uint)value & 0x00000001) << 12); }
    }

    public uint slice_loop_filter_across_slices_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 13) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFDFFF) | (((uint)value & 0x00000001) << 13); }
    }
}