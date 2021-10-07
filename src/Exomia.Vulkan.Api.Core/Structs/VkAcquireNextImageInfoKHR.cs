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
    public unsafe struct VkAcquireNextImageInfoKHR
    {
        public const VkStructureType STYPE = VkStructureType.ACQUIRE_NEXT_IMAGE_INFO_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkSwapchainKHR  swapchain;
        public       ulong           timeout;
        public       VkSemaphore     semaphore;
        public       VkFence         fence;
        public       uint            deviceMask;
    }
}