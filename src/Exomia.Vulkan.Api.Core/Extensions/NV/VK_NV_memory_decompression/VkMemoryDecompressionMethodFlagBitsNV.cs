#region License

// Copyright (c) 2018-2024, exomia
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
///     VkMemoryDecompressionMethodFlagBitsNV - List the supported memory decompression methods -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDecompressionMethodFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDecompressionMethodFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkMemoryDecompressionMethodFlagBitsNV : ulong
{
    /// <summary>
    ///     VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV specifies that the GDeflate 1.0 algorithm is used to
    ///     decompress data.
    /// </summary>
    VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV = 0x1
}