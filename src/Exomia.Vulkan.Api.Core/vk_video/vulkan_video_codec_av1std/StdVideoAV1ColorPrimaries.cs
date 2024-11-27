#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public enum StdVideoAV1ColorPrimaries
{
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709         = 1,
    STD_VIDEO_AV1_COLOR_PRIMARIES_UNSPECIFIED    = 2,
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M       = 4,
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G     = 5,
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601         = 6,
    STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240      = 7,
    STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM   = 8,
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020        = 9,
    STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ            = 10,
    STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431      = 11,
    STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432      = 12,
    STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213       = 22,
    STD_VIDEO_AV1_COLOR_PRIMARIES_INVALID        = 0x7FFFFFFF,
    STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED = STD_VIDEO_AV1_COLOR_PRIMARIES_UNSPECIFIED
}