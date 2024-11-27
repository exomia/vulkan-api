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
///     VkBuildMicromapFlagBitsEXT - Bitmask specifying additional parameters for micromap builds -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkBuildMicromapFlagBitsEXT
{
    /// <summary>
    ///     VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT specifies that the given micromap build should prioritize trace
    ///     performance over build time.
    /// </summary>
    VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT specifies that the given micromap build should prioritize build
    ///     time over trace performance.
    /// </summary>
    VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBuildMicromapFlagBitsEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBuildMicromapFlagBitsEXT</a>
    /// </summary>
    VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = 0x4
}