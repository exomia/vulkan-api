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

public enum StdVideoH264AspectRatioIdc
{
    STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED  = 0,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE       = 1,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11        = 2,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11        = 3,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11        = 4,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33        = 5,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11        = 6,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11        = 7,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11        = 8,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33        = 9,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11        = 10,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11        = 11,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33        = 12,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99       = 13,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3          = 14,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2          = 15,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1          = 16,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR = 255,
    STD_VIDEO_H264_ASPECT_RATIO_IDC_INVALID      = 0x7FFFFFFF
}