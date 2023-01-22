#region License

// Copyright (c) 2018-2023, exomia
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
public unsafe struct StdVideoEncodeH264WeightTable
{
    public StdVideoEncodeH264WeightTableFlags flags;

    public byte luma_log2_weight_denom;

    public byte chroma_log2_weight_denom;

    public fixed sbyte luma_weight_l0[(int)STD_VIDEO_H264_MAX_NUM_LIST_REF];

    public fixed sbyte luma_offset_l0[(int)STD_VIDEO_H264_MAX_NUM_LIST_REF];

    public VkArray32<VkArray2<sbyte>> chroma_weight_l0;

    public VkArray32<VkArray2<sbyte>> chroma_offset_l0;

    public fixed sbyte luma_weight_l1[(int)STD_VIDEO_H264_MAX_NUM_LIST_REF];

    public fixed sbyte luma_offset_l1[(int)STD_VIDEO_H264_MAX_NUM_LIST_REF];

    public VkArray32<VkArray2<sbyte>> chroma_weight_l1;

    public VkArray32<VkArray2<sbyte>> chroma_offset_l1;
}