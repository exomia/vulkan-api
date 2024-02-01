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

public enum StdVideoAV1ReferenceName
{
    STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME   = 0,
    STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME    = 1,
    STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME   = 2,
    STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME   = 3,
    STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME  = 4,
    STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME  = 5,
    STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME = 6,
    STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME  = 7,
    STD_VIDEO_AV1_REFERENCE_NAME_INVALID       = 0x7FFFFFFF
}