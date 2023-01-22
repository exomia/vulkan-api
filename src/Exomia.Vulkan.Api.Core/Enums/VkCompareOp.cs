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
///     VkCompareOp - Comparison operator for depth, stencil, and sampler operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCompareOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCompareOp.html</a>
/// </summary>
public enum VkCompareOp
{
    /// <summary>VK_COMPARE_OP_NEVER specifies that the comparison always evaluates false.</summary>
    VK_COMPARE_OP_NEVER = 0,

    /// <summary>VK_COMPARE_OP_LESS specifies that the comparison evaluates reference &lt; test.</summary>
    VK_COMPARE_OP_LESS = 1,

    /// <summary>VK_COMPARE_OP_EQUAL specifies that the comparison evaluates reference = test.</summary>
    VK_COMPARE_OP_EQUAL = 2,

    /// <summary>VK_COMPARE_OP_LESS_OR_EQUAL specifies that the comparison evaluates reference ≤ test.</summary>
    VK_COMPARE_OP_LESS_OR_EQUAL = 3,

    /// <summary>VK_COMPARE_OP_GREATER specifies that the comparison evaluates reference &gt; test.</summary>
    VK_COMPARE_OP_GREATER = 4,

    /// <summary>VK_COMPARE_OP_NOT_EQUAL specifies that the comparison evaluates reference ≠ test.</summary>
    VK_COMPARE_OP_NOT_EQUAL = 5,

    /// <summary>VK_COMPARE_OP_GREATER_OR_EQUAL specifies that the comparison evaluates reference ≥ test.</summary>
    VK_COMPARE_OP_GREATER_OR_EQUAL = 6,

    /// <summary>VK_COMPARE_OP_ALWAYS specifies that the comparison always evaluates true.</summary>
    VK_COMPARE_OP_ALWAYS = 7
}