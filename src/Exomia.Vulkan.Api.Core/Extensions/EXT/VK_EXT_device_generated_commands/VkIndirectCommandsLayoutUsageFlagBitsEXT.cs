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
///     VkIndirectCommandsLayoutUsageFlagBitsEXT - Bitmask specifying allowed usage of an indirect commands layout -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagBitsEXT
{
    /// <summary>
    ///     VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_EXTspecifies that the layout is always used with the
    ///     manual preprocessing step through calling
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsEXT.html">
    ///         vkCmdPreprocessGeneratedCommandsEXT
    ///     </a>
    ///     and executed by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsEXT.html">
    ///         vkCmdExecuteGeneratedCommandsEXT
    ///     </a>
    ///     with isPreprocessed set to VK_TRUE.
    /// </summary>
    VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_EXTspecifies that the processing of sequences will
    ///     happen at an implementation-dependent order, which is not guaranteed to be deterministic using the same input data.
    ///     This flag is ignored when the shaderStages is VK_SHADER_STAGE_COMPUTE_BIT as it is implied that the dispatch
    ///     sequence is always unordered.
    /// </summary>
    VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_EXT = 0x2
}