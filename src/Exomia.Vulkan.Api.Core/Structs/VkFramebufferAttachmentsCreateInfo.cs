#region License

// Copyright (c) 2018-2024, exomia
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
///     VkFramebufferAttachmentsCreateInfo - Structure specifying parameters of images that will be used with a
///     framebuffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentsCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentsCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkFramebufferCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkFramebufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>attachmentImageInfoCount is the number of attachments being described.</summary>
    public uint attachmentImageInfoCount;

    /// <summary>
    ///     pAttachmentImageInfos is a pointer to an array of VkFramebufferAttachmentImageInfo structures, each structure
    ///     describing a number of parameters of the corresponding attachment in a render pass instance.
    /// </summary>
    public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}