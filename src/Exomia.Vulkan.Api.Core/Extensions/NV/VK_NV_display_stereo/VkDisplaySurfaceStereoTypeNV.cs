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
///     VkDisplaySurfaceStereoTypeNV - 3D Stereo type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoTypeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoTypeNV.html</a>
/// </summary>
public enum VkDisplaySurfaceStereoTypeNV
{
    /// <summary>
    ///     VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV specifies no configuration for stereo presentation. This is the default
    ///     behavior if
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceStereoCreateInfoNV.html">
    ///         VkDisplaySurfaceStereoCreateInfoNV
    ///     </a>
    ///     is not provided.
    /// </summary>
    VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV = 0,

    /// <summary>
    ///     VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV specifies configuration for glasses that connect via a DIN
    ///     connector on the back of the graphics card.
    /// </summary>
    VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV = 1,

    /// <summary>
    ///     VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV specifies configuration for HDMI 3D compatible display devices with
    ///     their own stereo emitters. This is also known as HDMI Frame Packed Stereo, where the left and right eye images are
    ///     stacked into a single frame with a doubled pixel clock and refresh rate.
    /// </summary>
    VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV = 2,

    /// <summary>
    ///     VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV specifies configuration for DisplayPort display devices
    ///     with in-band stereo signaling and emitters.
    /// </summary>
    VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV = 3
}