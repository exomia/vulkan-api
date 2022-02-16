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

public enum StdVideoDecodeH264FieldOrderCount
{
    STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_TOP     = 0,
    STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_BOTTOM  = 1,
    STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_INVALID = 0x7FFFFFFF
}