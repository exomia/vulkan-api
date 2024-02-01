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
public unsafe struct StdVideoAV1LoopFilter
{
    public StdVideoAV1LoopFilterFlags flags;

    public fixed byte loop_filter_level[(int)STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS];

    public byte loop_filter_sharpness;

    public byte update_ref_delta;

    public fixed sbyte loop_filter_ref_deltas[(int)STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME];

    public byte update_mode_delta;

    public fixed sbyte loop_filter_mode_deltas[(int)STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS];
}