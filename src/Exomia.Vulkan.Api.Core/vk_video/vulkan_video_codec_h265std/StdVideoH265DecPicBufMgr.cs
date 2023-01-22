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
public unsafe struct StdVideoH265DecPicBufMgr
{
    public fixed uint max_latency_increase_plus1[(int)STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];

    public fixed byte max_dec_pic_buffering_minus1[(int)STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];

    public fixed byte max_num_reorder_pics[(int)STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
}