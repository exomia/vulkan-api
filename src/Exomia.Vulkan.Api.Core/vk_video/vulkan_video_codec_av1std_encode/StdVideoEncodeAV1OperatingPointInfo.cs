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
public struct StdVideoEncodeAV1OperatingPointInfo
{
    public StdVideoEncodeAV1OperatingPointInfoFlags flags;

    public ushort operating_point_idc;

    public byte seq_level_idx;

    public byte seq_tier;

    public uint decoder_buffer_delay;

    public uint encoder_buffer_delay;

    public byte initial_display_delay_minus_1;
}