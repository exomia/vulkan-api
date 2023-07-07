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
///     VkRenderingInfo - Structure specifying render pass instance begin info -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderingInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDERING_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkRenderingFlagBits.</summary>
    public VkRenderingFlags flags;

    /// <summary>renderArea is the render area that is affected by the render pass instance.</summary>
    public VkRect2D renderArea;

    /// <summary>layerCount is the number of layers rendered to in each attachment when viewMask is 0.</summary>
    public uint layerCount;

    /// <summary>viewMask is the view mask indicating the indices of attachment layers that will be rendered when it is not 0.</summary>
    public uint viewMask;

    /// <summary>colorAttachmentCount is the number of elements in pColorAttachments.</summary>
    public uint colorAttachmentCount;

    /// <summary>
    ///     pColorAttachments is a pointer to an array of colorAttachmentCount VkRenderingAttachmentInfo structures
    ///     describing any color attachments used.
    /// </summary>
    public VkRenderingAttachmentInfo* pColorAttachments;

    /// <summary>pDepthAttachment is a pointer to a VkRenderingAttachmentInfostructure describing a depth attachment.</summary>
    public VkRenderingAttachmentInfo* pDepthAttachment;

    /// <summary>pStencilAttachment is a pointer to a VkRenderingAttachmentInfo structure describing a stencil attachment.</summary>
    public VkRenderingAttachmentInfo* pStencilAttachment;
}