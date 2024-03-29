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
public unsafe struct StdVideoEncodeH265PictureInfo
{
    public StdVideoEncodeH265PictureInfoFlags flags;

    public StdVideoH265PictureType pic_type;

    public byte sps_video_parameter_set_id;

    public byte pps_seq_parameter_set_id;

    public byte pps_pic_parameter_set_id;

    public byte short_term_ref_pic_set_idx;

    public int PicOrderCntVal;

    public byte TemporalId;

    public fixed byte reserved1[7];

    public StdVideoEncodeH265ReferenceListsInfo* pRefLists;

    public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;

    public StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;
}