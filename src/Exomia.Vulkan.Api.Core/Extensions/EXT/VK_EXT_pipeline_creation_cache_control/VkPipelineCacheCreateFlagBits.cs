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
///     VkPipelineCacheCreateFlagBits - Bitmask specifying the behavior of the pipeline cache -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateFlagBits.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateFlagBits.html </a>
/// </summary>
[Flags]
public enum VkPipelineCacheCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT specifies that all commands that modify the created
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCache.html"> VkPipelineCache </a>
    ///     will be
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-threadingbehavior"> externally synchronized </a>
    ///     . When set, the implementation may skip any unnecessary processing needed to support simultaneous modification from multiple threads where allowed.
    /// </summary>
    VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = 0x1,

    /// <summary>
    ///     VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_PIPELINE_CACHE_CREATE_RESERVED_2_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_CACHE_CREATE_RESERVED_2_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT specifies that all commands that modify the created
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCache.html"> VkPipelineCache </a>
    ///     will be
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-threadingbehavior"> externally synchronized </a>
    ///     . When set, the implementation may skip any unnecessary processing needed to support simultaneous modification from multiple threads where allowed.
    /// </summary>
    VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT = VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT,

    /// <summary>
    ///     VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCacheCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_KHR = VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT
}