#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription2
{
    public const VkStructureType              STYPE = VkStructureType.SUBPASS_DESCRIPTION_2;
    public       VkStructureType              sType;
    public       void*                        pNext;
    public       VkSubpassDescriptionFlagBits flags;
    public       VkPipelineBindPoint          pipelineBindPoint;
    public       uint                         viewMask;
    public       uint                         inputAttachmentCount;
    public       VkAttachmentReference2*      pInputAttachments;
    public       uint                         colorAttachmentCount;
    public       VkAttachmentReference2*      pColorAttachments;
    public       VkAttachmentReference2*      pResolveAttachments;
    public       VkAttachmentReference2*      pDepthStencilAttachment;
    public       uint                         preserveAttachmentCount;
    public       uint*                        pPreserveAttachments;
}