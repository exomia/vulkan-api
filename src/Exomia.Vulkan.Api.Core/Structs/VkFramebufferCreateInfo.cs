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
///     VkFramebufferCreateInfo - Structure specifying parameters of a newly created framebuffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkFramebufferCreateFlagBits</summary>
    public VkFramebufferCreateFlags flags;

    /// <summary>
    ///     renderPass is a render pass defining what render passes the framebuffer will be compatible with. See Render
    ///     Pass Compatibility for details.
    /// </summary>
    public VkRenderPass renderPass;

    /// <summary>attachmentCount is the number of attachments.</summary>
    public uint attachmentCount;

    /// <summary>
    ///     pAttachments is a pointer to an array of VkImageViewhandles, each of which will be used as the corresponding
    ///     attachment in a render pass instance. If flags includes VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT, this parameter is
    ///     ignored.
    /// </summary>
    public VkImageView* pAttachments;

    /// <summary>
    ///     width, height and layers define the dimensions of the framebuffer. If the render pass uses multiview, then
    ///     layers must be one and each attachment requires a number of layers that is greater than the maximum bit index set
    ///     in the view mask in the subpasses in which it is used.
    /// </summary>
    public uint width;

    /// <summary>
    ///     width, height and layers define the dimensions of the framebuffer. If the render pass uses multiview, then
    ///     layers must be one and each attachment requires a number of layers that is greater than the maximum bit index set
    ///     in the view mask in the subpasses in which it is used.
    /// </summary>
    public uint height;

    /// <summary>
    ///     width, height and layers define the dimensions of the framebuffer. If the render pass uses multiview, then
    ///     layers must be one and each attachment requires a number of layers that is greater than the maximum bit index set
    ///     in the view mask in the subpasses in which it is used.
    /// </summary>
    public uint layers;
}