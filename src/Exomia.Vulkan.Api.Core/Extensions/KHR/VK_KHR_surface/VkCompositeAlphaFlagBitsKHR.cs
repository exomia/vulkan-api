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
///     VkCompositeAlphaFlagBitsKHR - Alpha compositing modes supported on a device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCompositeAlphaFlagBitsKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCompositeAlphaFlagBitsKHR.html </a>
/// </summary>
[Flags]
public enum VkCompositeAlphaFlagBitsKHR
{
    /// <summary> VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR: The alpha component, if it exists, of the images is ignored in the compositing process. Instead, the image is treated as if it has a constant alpha of 1.0. </summary>
    VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = 0x1,

    /// <summary> VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR: The alpha component, if it exists, of the images is respected in the compositing process. The non-alpha components of the image are expected to already be multiplied by the alpha component by the application. </summary>
    VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = 0x2,

    /// <summary> VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR: The alpha component, if it exists, of the images is respected in the compositing process. The non-alpha components of the image are not expected to already be multiplied by the alpha component by the application; instead, the compositor will multiply the non-alpha components of the image by the alpha component during compositing. </summary>
    VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = 0x4,

    /// <summary> VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR: The way in which the presentation engine treats the alpha component in the images is unknown to the Vulkan API. Instead, the application is responsible for setting the composite alpha blending mode using native window system commands. If the application does not set the blending mode using native window system commands, then a platform-specific default will be used. </summary>
    VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = 0x8
}