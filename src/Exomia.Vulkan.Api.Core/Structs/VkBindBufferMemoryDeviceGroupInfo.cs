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
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo
    {
        public const VkStructureType STYPE = VkStructureType.BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            deviceIndexCount;
        public       uint*           pDeviceIndices;
    }
}