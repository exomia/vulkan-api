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
public unsafe struct StdVideoDecodeH264ReferenceInfo
{
    public StdVideoDecodeH264ReferenceInfoFlags flags;

    public ushort FrameNum;

    public ushort reserved;

    public fixed int PicOrderCnt[(int)STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE];
}