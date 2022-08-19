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
///     VkPipelineShaderStageCreateFlagBits - Bitmask controlling how a pipeline shader stage is created -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkPipelineShaderStageCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BITspecifies that the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#interfaces-builtin-variables-sgs">
    ///         <code>SubgroupSize</code>
    ///     </a>
    ///     may vary in the shader stage.
    /// </summary>
    VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT = 0x1,

    /// <summary>
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BITspecifies that the subgroup sizes must be launched
    ///     with all invocations active in the compute stage.
    /// </summary>
    VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT = 0x2,

    /// <summary>
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_3_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineShaderStageCreateFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineShaderStageCreateFlagBits
    ///     </a>
    /// </summary>
    VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_3_BIT_KHR = 0x8,

    /// <summary>
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BITspecifies that the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#interfaces-builtin-variables-sgs">
    ///         <code>SubgroupSize</code>
    ///     </a>
    ///     may vary in the shader stage.
    /// </summary>
    VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT,

    /// <summary>
    ///     VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BITspecifies that the subgroup sizes must be launched
    ///     with all invocations active in the compute stage.
    /// </summary>
    VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT
}