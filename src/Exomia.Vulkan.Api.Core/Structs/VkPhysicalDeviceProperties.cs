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
    public unsafe struct VkPhysicalDeviceProperties
    {
        public       VkVersion                        apiVersion;
        public       uint                             driverVersion;
        public       uint                             vendorID;
        public       uint                             deviceID;
        public       VkPhysicalDeviceType             deviceType;
        public fixed sbyte                            deviceName[(int)Vk.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
        public fixed byte                             pipelineCacheUUID[(int)Vk.VK_UUID_SIZE];
        public       VkPhysicalDeviceLimits           limits;
        public       VkPhysicalDeviceSparseProperties sparseProperties;
    }
}