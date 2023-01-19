#region License

// Copyright (c) 2018-2023, exomia
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

public enum StdVideoH265ProfileIdc
{
    STD_VIDEO_H265_PROFILE_IDC_MAIN                    = 1,
    STD_VIDEO_H265_PROFILE_IDC_MAIN_10                 = 2,
    STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE      = 3,
    STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS = 4,
    STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS          = 9,
    STD_VIDEO_H265_PROFILE_IDC_INVALID                 = 0x7FFFFFFF
}