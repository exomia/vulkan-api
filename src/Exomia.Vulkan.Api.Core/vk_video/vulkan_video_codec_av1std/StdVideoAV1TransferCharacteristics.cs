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

public enum StdVideoAV1TransferCharacteristics
{
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0     = 0,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709         = 1,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED    = 2,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3     = 3,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M       = 4,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G     = 5,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601         = 6,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240      = 7,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR         = 8,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100        = 9,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10 = 10,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966      = 11,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361        = 12,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB           = 13,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT = 14,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT = 15,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084     = 16,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428      = 17,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG            = 18,
    STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_INVALID        = 0x7FFFFFFF
}