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
///     VkExternalMemoryFeatureFlagBits - Bitmask specifying features of an external memory handle type -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalMemoryFeatureFlagBits
{
    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT specifies that images or buffers created with the specified
    ///     parameters and handle type must use the mechanisms defined by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedRequirements.html">VkMemoryDedicatedRequirements</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedAllocateInfo.html">VkMemoryDedicatedAllocateInfo</a>
    ///     to create (or import) a dedicated allocation for the image or buffer.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = 0x1,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT specifies that handles of this type can be exported from Vulkan
    ///     memory objects.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = 0x2,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT specifies that handles of this type can be imported as Vulkan memory
    ///     objects.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = 0x4,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT specifies that images or buffers created with the specified
    ///     parameters and handle type must use the mechanisms defined by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedRequirements.html">VkMemoryDedicatedRequirements</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedAllocateInfo.html">VkMemoryDedicatedAllocateInfo</a>
    ///     to create (or import) a dedicated allocation for the image or buffer.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT specifies that handles of this type can be exported from Vulkan
    ///     memory objects.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT specifies that handles of this type can be imported as Vulkan memory
    ///     objects.
    /// </summary>
    VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT
}