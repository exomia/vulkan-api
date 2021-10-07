#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlagBits flags;
        public VkPipelineBindPoint          pipelineBindPoint;
        public uint                         inputAttachmentCount;
        public VkAttachmentReference*       pInputAttachments;
        public uint                         colorAttachmentCount;
        public VkAttachmentReference*       pColorAttachments;
        public VkAttachmentReference*       pResolveAttachments;
        public VkAttachmentReference*       pDepthStencilAttachment;
        public uint                         preserveAttachmentCount;
        public uint*                        pPreserveAttachments;
    }
}