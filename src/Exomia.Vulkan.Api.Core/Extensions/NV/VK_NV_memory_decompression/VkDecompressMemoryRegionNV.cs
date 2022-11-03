#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkDecompressMemoryRegionNV - Structure specifying decompression parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDecompressMemoryRegionNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDecompressMemoryRegionNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDecompressMemoryRegionNV
{
    /// <summary>srcAddress is the address where compressed data is stored.</summary>
    public VkDeviceAddress srcAddress;

    /// <summary>dstAddress is the destination address where decompressed data will be written.</summary>
    public VkDeviceAddress dstAddress;

    /// <summary>compressedSize is the size of compressed data in bytes.</summary>
    public VkDeviceSize compressedSize;

    /// <summary>decompressedSize is the size of decompressed data in bytes.</summary>
    public VkDeviceSize decompressedSize;

    /// <summary>
    ///     decompressionMethod is a single bit value from VkMemoryDecompressionMethodFlagBitsNV which specifies the
    ///     decompression method used to decompress data.
    /// </summary>
    public VkMemoryDecompressionMethodFlagsNV decompressionMethod;
}