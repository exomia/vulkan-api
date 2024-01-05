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
///     VkRenderPassCreateInfo2 - Structure specifying parameters of a newly created render pass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreateInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkRenderPassCreateFlags flags;

    /// <summary>attachmentCount is the number of attachments used by this render pass.</summary>
    public uint attachmentCount;

    /// <summary>
    ///     pAttachments is a pointer to an array of attachmentCountVkAttachmentDescription2 structures describing the
    ///     attachments used by the render pass.
    /// </summary>
    public VkAttachmentDescription2* pAttachments;

    /// <summary>subpassCount is the number of subpasses to create.</summary>
    public uint subpassCount;

    /// <summary>pSubpasses is a pointer to an array of subpassCountVkSubpassDescription2 structures describing each subpass.</summary>
    public VkSubpassDescription2* pSubpasses;

    /// <summary>dependencyCount is the number of dependencies between pairs of subpasses.</summary>
    public uint dependencyCount;

    /// <summary>
    ///     pDependencies is a pointer to an array of dependencyCountVkSubpassDependency2 structures describing
    ///     dependencies between pairs of subpasses.
    /// </summary>
    public VkSubpassDependency2* pDependencies;

    /// <summary>correlatedViewMaskCount is the number of correlation masks.</summary>
    public uint correlatedViewMaskCount;

    /// <summary>
    ///     pCorrelatedViewMasks is a pointer to an array of view masks indicating sets of views that may be more
    ///     efficient to render concurrently.
    /// </summary>
    public uint* pCorrelatedViewMasks;
}