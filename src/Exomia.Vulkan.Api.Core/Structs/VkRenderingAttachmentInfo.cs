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
///     VkRenderingAttachmentInfo - Structure specifying attachment information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAttachmentInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>imageView is the image view that will be used for rendering.</summary>
    public VkImageView imageView;

    /// <summary>imageLayout is the layout that imageView will be in during rendering.</summary>
    public VkImageLayout imageLayout;

    /// <summary>
    ///     resolveMode is a VkResolveModeFlagBits value defining how data written to imageView will be resolved into
    ///     resolveImageView.
    /// </summary>
    public VkResolveModeFlagBits resolveMode;

    /// <summary>resolveImageView is an image view used to write resolved data at the end of rendering.</summary>
    public VkImageView resolveImageView;

    /// <summary>resolveImageLayout is the layout that resolveImageView will be in during rendering.</summary>
    public VkImageLayout resolveImageLayout;

    /// <summary>loadOp is a VkAttachmentLoadOp value defining the load operation for the attachment.</summary>
    public VkAttachmentLoadOp loadOp;

    /// <summary>storeOp is a VkAttachmentStoreOp value defining the store operation for the attachment.</summary>
    public VkAttachmentStoreOp storeOp;

    /// <summary>
    ///     clearValue is a VkClearValue structure defining values used to clear imageView when loadOp is
    ///     VK_ATTACHMENT_LOAD_OP_CLEAR.
    /// </summary>
    public VkClearValue clearValue;
}