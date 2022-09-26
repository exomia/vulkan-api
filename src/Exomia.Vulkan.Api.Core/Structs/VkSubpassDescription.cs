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
///     VkSubpassDescription - Structure specifying a subpass description -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescription.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDescription.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription
{
    /// <summary> flags is a bitmask of VkSubpassDescriptionFlagBitsspecifying usage of the subpass. </summary>
    public VkSubpassDescriptionFlags flags;

    /// <summary> pipelineBindPoint is a VkPipelineBindPoint value specifying the pipeline type supported for this subpass. </summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary> inputAttachmentCount is the number of input attachments. </summary>
    public uint inputAttachmentCount;

    /// <summary> pInputAttachments is a pointer to an array of VkAttachmentReference structures defining the input attachments for this subpass and their layouts. </summary>
    public VkAttachmentReference* pInputAttachments;

    /// <summary> colorAttachmentCount is the number of color attachments. </summary>
    public uint colorAttachmentCount;

    /// <summary> pColorAttachments is a pointer to an array of colorAttachmentCount VkAttachmentReference structures defining the color attachments for this subpass and their layouts. </summary>
    public VkAttachmentReference* pColorAttachments;

    /// <summary> pResolveAttachments is NULL or a pointer to an array of colorAttachmentCount VkAttachmentReference structures defining the resolve attachments for this subpass and their layouts. </summary>
    public VkAttachmentReference* pResolveAttachments;

    /// <summary> pDepthStencilAttachment is a pointer to a VkAttachmentReference structure specifying the depth/stencil attachment for this subpass and its layout. </summary>
    public VkAttachmentReference* pDepthStencilAttachment;

    /// <summary> preserveAttachmentCount is the number of preserved attachments. </summary>
    public uint preserveAttachmentCount;

    /// <summary> pPreserveAttachments is a pointer to an array of preserveAttachmentCount render pass attachment indices identifying attachments that are not used by this subpass, but whose contents mustbe preserved throughout the subpass. </summary>
    public uint* pPreserveAttachments;
}