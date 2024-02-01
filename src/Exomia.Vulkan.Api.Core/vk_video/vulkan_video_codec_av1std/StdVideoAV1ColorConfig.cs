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
public struct StdVideoAV1ColorConfig
{
    public StdVideoAV1ColorConfigFlags flags;

    public byte BitDepth;

    public byte subsampling_x;

    public byte subsampling_y;

    public byte reserved1;

    public StdVideoAV1ColorPrimaries color_primaries;

    public StdVideoAV1TransferCharacteristics transfer_characteristics;

    public StdVideoAV1MatrixCoefficients matrix_coefficients;

    public StdVideoAV1ChromaSamplePosition chroma_sample_position;
}