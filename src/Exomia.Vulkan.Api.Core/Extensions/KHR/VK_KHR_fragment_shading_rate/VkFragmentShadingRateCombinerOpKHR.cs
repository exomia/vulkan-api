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
///     VkFragmentShadingRateCombinerOpKHR - Control how fragment shading rates are combined -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateCombinerOpKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateCombinerOpKHR.html
///     </a>
/// </summary>
public enum VkFragmentShadingRateCombinerOpKHR
{
    /// <summary>VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR specifies a combiner operation of combine(Axy,Bxy) = Axy.</summary>
    VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR = 0,

    /// <summary>VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR specifies a combiner operation of combine(Axy,Bxy) = Bxy.</summary>
    VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR = 1,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR specifies a combiner operation of combine(Axy,Bxy) =
    ///     min(Axy,Bxy).
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR = 2,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR specifies a combiner operation of combine(Axy,Bxy) =
    ///     max(Axy,Bxy).
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR = 3,

    /// <summary>VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR specifies a combiner operation of combine(Axy,Bxy) = Axy*Bxy.</summary>
    VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR = 4
}