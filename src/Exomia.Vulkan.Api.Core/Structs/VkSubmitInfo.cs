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
    public unsafe struct VkSubmitInfo
    {
        public const VkStructureType          STYPE = VkStructureType.SUBMIT_INFO;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       uint                     waitSemaphoreCount;
        public       VkSemaphore*             pWaitSemaphores;
        public       VkPipelineStageFlagBits* pWaitDstStageMask;
        public       uint                     commandBufferCount;
        public       VkCommandBuffer*         pCommandBuffers;
        public       uint                     signalSemaphoreCount;
        public       VkSemaphore*             pSignalSemaphores;
    }
}