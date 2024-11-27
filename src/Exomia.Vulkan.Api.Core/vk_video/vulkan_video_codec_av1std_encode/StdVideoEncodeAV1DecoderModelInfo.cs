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
public struct StdVideoEncodeAV1DecoderModelInfo
{
    public byte buffer_delay_length_minus_1;

    public byte buffer_removal_time_length_minus_1;

    public byte frame_presentation_time_length_minus_1;

    public byte reserved1;

    public uint num_units_in_decoding_tick;
}