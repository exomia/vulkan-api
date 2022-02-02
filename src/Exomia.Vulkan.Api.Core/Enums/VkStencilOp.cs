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
///     VkStencilOp - Stencil comparison function -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilOp.html</a>
/// </summary>
public enum VkStencilOp
{
    /// <summary>VK_STENCIL_OP_KEEP keeps the current value.</summary>
    VK_STENCIL_OP_KEEP = 0,

    /// <summary>VK_STENCIL_OP_ZERO sets the value to 0.</summary>
    VK_STENCIL_OP_ZERO = 1,

    /// <summary>VK_STENCIL_OP_REPLACE sets the value to reference.</summary>
    VK_STENCIL_OP_REPLACE = 2,

    /// <summary>
    ///     VK_STENCIL_OP_INCREMENT_AND_CLAMP increments the current value and clamps to the maximum representable
    ///     unsigned value.
    /// </summary>
    VK_STENCIL_OP_INCREMENT_AND_CLAMP = 3,

    /// <summary>VK_STENCIL_OP_DECREMENT_AND_CLAMP decrements the current value and clamps to 0.</summary>
    VK_STENCIL_OP_DECREMENT_AND_CLAMP = 4,

    /// <summary>VK_STENCIL_OP_INVERT bitwise-inverts the current value.</summary>
    VK_STENCIL_OP_INVERT = 5,

    /// <summary>
    ///     VK_STENCIL_OP_INCREMENT_AND_WRAP increments the current value and wraps to 0 when the maximum value would have
    ///     been exceeded.
    /// </summary>
    VK_STENCIL_OP_INCREMENT_AND_WRAP = 6,

    /// <summary>
    ///     VK_STENCIL_OP_DECREMENT_AND_WRAP decrements the current value and wraps to the maximum possible value when the
    ///     value would go below 0.
    /// </summary>
    VK_STENCIL_OP_DECREMENT_AND_WRAP = 7
}