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
///     VkIndexType - Type of index buffer indices -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndexType.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndexType.html</a>
/// </summary>
public enum VkIndexType
{
    /// <summary>VK_INDEX_TYPE_UINT16 specifies that indices are 16-bit unsigned integer values.</summary>
    VK_INDEX_TYPE_UINT16 = 0,

    /// <summary>VK_INDEX_TYPE_UINT32 specifies that indices are 32-bit unsigned integer values.</summary>
    VK_INDEX_TYPE_UINT32 = 1,

    /// <summary>VK_INDEX_TYPE_NONE_KHR specifies that no indices are provided.</summary>
    VK_INDEX_TYPE_NONE_KHR = 1000165000,

    /// <summary>VK_INDEX_TYPE_UINT8_EXT specifies that indices are 8-bit unsigned integer values.</summary>
    VK_INDEX_TYPE_UINT8_EXT = 1000265000,

    /// <summary>VK_INDEX_TYPE_NONE_KHR specifies that no indices are provided.</summary>
    VK_INDEX_TYPE_NONE_NV = VK_INDEX_TYPE_NONE_KHR
}