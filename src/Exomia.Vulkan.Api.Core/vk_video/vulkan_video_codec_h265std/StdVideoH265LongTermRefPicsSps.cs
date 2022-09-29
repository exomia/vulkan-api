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
public unsafe struct StdVideoH265LongTermRefPicsSps
{
    public uint used_by_curr_pic_lt_sps_flag;

    public fixed uint lt_ref_pic_poc_lsb_sps[(int)STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS];
}