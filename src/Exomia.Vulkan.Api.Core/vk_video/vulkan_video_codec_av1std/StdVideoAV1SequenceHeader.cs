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
public unsafe struct StdVideoAV1SequenceHeader
{
    public StdVideoAV1SequenceHeaderFlags flags;

    public StdVideoAV1Profile seq_profile;

    public byte frame_width_bits_minus_1;

    public byte frame_height_bits_minus_1;

    public ushort max_frame_width_minus_1;

    public ushort max_frame_height_minus_1;

    public byte delta_frame_id_length_minus_2;

    public byte additional_frame_id_length_minus_1;

    public byte order_hint_bits_minus_1;

    public byte seq_force_integer_mv;

    public byte seq_force_screen_content_tools;

    public fixed byte reserved1[5];

    public StdVideoAV1ColorConfig* pColorConfig;

    public StdVideoAV1TimingInfo* pTimingInfo;
}