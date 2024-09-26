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
///     VkDepthClampModeEXT - Modes that determine the depth clamp range -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthClampModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthClampModeEXT.html</a>
/// </summary>
public enum VkDepthClampModeEXT
{
    /// <summary>
    ///     VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT specifies that the depth clamp range follows the viewport depth range.
    ///     The depth clamp range of each viewport will implicitly be set to zmin = min(n,f) and zmax = max(n,f), where n and f
    ///     are the minDepth and maxDepth depth range values of the viewport.
    /// </summary>
    VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT = 0,

    /// <summary>
    ///     VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT specifies that a single user-defined depth clamp range will be used
    ///     for all viewports. The user-defined depth clamp range is defined by the minDepthClampand maxDepthClamp members of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthClampRangeEXT.html">VkDepthClampRangeEXT</a>
    ///     .
    /// </summary>
    VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT = 1
}