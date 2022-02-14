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
public struct StdVideoH265PpsFlags
{
    private uint _bitfield1;

    public uint dependent_slice_segments_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint output_flag_present_flag
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }

    public uint sign_data_hiding_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 2) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFB) | (((uint)value & 0x00000001) << 2); }
    }

    public uint cabac_init_present_flag
    {
        get { return (uint)((_bitfield1 >> 3) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFF7) | (((uint)value & 0x00000001) << 3); }
    }

    public uint constrained_intra_pred_flag
    {
        get { return (uint)((_bitfield1 >> 4) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFEF) | (((uint)value & 0x00000001) << 4); }
    }

    public uint transform_skip_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 5) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFDF) | (((uint)value & 0x00000001) << 5); }
    }

    public uint cu_qp_delta_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 6) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFBF) | (((uint)value & 0x00000001) << 6); }
    }

    public uint pps_slice_chroma_qp_offsets_present_flag
    {
        get { return (uint)((_bitfield1 >> 7) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFF7F) | (((uint)value & 0x00000001) << 7); }
    }

    public uint weighted_pred_flag
    {
        get { return (uint)((_bitfield1 >> 8) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFEFF) | (((uint)value & 0x00000001) << 8); }
    }

    public uint weighted_bipred_flag
    {
        get { return (uint)((_bitfield1 >> 9) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFDFF) | (((uint)value & 0x00000001) << 9); }
    }

    public uint transquant_bypass_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 10) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFBFF) | (((uint)value & 0x00000001) << 10); }
    }

    public uint tiles_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 11) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFF7FF) | (((uint)value & 0x00000001) << 11); }
    }

    public uint entropy_coding_sync_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 12) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFEFFF) | (((uint)value & 0x00000001) << 12); }
    }

    public uint uniform_spacing_flag
    {
        get { return (uint)((_bitfield1 >> 13) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFDFFF) | (((uint)value & 0x00000001) << 13); }
    }

    public uint loop_filter_across_tiles_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 14) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFBFFF) | (((uint)value & 0x00000001) << 14); }
    }

    public uint pps_loop_filter_across_slices_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 15) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFF7FFF) | (((uint)value & 0x00000001) << 15); }
    }

    public uint deblocking_filter_control_present_flag
    {
        get { return (uint)((_bitfield1 >> 16) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFEFFFF) | (((uint)value & 0x00000001) << 16); }
    }

    public uint deblocking_filter_override_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 17) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFDFFFF) | (((uint)value & 0x00000001) << 17); }
    }

    public uint pps_deblocking_filter_disabled_flag
    {
        get { return (uint)((_bitfield1 >> 18) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFBFFFF) | (((uint)value & 0x00000001) << 18); }
    }

    public uint pps_scaling_list_data_present_flag
    {
        get { return (uint)((_bitfield1 >> 19) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFF7FFFF) | (((uint)value & 0x00000001) << 19); }
    }

    public uint lists_modification_present_flag
    {
        get { return (uint)((_bitfield1 >> 20) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFEFFFFF) | (((uint)value & 0x00000001) << 20); }
    }

    public uint slice_segment_header_extension_present_flag
    {
        get { return (uint)((_bitfield1 >> 21) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFDFFFFF) | (((uint)value & 0x00000001) << 21); }
    }

    public uint pps_extension_present_flag
    {
        get { return (uint)((_bitfield1 >> 22) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFBFFFFF) | (((uint)value & 0x00000001) << 22); }
    }

    public uint cross_component_prediction_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 23) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFF7FFFFF) | (((uint)value & 0x00000001) << 23); }
    }

    public uint chroma_qp_offset_list_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 24) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFEFFFFFF) | (((uint)value & 0x00000001) << 24); }
    }

    public uint pps_curr_pic_ref_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 25) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFDFFFFFF) | (((uint)value & 0x00000001) << 25); }
    }

    public uint residual_adaptive_colour_transform_enabled_flag
    {
        get { return (uint)((_bitfield1 >> 26) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFBFFFFFF) | (((uint)value & 0x00000001) << 26); }
    }

    public uint pps_slice_act_qp_offsets_present_flag
    {
        get { return (uint)((_bitfield1 >> 27) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xF7FFFFFF) | (((uint)value & 0x00000001) << 27); }
    }

    public uint pps_palette_predictor_initializer_present_flag
    {
        get { return (uint)((_bitfield1 >> 28) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xEFFFFFFF) | (((uint)value & 0x00000001) << 28); }
    }

    public uint monochrome_palette_flag
    {
        get { return (uint)((_bitfield1 >> 29) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xDFFFFFFF) | (((uint)value & 0x00000001) << 29); }
    }

    public uint pps_range_extension_flag
    {
        get { return (uint)((_bitfield1 >> 30) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xBFFFFFFF) | (((uint)value & 0x00000001) << 30); }
    }
}