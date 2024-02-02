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
public struct StdVideoAV1Quantization
{
    public StdVideoAV1QuantizationFlags flags;

    public byte base_q_idx;

    public sbyte DeltaQYDc;

    public sbyte DeltaQUDc;

    public sbyte DeltaQUAc;

    public sbyte DeltaQVDc;

    public sbyte DeltaQVAc;

    public byte qm_y;

    public byte qm_u;

    public byte qm_v;
}