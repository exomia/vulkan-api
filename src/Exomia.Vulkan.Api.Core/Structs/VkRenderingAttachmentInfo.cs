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
///     VkRenderingAttachmentInfo - Structure specifying attachment information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentInfo.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAttachmentInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> imageView is the image view that will be used for rendering. </summary>
    public VkImageView imageView;

    /// <summary> imageLayout is the layout that imageView will be in during rendering. </summary>
    public VkImageLayout imageLayout;

    /// <summary> resolveMode is a VkResolveModeFlagBits value defining how multisampled data written to imageView will be resolved. </summary>
    public VkResolveModeFlagBits resolveMode;

    /// <summary> resolveImageView is an image view used to write resolved multisample data at the end of rendering. </summary>
    public VkImageView resolveImageView;

    /// <summary> resolveImageLayout is the layout that resolveImageView will be in during rendering. </summary>
    public VkImageLayout resolveImageLayout;

    /// <summary> loadOp is a VkAttachmentLoadOp value specifying how the contents of imageView are treated at the start of the render pass instance. </summary>
    public VkAttachmentLoadOp loadOp;

    /// <summary> storeOp is a VkAttachmentStoreOp value specifying how the contents of imageView are treated at the end of the render pass instance. </summary>
    public VkAttachmentStoreOp storeOp;

    /// <summary> clearValue is a VkClearValue structure defining values used to clear imageView when loadOp is VK_ATTACHMENT_LOAD_OP_CLEAR. </summary>
    public VkClearValue clearValue;
}