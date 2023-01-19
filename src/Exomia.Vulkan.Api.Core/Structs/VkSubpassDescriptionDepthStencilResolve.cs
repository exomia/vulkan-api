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
///     VkSubpassDescriptionDepthStencilResolve - Structure specifying depth/stencil resolve operations for a subpass -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionDepthStencilResolve.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionDepthStencilResolve.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubpassDescription2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubpassDescription2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>depthResolveMode is a VkResolveModeFlagBits value describing the depth resolve mode.</summary>
    public VkResolveModeFlagBits depthResolveMode;

    /// <summary>stencilResolveMode is a VkResolveModeFlagBits value describing the stencil resolve mode.</summary>
    public VkResolveModeFlagBits stencilResolveMode;

    /// <summary>
    ///     pDepthStencilResolveAttachment is NULL or a pointer to a VkAttachmentReference2 structure defining the
    ///     depth/stencil resolve attachment for this subpass and its layout.
    /// </summary>
    public VkAttachmentReference2* pDepthStencilResolveAttachment;
}