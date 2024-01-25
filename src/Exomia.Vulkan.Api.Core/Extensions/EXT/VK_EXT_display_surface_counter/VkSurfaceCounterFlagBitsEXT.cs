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
///     VkSurfaceCounterFlagBitsEXT - Surface-relative counter types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceCounterFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceCounterFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkSurfaceCounterFlagBitsEXT
{
    /// <summary>
    ///     VK_SURFACE_COUNTER_VBLANK_BIT_EXT specifies a counter incrementing once every time a vertical blanking period
    ///     occurs on the display associated with the surface.
    /// </summary>
    VK_SURFACE_COUNTER_VBLANK_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_SURFACE_COUNTER_VBLANK_BIT_EXT specifies a counter incrementing once every time a vertical blanking period
    ///     occurs on the display associated with the surface.
    /// </summary>
    VK_SURFACE_COUNTER_VBLANK_EXT = VK_SURFACE_COUNTER_VBLANK_BIT_EXT
}