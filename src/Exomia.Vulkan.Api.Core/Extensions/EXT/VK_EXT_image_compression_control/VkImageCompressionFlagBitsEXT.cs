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
///     VkImageCompressionFlagBitsEXT - Bitmask specifying image compression controls -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFlagBitsEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFlagBitsEXT.html </a>
/// </summary>
[Flags]
public enum VkImageCompressionFlagBitsEXT
{
    /// <summary> VK_IMAGE_COMPRESSION_DEFAULT_EXT specifies that the default image compression setting is used. Implementations must not apply fixed-rate compression. </summary>
    VK_IMAGE_COMPRESSION_DEFAULT_EXT = 0,

    /// <summary> VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT specifies that the implementation may choose any supported fixed-rate compression setting in an implementation-defined manner based on the properties of the image. </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT = 0x1,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT specifies that fixed-rate compression may be used and that the allowed compression rates are specified by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionControlEXT.html"> VkImageCompressionControlEXT </a>
    ///     ::pFixedRateFlags.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT = 0x2,

    /// <summary> VK_IMAGE_COMPRESSION_DISABLED_EXT specifies that all lossless and fixed-rate compression should be disabled. </summary>
    VK_IMAGE_COMPRESSION_DISABLED_EXT = 0x4
}