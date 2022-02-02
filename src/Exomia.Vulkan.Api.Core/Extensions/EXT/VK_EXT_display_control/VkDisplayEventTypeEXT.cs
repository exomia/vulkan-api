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
///     VkDisplayEventTypeEXT - Events that can occur on a display object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayEventTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayEventTypeEXT.html</a>
/// </summary>
public enum VkDisplayEventTypeEXT
{
    /// <summary>
    ///     VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT specifies that the fence is signaled when the first pixel of the
    ///     next display refresh cycle leaves the display engine for the display.
    /// </summary>
    VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT = 0
}