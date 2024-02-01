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
public unsafe struct StdVideoDecodeAV1ReferenceInfo
{
    public StdVideoDecodeAV1ReferenceInfoFlags flags;

    public byte frame_type;

    public byte RefFrameSignBias;

    public byte OrderHint;

    public fixed byte SavedOrderHints[(int)STD_VIDEO_AV1_NUM_REF_FRAMES];
}