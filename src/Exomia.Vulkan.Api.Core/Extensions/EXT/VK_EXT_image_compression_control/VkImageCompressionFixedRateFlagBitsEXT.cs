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
///     VkImageCompressionFixedRateFlagBitsEXT - Bitmask specifying fixed rate image compression rates -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFixedRateFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageCompressionFixedRateFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkImageCompressionFixedRateFlagBitsEXT
{
    /// <summary>VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT specifies that fixed-rate compression must not be used.</summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT = 0,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [1,2)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [2,3)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [3,4)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [4,5)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [5,6)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [6,7)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [7,8)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT = 0x40,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [8,9)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [9,10)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT = 0x100,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [10,11)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of [11,12)
    ///     bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT = 0x400,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT specifies that fixed-rate compression with a bitrate of at least
    ///     12 bits per component may be used.
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT = 0x2000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT = 0x4000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT = 0x8000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT = 0x10000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT = 0x20000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT = 0x40000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT = 0x80000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT = 0x100000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT = 0x200000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT = 0x400000,

    /// <summary>
    ///     VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageCompressionFixedRateFlagBitsEXT
    ///     </a>
    /// </summary>
    VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT = 0x800000
}