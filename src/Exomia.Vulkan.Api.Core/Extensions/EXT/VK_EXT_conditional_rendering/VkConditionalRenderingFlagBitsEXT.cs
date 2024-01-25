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
///     VkConditionalRenderingFlagBitsEXT - Specify the behavior of conditional rendering -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkConditionalRenderingFlagBitsEXT
{
    /// <summary>
    ///     VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT specifies the condition used to determine whether to discard
    ///     rendering commands or not. That is, if the 32-bit predicate read from buffer memory at offset is zero, the
    ///     rendering commands are not discarded, and if non zero, then they are discarded.
    /// </summary>
    VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = 0x1
}