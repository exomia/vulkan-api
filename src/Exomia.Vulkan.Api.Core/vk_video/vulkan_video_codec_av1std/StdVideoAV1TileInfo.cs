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
public unsafe struct StdVideoAV1TileInfo
{
    public StdVideoAV1TileInfoFlags flags;

    public byte TileCols;

    public byte TileRows;

    public ushort context_update_tile_id;

    public byte tile_size_bytes_minus_1;

    public fixed byte reserved1[7];

    public ushort* pMiColStarts;

    public ushort* pMiRowStarts;

    public ushort* pWidthInSbsMinus1;

    public ushort* pHeightInSbsMinus1;
}