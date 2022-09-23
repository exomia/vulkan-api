#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecH264std;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public static class VulkanVideoCodecH264std
{
    public const int STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32;

    public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6;

    public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16;

    public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 6;

    public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64;

    public const int STD_VIDEO_H264_MAX_NUM_LIST_REF = 32;

    public const int STD_VIDEO_H264_MAX_CHROMA_PLANES = 2;
}