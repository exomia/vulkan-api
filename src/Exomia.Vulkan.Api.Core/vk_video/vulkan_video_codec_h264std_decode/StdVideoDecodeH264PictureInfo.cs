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
public unsafe struct StdVideoDecodeH264PictureInfo
{
    public StdVideoDecodeH264PictureInfoFlags flags;

    public byte seq_parameter_set_id;

    public byte pic_parameter_set_id;

    public byte reserved1;

    public byte reserved2;

    public ushort frame_num;

    public ushort idr_pic_id;

    public fixed int PicOrderCnt[(int)STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE];
}