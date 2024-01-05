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
///     VkBlendOverlapEXT - Enumerant specifying the blend overlap parameter -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendOverlapEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendOverlapEXT.html</a>
/// </summary>
public enum VkBlendOverlapEXT
{
    /// <summary>
    ///     VK_BLEND_OVERLAP_UNCORRELATED_EXT specifies that there is no correlation between the source and destination
    ///     coverage.
    /// </summary>
    VK_BLEND_OVERLAP_UNCORRELATED_EXT = 0,

    /// <summary>
    ///     VK_BLEND_OVERLAP_DISJOINT_EXT specifies that the source and destination coverage are considered to have
    ///     minimal overlap.
    /// </summary>
    VK_BLEND_OVERLAP_DISJOINT_EXT = 1,

    /// <summary>
    ///     VK_BLEND_OVERLAP_CONJOINT_EXT specifies that the source and destination coverage are considered to have
    ///     maximal overlap.
    /// </summary>
    VK_BLEND_OVERLAP_CONJOINT_EXT = 2
}