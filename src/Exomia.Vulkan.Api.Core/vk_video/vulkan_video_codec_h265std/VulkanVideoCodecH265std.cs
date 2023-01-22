#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecH265std;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public static class VulkanVideoCodecH265std
{
    public const int STD_VIDEO_H265_CPB_CNT_LIST_SIZE = 32;

    public const int STD_VIDEO_H265_SUBLAYERS_LIST_SIZE = 7;

    public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS = 6;

    public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS = 16;

    public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS = 6;

    public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS = 64;

    public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS = 6;

    public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS = 64;

    public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS = 2;

    public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS = 64;

    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6;

    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19;

    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21;

    public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE = 3;

    public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE = 128;

    public const int STD_VIDEO_H265_MAX_NUM_LIST_REF = 15;

    public const int STD_VIDEO_H265_MAX_CHROMA_PLANES = 2;

    public const int STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS = 64;

    public const int STD_VIDEO_H265_MAX_DPB_SIZE = 16;

    public const int STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS = 32;

    public const int STD_VIDEO_H265_MAX_LONG_TERM_PICS = 16;

    public const int STD_VIDEO_H265_MAX_DELTA_POC = 48;
}