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
public struct StdVideoEncodeH264ReferenceInfo
{
    public StdVideoEncodeH264ReferenceInfoFlags flags;

    public uint FrameNum;

    public int PicOrderCnt;

    public ushort long_term_pic_num;

    public ushort long_term_frame_idx;
}