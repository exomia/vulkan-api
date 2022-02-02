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
///     VkDisplayPowerStateEXT - Possible power states for a display -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPowerStateEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPowerStateEXT.html</a>
/// </summary>
public enum VkDisplayPowerStateEXT
{
    /// <summary>VK_DISPLAY_POWER_STATE_OFF_EXT specifies that the display is powered down.</summary>
    VK_DISPLAY_POWER_STATE_OFF_EXT = 0,

    /// <summary>
    ///     VK_DISPLAY_POWER_STATE_SUSPEND_EXT specifies that the display is put into a low power mode, from which it may
    ///     be able to transition back to VK_DISPLAY_POWER_STATE_ON_EXT more quickly than if it were in
    ///     VK_DISPLAY_POWER_STATE_OFF_EXT. This state may be the same as VK_DISPLAY_POWER_STATE_OFF_EXT.
    /// </summary>
    VK_DISPLAY_POWER_STATE_SUSPEND_EXT = 1,

    /// <summary>VK_DISPLAY_POWER_STATE_ON_EXT specifies that the display is powered on.</summary>
    VK_DISPLAY_POWER_STATE_ON_EXT = 2
}