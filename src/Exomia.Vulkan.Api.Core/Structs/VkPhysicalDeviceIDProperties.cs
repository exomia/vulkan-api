#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ID_PROPERTIES;
        public       VkStructureType sType;
        public       void*           pNext;
        public fixed byte            deviceUUID[(int)Vk.VK_UUID_SIZE];
        public fixed byte            driverUUID[(int)Vk.VK_UUID_SIZE];
        public fixed byte            deviceLUID[(int)Vk.VK_LUID_SIZE];
        public       uint            deviceNodeMask;
        public       VkBool32        deviceLUIDValid;
    }
}