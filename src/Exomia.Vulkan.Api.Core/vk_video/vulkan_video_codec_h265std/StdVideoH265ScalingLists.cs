#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct StdVideoH265ScalingLists
{
    public VkArray6<VkArray16<byte>> ScalingList4x4;

    public VkArray6<VkArray64<byte>> ScalingList8x8;

    public VkArray6<VkArray64<byte>> ScalingList16x16;

    public VkArray2<VkArray64<byte>> ScalingList32x32;

    public fixed byte ScalingListDCCoef16x16[(int)STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS];

    public fixed byte ScalingListDCCoef32x32[(int)STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS];
}