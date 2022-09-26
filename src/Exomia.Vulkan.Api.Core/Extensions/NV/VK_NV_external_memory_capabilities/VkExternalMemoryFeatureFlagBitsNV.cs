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
///     VkExternalMemoryFeatureFlagBitsNV - Bitmask specifying external memory features -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalMemoryFeatureFlagBitsNV
{
    /// <summary> VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV specifies that external memory of the specified type must be created as a dedicated allocation when used in the manner specified. </summary>
    VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = 0x1,

    /// <summary> VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV specifies that the implementation supports exporting handles of the specified type. </summary>
    VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = 0x2,

    /// <summary> VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV specifies that the implementation supports importing handles of the specified type. </summary>
    VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = 0x4
}