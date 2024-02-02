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
public struct StdVideoDecodeAV1PictureInfoFlags
{
    private uint _bitfield1;

    public uint error_resilient_mode
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint disable_cdf_update
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint use_superres
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint render_and_frame_size_different
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint allow_screen_content_tools
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint is_filter_switchable
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint force_integer_mv
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint frame_size_override_flag
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }

    public uint buffer_removal_time_present_flag
    {
        get { return (uint)((_bitfield1 >> 8) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFEFF) | (((uint)value & 0x00000001) << 8); }
    }

    public uint allow_intrabc
    {
        get { return (uint)((_bitfield1 >> 9) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFDFF) | (((uint)value & 0x00000001) << 9); }
    }

    public uint frame_refs_short_signaling
    {
        get { return (uint)((_bitfield1 >> 10) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFBFF) | (((uint)value & 0x00000001) << 10); }
    }

    public uint allow_high_precision_mv
    {
        get { return (uint)((_bitfield1 >> 11) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF7FF) | (((uint)value & 0x00000001) << 11); }
    }

    public uint is_motion_mode_switchable
    {
        get { return (uint)((_bitfield1 >> 12) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFEFFF) | (((uint)value & 0x00000001) << 12); }
    }

    public uint use_ref_frame_mvs
    {
        get { return (uint)((_bitfield1 >> 13) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFDFFF) | (((uint)value & 0x00000001) << 13); }
    }

    public uint disable_frame_end_update_cdf
    {
        get { return (uint)((_bitfield1 >> 14) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFBFFF) | (((uint)value & 0x00000001) << 14); }
    }

    public uint allow_warped_motion
    {
        get { return (uint)((_bitfield1 >> 15) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFF7FFF) | (((uint)value & 0x00000001) << 15); }
    }

    public uint reduced_tx_set
    {
        get { return (uint)((_bitfield1 >> 16) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFEFFFF) | (((uint)value & 0x00000001) << 16); }
    }

    public uint reference_select
    {
        get { return (uint)((_bitfield1 >> 17) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFDFFFF) | (((uint)value & 0x00000001) << 17); }
    }

    public uint skip_mode_present
    {
        get { return (uint)((_bitfield1 >> 18) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFBFFFF) | (((uint)value & 0x00000001) << 18); }
    }

    public uint delta_q_present
    {
        get { return (uint)((_bitfield1 >> 19) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFF7FFFF) | (((uint)value & 0x00000001) << 19); }
    }

    public uint delta_lf_present
    {
        get { return (uint)((_bitfield1 >> 20) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFEFFFFF) | (((uint)value & 0x00000001) << 20); }
    }

    public uint delta_lf_multi
    {
        get { return (uint)((_bitfield1 >> 21) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFDFFFFF) | (((uint)value & 0x00000001) << 21); }
    }

    public uint segmentation_enabled
    {
        get { return (uint)((_bitfield1 >> 22) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFBFFFFF) | (((uint)value & 0x00000001) << 22); }
    }

    public uint segmentation_update_map
    {
        get { return (uint)((_bitfield1 >> 23) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFF7FFFFF) | (((uint)value & 0x00000001) << 23); }
    }

    public uint segmentation_temporal_update
    {
        get { return (uint)((_bitfield1 >> 24) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFEFFFFFF) | (((uint)value & 0x00000001) << 24); }
    }

    public uint segmentation_update_data
    {
        get { return (uint)((_bitfield1 >> 25) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFDFFFFFF) | (((uint)value & 0x00000001) << 25); }
    }

    public uint UsesLr
    {
        get { return (uint)((_bitfield1 >> 26) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFBFFFFFF) | (((uint)value & 0x00000001) << 26); }
    }

    public uint usesChromaLr
    {
        get { return (uint)((_bitfield1 >> 27) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xF7FFFFFF) | (((uint)value & 0x00000001) << 27); }
    }

    public uint apply_grain
    {
        get { return (uint)((_bitfield1 >> 28) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xEFFFFFFF) | (((uint)value & 0x00000001) << 28); }
    }

    public uint reserved
    {
        get { return (uint)((_bitfield1 >> 29) & 0x00000007); }
        set { _bitfield1 = (_bitfield1 & 0x1FFFFFFF) | (((uint)value & 0x00000007) << 29); }
    }
}