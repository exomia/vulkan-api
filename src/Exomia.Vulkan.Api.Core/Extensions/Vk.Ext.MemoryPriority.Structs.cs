﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        memoryPriority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryPriorityAllocateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.MEMORY_PRIORITY_ALLOCATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       float           priority;
    }
}
