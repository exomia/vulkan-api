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
    public unsafe struct VkImageMemoryBarrier2KHR
    {
        public const VkStructureType             STYPE = VkStructureType.IMAGE_MEMORY_BARRIER_2_KHR;
        public       VkStructureType             sType;
        public       void*                       pNext;
        public       VkPipelineStageFlagBits2KHR srcStageMask;
        public       VkAccessFlagBits2KHR        srcAccessMask;
        public       VkPipelineStageFlagBits2KHR dstStageMask;
        public       VkAccessFlagBits2KHR        dstAccessMask;
        public       VkImageLayout               oldLayout;
        public       VkImageLayout               newLayout;
        public       uint                        srcQueueFamilyIndex;
        public       uint                        dstQueueFamilyIndex;
        public       VkImage                     image;
        public       VkImageSubresourceRange     subresourceRange;
    }
}