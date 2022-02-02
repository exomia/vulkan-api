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
///     VkAttachmentDescription2 - Structure specifying an attachment description -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescription2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescription2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescription2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkAttachmentDescriptionFlagBitsspecifying additional properties of the attachment.</summary>
    public VkAttachmentDescriptionFlags flags;

    /// <summary>format is a VkFormat value specifying the format of the image that will be used for the attachment.</summary>
    public VkFormat format;

    /// <summary>samples is a VkSampleCountFlagBits value specifying the number of samples of the image.</summary>
    public VkSampleCountFlagBits samples;

    /// <summary>
    ///     loadOp is a VkAttachmentLoadOp value specifying how the contents of color and depth components of the
    ///     attachment are treated at the beginning of the subpass where it is first used.
    /// </summary>
    public VkAttachmentLoadOp loadOp;

    /// <summary>
    ///     storeOp is a VkAttachmentStoreOp value specifying how the contents of color and depth components of the
    ///     attachment are treated at the end of the subpass where it is last used.
    /// </summary>
    public VkAttachmentStoreOp storeOp;

    /// <summary>
    ///     stencilLoadOp is a VkAttachmentLoadOp value specifying how the contents of stencil components of the
    ///     attachment are treated at the beginning of the subpass where it is first used.
    /// </summary>
    public VkAttachmentLoadOp stencilLoadOp;

    /// <summary>
    ///     stencilStoreOp is a VkAttachmentStoreOp value specifying how the contents of stencil components of the
    ///     attachment are treated at the end of the last subpass where it is used.
    /// </summary>
    public VkAttachmentStoreOp stencilStoreOp;

    /// <summary>initialLayout is the layout the attachment image subresource will be in when a render pass instance begins.</summary>
    public VkImageLayout initialLayout;

    /// <summary>
    ///     finalLayout is the layout the attachment image subresource will be transitioned to when a render pass instance
    ///     ends.
    /// </summary>
    public VkImageLayout finalLayout;
}