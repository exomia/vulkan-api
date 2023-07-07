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
///     VkAttachmentLoadOp - Specify how contents of an attachment are initialized at the beginning of a subpass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentLoadOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentLoadOp.html</a>
/// </summary>
public enum VkAttachmentLoadOp
{
    /// <summary>
    ///     VK_ATTACHMENT_LOAD_OP_LOAD specifies that the previous contents of the image within the render area will be
    ///     preserved as the initial values. For attachments with a depth/stencil format, this uses the access type
    ///     VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT. For attachments with a color format, this uses the access type
    ///     VK_ACCESS_COLOR_ATTACHMENT_READ_BIT.
    /// </summary>
    VK_ATTACHMENT_LOAD_OP_LOAD = 0,

    /// <summary>
    ///     VK_ATTACHMENT_LOAD_OP_CLEAR specifies that the contents within the render area will be cleared to a uniform
    ///     value, which is specified when a render pass instance is begun. For attachments with a depth/stencil format, this
    ///     uses the access type VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT. For attachments with a color format, this uses
    ///     the access type VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.
    /// </summary>
    VK_ATTACHMENT_LOAD_OP_CLEAR = 1,

    /// <summary>
    ///     VK_ATTACHMENT_LOAD_OP_DONT_CARE specifies that the previous contents within the area need not be preserved;
    ///     the contents of the attachment will be undefined inside the render area. For attachments with a depth/stencil
    ///     format, this uses the access type VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT. For attachments with a color
    ///     format, this uses the access type VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.
    /// </summary>
    VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,

    /// <summary>
    ///     VK_ATTACHMENT_LOAD_OP_NONE_EXT specifies that the previous contents of the image will be undefined inside the
    ///     render pass. No access type is used as the image is not accessed.
    /// </summary>
    VK_ATTACHMENT_LOAD_OP_NONE_EXT = 1000400000
}