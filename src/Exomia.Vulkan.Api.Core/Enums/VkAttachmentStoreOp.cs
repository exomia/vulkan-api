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
///     VkAttachmentStoreOp - Specify how contents of an attachment are treated at the end of a subpass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentStoreOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentStoreOp.html</a>
/// </summary>
public enum VkAttachmentStoreOp
{
    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_STORE specifies the contents generated during the render pass and within the render
    ///     area are written to memory. For attachments with a depth/stencil format, this uses the access type
    ///     VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT. For attachments with a color format, this uses the access type
    ///     VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_STORE = 0,

    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_DONT_CARE specifies the contents within the render area are not needed after rendering,
    ///     and may be discarded; the contents of the attachment will be undefined inside the render area. For attachments with
    ///     a depth/stencil format, this uses the access type VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT. For attachments
    ///     with a color format, this uses the access type VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_DONT_CARE = 1,

    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_NONE specifies the contents within the render area are not accessed by the store
    ///     operation. However, if the attachment was written to during the render pass, the contents of the attachment will be
    ///     undefined inside the render area.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_NONE = 1000301000,

    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_NONE specifies the contents within the render area are not accessed by the store
    ///     operation. However, if the attachment was written to during the render pass, the contents of the attachment will be
    ///     undefined inside the render area.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_NONE_KHR = VK_ATTACHMENT_STORE_OP_NONE,

    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_NONE specifies the contents within the render area are not accessed by the store
    ///     operation. However, if the attachment was written to during the render pass, the contents of the attachment will be
    ///     undefined inside the render area.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_NONE_QCOM = VK_ATTACHMENT_STORE_OP_NONE,

    /// <summary>
    ///     VK_ATTACHMENT_STORE_OP_NONE specifies the contents within the render area are not accessed by the store
    ///     operation. However, if the attachment was written to during the render pass, the contents of the attachment will be
    ///     undefined inside the render area.
    /// </summary>
    VK_ATTACHMENT_STORE_OP_NONE_EXT = VK_ATTACHMENT_STORE_OP_NONE
}