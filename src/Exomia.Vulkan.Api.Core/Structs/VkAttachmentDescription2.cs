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
    public unsafe struct VkAttachmentDescription2
    {
        public const VkStructureType                 STYPE = VkStructureType.ATTACHMENT_DESCRIPTION_2;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       VkAttachmentDescriptionFlagBits flags;
        public       VkFormat                        format;
        public       VkSampleCountFlagBits           samples;
        public       VkAttachmentLoadOp              loadOp;
        public       VkAttachmentStoreOp             storeOp;
        public       VkAttachmentLoadOp              stencilLoadOp;
        public       VkAttachmentStoreOp             stencilStoreOp;
        public       VkImageLayout                   initialLayout;
        public       VkImageLayout                   finalLayout;
    }
}