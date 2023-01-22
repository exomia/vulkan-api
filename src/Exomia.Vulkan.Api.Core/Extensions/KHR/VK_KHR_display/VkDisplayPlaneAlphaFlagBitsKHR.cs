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
///     VkDisplayPlaneAlphaFlagBitsKHR - Alpha blending type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneAlphaFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneAlphaFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkDisplayPlaneAlphaFlagBitsKHR
{
    /// <summary>VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR specifies that the source image will be treated as opaque.</summary>
    VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR specifies that a global alpha value must be specified that will be
    ///     applied to all pixels in the source image.
    /// </summary>
    VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR specifies that the alpha value will be determined by the alpha
    ///     component of the source image&#8217;s pixels. If the source format contains no alpha values, no blending will be
    ///     applied. The source alpha values are not premultiplied into the source image&#8217;s other color components.
    /// </summary>
    VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR is equivalent to
    ///     VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR, except the source alpha values are assumed to be premultiplied into the
    ///     source image&#8217;s other color components.
    /// </summary>
    VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = 0x8
}