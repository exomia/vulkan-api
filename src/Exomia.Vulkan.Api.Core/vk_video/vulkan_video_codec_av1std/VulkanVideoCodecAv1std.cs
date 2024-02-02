#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecAv1std;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public static class VulkanVideoCodecAv1std
{
    public const int STD_VIDEO_AV1_NUM_REF_FRAMES = 8;

    public const int STD_VIDEO_AV1_REFS_PER_FRAME = 7;

    public const int STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME = 8;

    public const int STD_VIDEO_AV1_MAX_TILE_COLS = 64;

    public const int STD_VIDEO_AV1_MAX_TILE_ROWS = 64;

    public const int STD_VIDEO_AV1_MAX_SEGMENTS = 8;

    public const int STD_VIDEO_AV1_SEG_LVL_MAX = 8;

    public const int STD_VIDEO_AV1_PRIMARY_REF_NONE = 7;

    public const int STD_VIDEO_AV1_SELECT_INTEGER_MV = 2;

    public const int STD_VIDEO_AV1_SELECT_SCREEN_CONTENT_TOOLS = 2;

    public const int STD_VIDEO_AV1_SKIP_MODE_FRAMES = 2;

    public const int STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS = 4;

    public const int STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS = 2;

    public const int STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS = 8;

    public const int STD_VIDEO_AV1_MAX_NUM_PLANES = 3;

    public const int STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS = 6;

    public const int STD_VIDEO_AV1_MAX_NUM_Y_POINTS = 14;

    public const int STD_VIDEO_AV1_MAX_NUM_CB_POINTS = 10;

    public const int STD_VIDEO_AV1_MAX_NUM_CR_POINTS = 10;

    public const int STD_VIDEO_AV1_MAX_NUM_POS_LUMA = 24;

    public const int STD_VIDEO_AV1_MAX_NUM_POS_CHROMA = 25;
}