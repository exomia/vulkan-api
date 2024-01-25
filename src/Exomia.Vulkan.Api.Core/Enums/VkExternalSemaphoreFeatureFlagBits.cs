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
///     VkExternalSemaphoreFeatureFlagBits - Bitfield describing features of an external semaphore handle type -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreFeatureFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreFeatureFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalSemaphoreFeatureFlagBits
{
    /// <summary>
    ///     VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT specifies that handles of this type can be exported from Vulkan
    ///     semaphore objects.
    /// </summary>
    VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = 0x1,

    /// <summary>
    ///     VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT specifies that handles of this type can be imported as Vulkan
    ///     semaphore objects.
    /// </summary>
    VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = 0x2,

    /// <summary>
    ///     VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT specifies that handles of this type can be exported from Vulkan
    ///     semaphore objects.
    /// </summary>
    VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT,

    /// <summary>
    ///     VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT specifies that handles of this type can be imported as Vulkan
    ///     semaphore objects.
    /// </summary>
    VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT
}