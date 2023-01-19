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
///     VkAttachmentReference - Structure specifying an attachment reference -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAttachmentReference
{
    /// <summary>
    ///     attachment is either an integer value identifying an attachment at the corresponding index in
    ///     VkRenderPassCreateInfo::pAttachments, or VK_ATTACHMENT_UNUSED to signify that this attachment is not used.
    /// </summary>
    public uint attachment;

    /// <summary>layout is a VkImageLayout value specifying the layout the attachment uses during the subpass.</summary>
    public VkImageLayout layout;
}