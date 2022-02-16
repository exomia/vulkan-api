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
public unsafe struct StdVideoDecodeH265PictureInfo
{
    public byte vps_video_parameter_set_id;

    public byte sps_seq_parameter_set_id;

    public byte pps_pic_parameter_set_id;

    public byte num_short_term_ref_pic_sets;

    public int PicOrderCntVal;

    public ushort NumBitsForSTRefPicSetInSlice;

    public byte NumDeltaPocsOfRefRpsIdx;

    public fixed byte RefPicSetStCurrBefore[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];

    public fixed byte RefPicSetStCurrAfter[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];

    public fixed byte RefPicSetLtCurr[(int)STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];

    public StdVideoDecodeH265PictureInfoFlags flags;
}