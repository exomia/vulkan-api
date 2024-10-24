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
///     VkIndirectCommandsLayoutUsageFlagBitsNV - Bitmask specifying allowed usage of an indirect commands layout -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutUsageFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkIndirectCommandsLayoutUsageFlagBitsNV
{
    /// <summary>
    ///     VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NVspecifies that the layout is always used with the
    ///     manual preprocessing step through calling
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html">
    ///         vkCmdPreprocessGeneratedCommandsNV
    ///     </a>
    ///     and executed by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html">
    ///         vkCmdExecuteGeneratedCommandsNV
    ///     </a>
    ///     with isPreprocessed set to VK_TRUE.
    /// </summary>
    VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV = 0x1,

    /// <summary>
    ///     VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVspecifies that the input data for the sequences is
    ///     not implicitly indexed from 0..sequencesUsed, but an application-provided VkBuffer encoding the index is provided.
    /// </summary>
    VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV = 0x2,

    /// <summary>
    ///     VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVspecifies that the processing of sequences can
    ///     happen at an implementation-dependent order, which is not guaranteed to be coherent using the same input data. This
    ///     flag is ignored when the pipelineBindPoint is VK_PIPELINE_BIND_POINT_COMPUTE as it is implied that the dispatch
    ///     sequence is always unordered.
    /// </summary>
    VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV = 0x4
}