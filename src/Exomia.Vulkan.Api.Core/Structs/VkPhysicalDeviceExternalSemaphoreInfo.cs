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
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public const VkStructureType                       STYPE = VkStructureType.PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO;
        public       VkStructureType                       sType;
        public       void*                                 pNext;
        public       VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
}