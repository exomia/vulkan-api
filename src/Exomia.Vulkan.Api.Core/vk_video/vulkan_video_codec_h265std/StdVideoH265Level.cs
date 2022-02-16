#region License

// Copyright (c) 2018-2022, exomia
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

public enum StdVideoH265Level
{
    STD_VIDEO_H265_LEVEL_1_0     = 0,
    STD_VIDEO_H265_LEVEL_2_0     = 1,
    STD_VIDEO_H265_LEVEL_2_1     = 2,
    STD_VIDEO_H265_LEVEL_3_0     = 3,
    STD_VIDEO_H265_LEVEL_3_1     = 4,
    STD_VIDEO_H265_LEVEL_4_0     = 5,
    STD_VIDEO_H265_LEVEL_4_1     = 6,
    STD_VIDEO_H265_LEVEL_5_0     = 7,
    STD_VIDEO_H265_LEVEL_5_1     = 8,
    STD_VIDEO_H265_LEVEL_5_2     = 9,
    STD_VIDEO_H265_LEVEL_6_0     = 10,
    STD_VIDEO_H265_LEVEL_6_1     = 11,
    STD_VIDEO_H265_LEVEL_6_2     = 12,
    STD_VIDEO_H265_LEVEL_INVALID = 0x7FFFFFFF
}