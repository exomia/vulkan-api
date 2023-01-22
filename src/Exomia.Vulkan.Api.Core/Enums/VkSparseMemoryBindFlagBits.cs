#region License

// Copyright (c) 2018-2023, exomia
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
///     VkSparseMemoryBindFlagBits - Bitmask specifying usage of a sparse memory binding operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBindFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBindFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSparseMemoryBindFlagBits
{
    /// <summary>VK_SPARSE_MEMORY_BIND_METADATA_BIT specifies that the memory being bound is only for the metadata aspect.</summary>
    VK_SPARSE_MEMORY_BIND_METADATA_BIT = 0x1
}