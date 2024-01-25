#region License

// Copyright (c) 2018-2024, exomia
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
public unsafe struct StdVideoDecodeH265PictureInfo
{
    public StdVideoDecodeH265PictureInfoFlags flags;

    public byte sps_video_parameter_set_id;

    public byte pps_seq_parameter_set_id;

    public byte pps_pic_parameter_set_id;

    public byte NumDeltaPocsOfRefRpsIdx;

    public int PicOrderCntVal;

    public ushort NumBitsForSTRefPicSetInSlice;

    public ushort reserved;

    public fixed byte RefPicSetStCurrBefore[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];

    public fixed byte RefPicSetStCurrAfter[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];

    public fixed byte RefPicSetLtCurr[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
}