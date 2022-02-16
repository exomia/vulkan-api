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
///     VkClearAttachment - Structure specifying a clear attachment -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearAttachment.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkClearAttachment.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkClearAttachment
{
    /// <summary>aspectMask is a mask selecting the color, depth and/or stencil aspects of the attachment to be cleared.</summary>
    public VkImageAspectFlags aspectMask;

    /// <summary>
    ///     colorAttachment is only meaningful if VK_IMAGE_ASPECT_COLOR_BIT is set in aspectMask, in which case it is an
    ///     index into the currently bound color attachments.
    /// </summary>
    public uint colorAttachment;

    /// <summary>clearValue is the color or depth/stencil value to clear the attachment to, as described in Clear Values below.</summary>
    public VkClearValue clearValue;
}