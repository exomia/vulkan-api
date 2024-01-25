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
public unsafe struct StdVideoEncodeH264PictureInfo
{
    public StdVideoEncodeH264PictureInfoFlags flags;

    public byte seq_parameter_set_id;

    public byte pic_parameter_set_id;

    public ushort idr_pic_id;

    public StdVideoH264PictureType primary_pic_type;

    public uint frame_num;

    public int PicOrderCnt;

    public byte temporal_id;

    public VkArray3<byte> reserved1;

    public StdVideoEncodeH264ReferenceListsInfo* pRefLists;
}