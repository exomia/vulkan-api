﻿#region License

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
    public unsafe struct VkDependencyInfoKHR
    {
        public const VkStructureType            STYPE = VkStructureType.DEPENDENCY_INFO_KHR;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkDependencyFlagBits       dependencyFlags;
        public       uint                       memoryBarrierCount;
        public       VkMemoryBarrier2KHR*       pMemoryBarriers;
        public       uint                       bufferMemoryBarrierCount;
        public       VkBufferMemoryBarrier2KHR* pBufferMemoryBarriers;
        public       uint                       imageMemoryBarrierCount;
        public       VkImageMemoryBarrier2KHR*  pImageMemoryBarriers;
    }
}