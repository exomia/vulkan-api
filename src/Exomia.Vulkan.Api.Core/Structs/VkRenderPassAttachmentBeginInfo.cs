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
///     VkRenderPassAttachmentBeginInfo - Structure specifying images to be used as framebuffer attachments -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassAttachmentBeginInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassAttachmentBeginInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassBeginInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassBeginInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassAttachmentBeginInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>attachmentCount is the number of attachments.</summary>
    public uint attachmentCount;

    /// <summary>
    ///     pAttachments is a pointer to an array of VkImageViewhandles, each of which will be used as the corresponding
    ///     attachment in the render pass instance.
    /// </summary>
    public VkImageView* pAttachments;
}