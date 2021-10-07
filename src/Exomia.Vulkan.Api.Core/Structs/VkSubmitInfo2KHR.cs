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
    public unsafe struct VkSubmitInfo2KHR
    {
        public const VkStructureType               STYPE = VkStructureType.SUBMIT_INFO_2_KHR;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkSubmitFlagsKHR              flags;
        public       uint                          waitSemaphoreInfoCount;
        public       VkSemaphoreSubmitInfoKHR*     pWaitSemaphoreInfos;
        public       uint                          commandBufferInfoCount;
        public       VkCommandBufferSubmitInfoKHR* pCommandBufferInfos;
        public       uint                          signalSemaphoreInfoCount;
        public       VkSemaphoreSubmitInfoKHR*     pSignalSemaphoreInfos;
    }
}