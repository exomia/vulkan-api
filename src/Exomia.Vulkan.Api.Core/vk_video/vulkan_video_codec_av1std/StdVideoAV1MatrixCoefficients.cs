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

public enum StdVideoAV1MatrixCoefficients
{
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY    = 0,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709      = 1,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED = 2,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3  = 3,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC         = 4,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G  = 5,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601      = 6,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240   = 7,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO = 8,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL = 9,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL  = 10,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085  = 11,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL = 12,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL  = 13,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP       = 14,
    STD_VIDEO_AV1_MATRIX_COEFFICIENTS_INVALID     = 0x7FFFFFFF
}