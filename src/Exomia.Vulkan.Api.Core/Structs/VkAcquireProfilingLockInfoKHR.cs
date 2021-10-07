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
    public unsafe struct VkAcquireProfilingLockInfoKHR
    {
        public const VkStructureType                STYPE = VkStructureType.ACQUIRE_PROFILING_LOCK_INFO_KHR;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkAcquireProfilingLockFlagsKHR flags;
        public       ulong                          timeout;
    }
}