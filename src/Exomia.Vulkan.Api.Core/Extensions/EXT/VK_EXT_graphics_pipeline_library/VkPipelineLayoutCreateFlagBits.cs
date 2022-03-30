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
///     VkPipelineLayoutCreateFlagBits - Pipeline layout creation flag bits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkPipelineLayoutCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_LAYOUT_CREATE_RESERVED_0_BIT_AMD<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineLayoutCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineLayoutCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_LAYOUT_CREATE_RESERVED_0_BIT_AMD = 0x1,

    /// <summary>
    ///     VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineLayoutCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineLayoutCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = 0x2
}