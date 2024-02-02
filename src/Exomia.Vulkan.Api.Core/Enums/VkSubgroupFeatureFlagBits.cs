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
///     VkSubgroupFeatureFlagBits - Bitmask describing what group operations are supported with subgroup scope -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubgroupFeatureFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubgroupFeatureFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSubgroupFeatureFlagBits
{
    /// <summary>
    ///     VK_SUBGROUP_FEATURE_BASIC_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_BASIC_BIT = 0x1,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_VOTE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_VOTE_BIT = 0x2,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_ARITHMETIC_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 0x4,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_BALLOT_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_BALLOT_BIT = 0x8,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_SHUFFLE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 0x10,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 0x20,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_CLUSTERED_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 0x40,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_QUAD_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_QUAD_BIT = 0x80,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x100,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR = 0x200,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR = 0x400
}