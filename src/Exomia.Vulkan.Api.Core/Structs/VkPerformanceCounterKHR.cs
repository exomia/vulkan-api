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
    public unsafe struct VkPerformanceCounterKHR
    {
        public const VkStructureType                STYPE = VkStructureType.PERFORMANCE_COUNTER_KHR;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkPerformanceCounterUnitKHR    unit;
        public       VkPerformanceCounterScopeKHR   scope;
        public       VkPerformanceCounterStorageKHR storage;
        public fixed byte                           uuid[(int)Vk.VK_UUID_SIZE];
    }
}