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
    public unsafe struct VkDeviceQueueCreateInfo
    {
        public const VkStructureType             STYPE = VkStructureType.DEVICE_QUEUE_CREATE_INFO;
        public       VkStructureType             sType;
        public       void*                       pNext;
        public       VkDeviceQueueCreateFlagBits flags;
        public       uint                        queueFamilyIndex;
        public       uint                        queueCount;
        public       float*                      pQueuePriorities;
    }
}