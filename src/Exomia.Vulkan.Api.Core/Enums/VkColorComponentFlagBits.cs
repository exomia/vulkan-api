#region License

// Copyright (c) 2018-2023, exomia
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
///     VkColorComponentFlagBits - Bitmask controlling which components are written to the framebuffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorComponentFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorComponentFlagBits.html</a>
/// </summary>
[Flags]
public enum VkColorComponentFlagBits
{
    /// <summary>
    ///     VK_COLOR_COMPONENT_R_BIT specifies that the R value is written to the color attachment for the appropriate
    ///     sample. Otherwise, the value in memory is unmodified.
    /// </summary>
    VK_COLOR_COMPONENT_R_BIT = 0x1,

    /// <summary>
    ///     VK_COLOR_COMPONENT_G_BIT specifies that the G value is written to the color attachment for the appropriate
    ///     sample. Otherwise, the value in memory is unmodified.
    /// </summary>
    VK_COLOR_COMPONENT_G_BIT = 0x2,

    /// <summary>
    ///     VK_COLOR_COMPONENT_B_BIT specifies that the B value is written to the color attachment for the appropriate
    ///     sample. Otherwise, the value in memory is unmodified.
    /// </summary>
    VK_COLOR_COMPONENT_B_BIT = 0x4,

    /// <summary>
    ///     VK_COLOR_COMPONENT_A_BIT specifies that the A value is written to the color attachment for the appropriate
    ///     sample. Otherwise, the value in memory is unmodified.
    /// </summary>
    VK_COLOR_COMPONENT_A_BIT = 0x8
}