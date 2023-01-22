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
///     VkAttachmentReferenceStencilLayout - Structure specifying an attachment description -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReferenceStencilLayout.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentReferenceStencilLayout.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAttachmentReference2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAttachmentReference2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReferenceStencilLayout
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stencilLayout is a VkImageLayout value specifying the layout the stencil aspect of the attachment uses during
    ///     the subpass.
    /// </summary>
    public VkImageLayout stencilLayout;
}