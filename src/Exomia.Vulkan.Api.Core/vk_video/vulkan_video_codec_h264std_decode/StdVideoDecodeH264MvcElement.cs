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
public unsafe struct StdVideoDecodeH264MvcElement
{
    public StdVideoDecodeH264MvcElementFlags flags;

    public ushort viewOrderIndex;

    public ushort viewId;

    public ushort temporalId;

    public ushort priorityId;

    public ushort numOfAnchorRefsInL0;

    public fixed ushort viewIdOfAnchorRefsInL0[(int)STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];

    public ushort numOfAnchorRefsInL1;

    public fixed ushort viewIdOfAnchorRefsInL1[(int)STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];

    public ushort numOfNonAnchorRefsInL0;

    public fixed ushort viewIdOfNonAnchorRefsInL0[(int)STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];

    public ushort numOfNonAnchorRefsInL1;

    public fixed ushort viewIdOfNonAnchorRefsInL1[(int)STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE];
}