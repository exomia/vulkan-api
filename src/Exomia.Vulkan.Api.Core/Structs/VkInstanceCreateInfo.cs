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
    public unsafe struct VkInstanceCreateInfo
    {
        public const VkStructureType          STYPE = VkStructureType.INSTANCE_CREATE_INFO;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkInstanceCreateFlagBits flags;
        public       VkApplicationInfo*       pApplicationInfo;
        public       uint                     enabledLayerCount;
        public       sbyte**                  ppEnabledLayerNames;
        public       uint                     enabledExtensionCount;
        public       sbyte**                  ppEnabledExtensionNames;
    }
}