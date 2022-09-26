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
///     VkColorSpaceKHR - Supported color space of the presentation engine -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorSpaceKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkColorSpaceKHR.html </a>
/// </summary>
public enum VkColorSpaceKHR
{
    /// <summary> VK_COLOR_SPACE_SRGB_NONLINEAR_KHR specifies support for the sRGB color space. </summary>
    VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = 0,

    /// <summary> VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT specifies support for the Display-P3 color space to be displayed using an sRGB-like EOTF (defined below). </summary>
    VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = 1000104001,

    /// <summary> VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT specifies support for the extended sRGB color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = 1000104002,

    /// <summary> VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT specifies support for the Display-P3 color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT = 1000104003,

    /// <summary> VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT specifies support for the DCI-P3 color space to be displayed using the DCI-P3 EOTF. Note that values in such an image are interpreted as XYZ encoded color data by the presentation engine. </summary>
    VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = 1000104004,

    /// <summary> VK_COLOR_SPACE_BT709_LINEAR_EXT specifies support for the BT709 color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_BT709_LINEAR_EXT = 1000104005,

    /// <summary> VK_COLOR_SPACE_BT709_NONLINEAR_EXT specifies support for the BT709 color space to be displayed using the SMPTE 170M EOTF. </summary>
    VK_COLOR_SPACE_BT709_NONLINEAR_EXT = 1000104006,

    /// <summary> VK_COLOR_SPACE_BT2020_LINEAR_EXT specifies support for the BT2020 color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_BT2020_LINEAR_EXT = 1000104007,

    /// <summary> VK_COLOR_SPACE_HDR10_ST2084_EXT specifies support for the HDR10 (BT2020 color) space to be displayed using the SMPTE ST2084 Perceptual Quantizer (PQ) EOTF. </summary>
    VK_COLOR_SPACE_HDR10_ST2084_EXT = 1000104008,

    /// <summary> VK_COLOR_SPACE_DOLBYVISION_EXT specifies support for the Dolby Vision (BT2020 color space), proprietary encoding, to be displayed using the SMPTE ST2084 EOTF. </summary>
    VK_COLOR_SPACE_DOLBYVISION_EXT = 1000104009,

    /// <summary> VK_COLOR_SPACE_HDR10_HLG_EXT specifies support for the HDR10 (BT2020 color space) to be displayed using the Hybrid Log Gamma (HLG) EOTF. </summary>
    VK_COLOR_SPACE_HDR10_HLG_EXT = 1000104010,

    /// <summary> VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT specifies support for the AdobeRGB color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = 1000104011,

    /// <summary> VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT specifies support for the AdobeRGB color space to be displayed using the Gamma 2.2 EOTF. </summary>
    VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = 1000104012,

    /// <summary> VK_COLOR_SPACE_PASS_THROUGH_EXT specifies that color components are used &#8220;as is&#8221;. This is intended to allow applications to supply data for color spaces not described here. </summary>
    VK_COLOR_SPACE_PASS_THROUGH_EXT = 1000104013,

    /// <summary> VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT specifies support for the extended sRGB color space to be displayed using an sRGB EOTF. </summary>
    VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,

    /// <summary> VK_COLOR_SPACE_DISPLAY_NATIVE_AMD specifies support for the display&#8217;s native color space. This matches the color space expectations of AMD&#8217;s FreeSync2 standard, for displays supporting it. </summary>
    VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = 1000213000,

    /// <summary> VK_COLOR_SPACE_SRGB_NONLINEAR_KHR specifies support for the sRGB color space. </summary>
    VK_COLORSPACE_SRGB_NONLINEAR_KHR = VK_COLOR_SPACE_SRGB_NONLINEAR_KHR,

    /// <summary> VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT specifies support for the Display-P3 color space to be displayed using a linear EOTF. </summary>
    VK_COLOR_SPACE_DCI_P3_LINEAR_EXT = VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT
}