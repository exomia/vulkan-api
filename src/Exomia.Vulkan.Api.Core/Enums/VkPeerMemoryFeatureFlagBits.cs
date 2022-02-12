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
///     VkPeerMemoryFeatureFlagBits - Bitmask specifying supported peer memory features -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPeerMemoryFeatureFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPeerMemoryFeatureFlagBits.html</a>
/// </summary>
[Flags]
public enum VkPeerMemoryFeatureFlagBits
{
    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT specifies that the memory canbe accessed as the source of any vkCmdCopy*
    ///     command.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = 0x1,

    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_COPY_DST_BIT specifies that the memory canbe accessed as the destination of any
    ///     vkCmdCopy* command.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = 0x2,

    /// <summary>VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT specifies that the memory can be read as any memory access type.</summary>
    VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = 0x4,

    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT specifies that the memory can be written as any memory access type.
    ///     Shader atomics are considered to be writes.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = 0x8,

    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT specifies that the memory canbe accessed as the source of any vkCmdCopy*
    ///     command.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT,

    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_COPY_DST_BIT specifies that the memory canbe accessed as the destination of any
    ///     vkCmdCopy* command.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_DST_BIT,

    /// <summary>VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT specifies that the memory can be read as any memory access type.</summary>
    VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT,

    /// <summary>
    ///     VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT specifies that the memory can be written as any memory access type.
    ///     Shader atomics are considered to be writes.
    /// </summary>
    VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT
}