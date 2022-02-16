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
///     VkBlendOp - Framebuffer blending operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlendOp.html</a>
/// </summary>
public enum VkBlendOp
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Components</term>
    ///             <description>R = Rs0 × Sr +  Rd × Dr  G = Gs0 × Sg +  Gd × Dg  B = Bs0 × Sb +  Bd × Db</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Component</term><description>A = As0 × Sa +  Ad × Da</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_OP_ADD = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Components</term>
    ///             <description>R = Rs0 × Sr - Rd × Dr  G = Gs0 × Sg - Gd × Dg  B = Bs0 × Sb - Bd × Db</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Component</term><description>A = As0 × Sa - Ad × Da</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_OP_SUBTRACT = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Components</term>
    ///             <description>R = Rd × Dr - Rs0 × Sr  G = Gd × Dg - Gs0 × Sg  B = Bd × Db - Bs0 × Sb</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Component</term><description>A = Ad × Da - As0 × Sa</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_OP_REVERSE_SUBTRACT = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Components</term><description>R = min(Rs0,Rd)  G = min(Gs0,Gd)  B = min(Bs0,Bd)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Component</term><description>A = min(As0,Ad)</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_OP_MIN = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>RGB Components</term><description>R = max(Rs0,Rd)  G = max(Gs0,Gd)  B = max(Bs0,Bd)</description>
    ///         </item>
    ///         <item>
    ///             <term>Alpha Component</term><description>A = max(As0,Ad)</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_BLEND_OP_MAX = 4,

    /// <summary>
    ///     VK_BLEND_OP_ZERO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_ZERO_EXT = 1000148000,

    /// <summary>
    ///     VK_BLEND_OP_SRC_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SRC_EXT = 1000148001,

    /// <summary>
    ///     VK_BLEND_OP_DST_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DST_EXT = 1000148002,

    /// <summary>
    ///     VK_BLEND_OP_SRC_OVER_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SRC_OVER_EXT = 1000148003,

    /// <summary>
    ///     VK_BLEND_OP_DST_OVER_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DST_OVER_EXT = 1000148004,

    /// <summary>
    ///     VK_BLEND_OP_SRC_IN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SRC_IN_EXT = 1000148005,

    /// <summary>
    ///     VK_BLEND_OP_DST_IN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DST_IN_EXT = 1000148006,

    /// <summary>
    ///     VK_BLEND_OP_SRC_OUT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SRC_OUT_EXT = 1000148007,

    /// <summary>
    ///     VK_BLEND_OP_DST_OUT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DST_OUT_EXT = 1000148008,

    /// <summary>
    ///     VK_BLEND_OP_SRC_ATOP_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SRC_ATOP_EXT = 1000148009,

    /// <summary>
    ///     VK_BLEND_OP_DST_ATOP_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DST_ATOP_EXT = 1000148010,

    /// <summary>
    ///     VK_BLEND_OP_XOR_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_XOR_EXT = 1000148011,

    /// <summary>
    ///     VK_BLEND_OP_MULTIPLY_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_MULTIPLY_EXT = 1000148012,

    /// <summary>
    ///     VK_BLEND_OP_SCREEN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SCREEN_EXT = 1000148013,

    /// <summary>
    ///     VK_BLEND_OP_OVERLAY_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_OVERLAY_EXT = 1000148014,

    /// <summary>
    ///     VK_BLEND_OP_DARKEN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DARKEN_EXT = 1000148015,

    /// <summary>
    ///     VK_BLEND_OP_LIGHTEN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_LIGHTEN_EXT = 1000148016,

    /// <summary>
    ///     VK_BLEND_OP_COLORDODGE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_COLORDODGE_EXT = 1000148017,

    /// <summary>
    ///     VK_BLEND_OP_COLORBURN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_COLORBURN_EXT = 1000148018,

    /// <summary>
    ///     VK_BLEND_OP_HARDLIGHT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HARDLIGHT_EXT = 1000148019,

    /// <summary>
    ///     VK_BLEND_OP_SOFTLIGHT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_SOFTLIGHT_EXT = 1000148020,

    /// <summary>
    ///     VK_BLEND_OP_DIFFERENCE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_DIFFERENCE_EXT = 1000148021,

    /// <summary>
    ///     VK_BLEND_OP_EXCLUSION_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_EXCLUSION_EXT = 1000148022,

    /// <summary>
    ///     VK_BLEND_OP_INVERT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_INVERT_EXT = 1000148023,

    /// <summary>
    ///     VK_BLEND_OP_INVERT_RGB_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_INVERT_RGB_EXT = 1000148024,

    /// <summary>
    ///     VK_BLEND_OP_LINEARDODGE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_LINEARDODGE_EXT = 1000148025,

    /// <summary>
    ///     VK_BLEND_OP_LINEARBURN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_LINEARBURN_EXT = 1000148026,

    /// <summary>
    ///     VK_BLEND_OP_VIVIDLIGHT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_VIVIDLIGHT_EXT = 1000148027,

    /// <summary>
    ///     VK_BLEND_OP_LINEARLIGHT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_LINEARLIGHT_EXT = 1000148028,

    /// <summary>
    ///     VK_BLEND_OP_PINLIGHT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_PINLIGHT_EXT = 1000148029,

    /// <summary>
    ///     VK_BLEND_OP_HARDMIX_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HARDMIX_EXT = 1000148030,

    /// <summary>
    ///     VK_BLEND_OP_HSL_HUE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HSL_HUE_EXT = 1000148031,

    /// <summary>
    ///     VK_BLEND_OP_HSL_SATURATION_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HSL_SATURATION_EXT = 1000148032,

    /// <summary>
    ///     VK_BLEND_OP_HSL_COLOR_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HSL_COLOR_EXT = 1000148033,

    /// <summary>
    ///     VK_BLEND_OP_HSL_LUMINOSITY_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_HSL_LUMINOSITY_EXT = 1000148034,

    /// <summary>
    ///     VK_BLEND_OP_PLUS_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_PLUS_EXT = 1000148035,

    /// <summary>
    ///     VK_BLEND_OP_PLUS_CLAMPED_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_PLUS_CLAMPED_EXT = 1000148036,

    /// <summary>
    ///     VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT = 1000148037,

    /// <summary>
    ///     VK_BLEND_OP_PLUS_DARKER_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_PLUS_DARKER_EXT = 1000148038,

    /// <summary>
    ///     VK_BLEND_OP_MINUS_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_MINUS_EXT = 1000148039,

    /// <summary>
    ///     VK_BLEND_OP_MINUS_CLAMPED_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_MINUS_CLAMPED_EXT = 1000148040,

    /// <summary>
    ///     VK_BLEND_OP_CONTRAST_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_CONTRAST_EXT = 1000148041,

    /// <summary>
    ///     VK_BLEND_OP_INVERT_OVG_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_INVERT_OVG_EXT = 1000148042,

    /// <summary>
    ///     VK_BLEND_OP_RED_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_RED_EXT = 1000148043,

    /// <summary>
    ///     VK_BLEND_OP_GREEN_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_GREEN_EXT = 1000148044,

    /// <summary>
    ///     VK_BLEND_OP_BLUE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkBlendOp</a>
    /// </summary>
    VK_BLEND_OP_BLUE_EXT = 1000148045
}