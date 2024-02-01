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
public struct StdVideoAV1SequenceHeaderFlags
{
    private uint _bitfield1;

    public uint still_picture
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint reduced_still_picture_header
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint use_128x128_superblock
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint enable_filter_intra
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint enable_intra_edge_filter
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint enable_interintra_compound
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint enable_masked_compound
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint enable_warped_motion
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }

    public uint enable_dual_filter
    {
        get { return (uint)((_bitfield1 >> 8) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFEFF) | (((uint)value & 0x00000001) << 8); }
    }

    public uint enable_order_hint
    {
        get { return (uint)((_bitfield1 >> 9) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFDFF) | (((uint)value & 0x00000001) << 9); }
    }

    public uint enable_jnt_comp
    {
        get { return (uint)((_bitfield1 >> 10) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFBFF) | (((uint)value & 0x00000001) << 10); }
    }

    public uint enable_ref_frame_mvs
    {
        get { return (uint)((_bitfield1 >> 11) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF7FF) | (((uint)value & 0x00000001) << 11); }
    }

    public uint frame_id_numbers_present_flag
    {
        get { return (uint)((_bitfield1 >> 12) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFEFFF) | (((uint)value & 0x00000001) << 12); }
    }

    public uint enable_superres
    {
        get { return (uint)((_bitfield1 >> 13) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFDFFF) | (((uint)value & 0x00000001) << 13); }
    }

    public uint enable_cdef
    {
        get { return (uint)((_bitfield1 >> 14) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFBFFF) | (((uint)value & 0x00000001) << 14); }
    }

    public uint enable_restoration
    {
        get { return (uint)((_bitfield1 >> 15) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFF7FFF) | (((uint)value & 0x00000001) << 15); }
    }

    public uint film_grain_params_present
    {
        get { return (uint)((_bitfield1 >> 16) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFEFFFF) | (((uint)value & 0x00000001) << 16); }
    }

    public uint timing_info_present_flag
    {
        get { return (uint)((_bitfield1 >> 17) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFDFFFF) | (((uint)value & 0x00000001) << 17); }
    }

    public uint initial_display_delay_present_flag
    {
        get { return (uint)((_bitfield1 >> 18) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFBFFFF) | (((uint)value & 0x00000001) << 18); }
    }

    public uint reserved
    {
        get { return (uint)((_bitfield1 >> 19) & 0x00001FFF); }
        set { _bitfield1 = (_bitfield1 & 0x0007FFFF) | (((uint)value & 0x00001FFF) << 19); }
    }
}