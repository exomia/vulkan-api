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
///     VkAttachmentDescriptionStencilLayout - Structure specifying an attachment description -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionStencilLayout.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionStencilLayout.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAttachmentDescription2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAttachmentDescription2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentDescriptionStencilLayout
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stencilInitialLayout is the layout the stencil aspect of the attachment image subresource will be in when a
    ///     render pass instance begins.
    /// </summary>
    public VkImageLayout stencilInitialLayout;

    /// <summary>
    ///     stencilFinalLayout is the layout the stencil aspect of the attachment image subresource will be transitioned
    ///     to when a render pass instance ends.
    /// </summary>
    public VkImageLayout stencilFinalLayout;
}