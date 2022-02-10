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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkImageConstraintsInfoFlagBitsFUCHSIA - Bitmask specifying image constraints flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFlagBitsFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFlagBitsFUCHSIA.html
///     </a>
/// </summary>
[Flags]
public enum VkImageConstraintsInfoFlagBitsFUCHSIA
{
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA = 0,

    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA = 1,

    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA = 2,

    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA = 3,

    /// <summary>
    ///     VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA specifies that protected memory is optional for the
    ///     buffer collection.
    /// </summary>
    VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA = 4
}