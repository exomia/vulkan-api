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
public unsafe struct StdVideoAV1CDEF
{
    public byte cdef_damping_minus_3;

    public byte cdef_bits;

    public fixed byte cdef_y_pri_strength[(int)STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];

    public fixed byte cdef_y_sec_strength[(int)STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];

    public fixed byte cdef_uv_pri_strength[(int)STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];

    public fixed byte cdef_uv_sec_strength[(int)STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];
}