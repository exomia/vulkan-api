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
///     VkIndirectCommandsInputModeFlagBitsEXT - Bitmask specifying allowed usage of an indirect commands layout -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsInputModeFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsInputModeFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkIndirectCommandsInputModeFlagBitsEXT
{
    /// <summary>
    ///     VK_INDIRECT_COMMANDS_INPUT_MODE_VULKAN_INDEX_BUFFER_EXT specifies that the indirect buffer contains
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindIndexBufferIndirectCommandEXT.html">
    ///         VkBindIndexBufferIndirectCommandEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_INDIRECT_COMMANDS_INPUT_MODE_VULKAN_INDEX_BUFFER_EXT = 0x1,

    /// <summary>
    ///     VK_INDIRECT_COMMANDS_INPUT_MODE_DXGI_INDEX_BUFFER_EXT specifies that the indirect buffer contains
    ///     D3D12_INDEX_BUFFER_VIEW.
    /// </summary>
    VK_INDIRECT_COMMANDS_INPUT_MODE_DXGI_INDEX_BUFFER_EXT = 0x2
}