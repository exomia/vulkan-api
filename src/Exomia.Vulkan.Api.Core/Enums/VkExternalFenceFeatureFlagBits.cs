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
///     VkExternalFenceFeatureFlagBits - Bitfield describing features of an external fence handle type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceFeatureFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceFeatureFlagBits.html</a>
/// </summary>
[Flags]
public enum VkExternalFenceFeatureFlagBits
{
    /// <summary>
    ///     VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT specifies handles of this type can be exported from Vulkan fence
    ///     objects.
    /// </summary>
    VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = 0x1,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT specifies handles of this type can be imported to Vulkan fence
    ///     objects.
    /// </summary>
    VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = 0x2,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT specifies handles of this type can be exported from Vulkan fence
    ///     objects.
    /// </summary>
    VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT specifies handles of this type can be imported to Vulkan fence
    ///     objects.
    /// </summary>
    VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT
}