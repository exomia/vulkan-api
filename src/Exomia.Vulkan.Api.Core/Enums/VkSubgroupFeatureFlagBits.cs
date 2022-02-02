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
    VK_SUBGROUP_FEATURE_BASIC_BIT = 0,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_VOTE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_VOTE_BIT = 1,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_ARITHMETIC_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 2,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_BALLOT_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_BALLOT_BIT = 3,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_SHUFFLE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 4,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 5,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_CLUSTERED_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 6,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_QUAD_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_QUAD_BIT = 7,

    /// <summary>
    ///     VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSubgroupFeatureFlagBits</a>
    /// </summary>
    VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 8
}