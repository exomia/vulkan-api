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
///     VkAttachmentReference2 - Structure specifying an attachment reference -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference2.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference2.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReference2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> attachment is either an integer value identifying an attachment at the corresponding index in VkRenderPassCreateInfo2::pAttachments, or VK_ATTACHMENT_UNUSED to signify that this attachment is not used. </summary>
    public uint attachment;

    /// <summary> layout is a VkImageLayout value specifying the layout the attachment uses during the subpass. </summary>
    public VkImageLayout layout;

    /// <summary> aspectMask is a mask of which aspect(s) can be accessed within the specified subpass as an input attachment. </summary>
    public VkImageAspectFlags aspectMask;
}