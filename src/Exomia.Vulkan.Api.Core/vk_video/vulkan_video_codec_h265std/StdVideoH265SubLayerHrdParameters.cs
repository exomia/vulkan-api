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
public unsafe struct StdVideoH265SubLayerHrdParameters
{
    public fixed uint bit_rate_value_minus1[(int)STD_VIDEO_H265_CPB_CNT_LIST_SIZE];

    public fixed uint cpb_size_value_minus1[(int)STD_VIDEO_H265_CPB_CNT_LIST_SIZE];

    public fixed uint cpb_size_du_value_minus1[(int)STD_VIDEO_H265_CPB_CNT_LIST_SIZE];

    public fixed uint bit_rate_du_value_minus1[(int)STD_VIDEO_H265_CPB_CNT_LIST_SIZE];

    public uint cbr_flag;
}