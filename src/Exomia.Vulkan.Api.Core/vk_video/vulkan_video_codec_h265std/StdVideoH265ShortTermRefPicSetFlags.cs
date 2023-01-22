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
public struct StdVideoH265ShortTermRefPicSetFlags
{
    private uint _bitfield1;

    public uint inter_ref_pic_set_prediction_flag
    {
        get { return (uint)((_bitfield1 >> 0) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFE) | (((uint)value & 0x00000001) << 0); }
    }

    public uint delta_rps_sign
    {
        get { return (uint)((_bitfield1 >> 1) & 0x00000001); }
        set { _bitfield1 = (_bitfield1 & 0xFFFFFFFD) | (((uint)value & 0x00000001) << 1); }
    }
}