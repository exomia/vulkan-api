#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete(
        "Deprecated by VK_KHR_buffer_device_address extension - Which in turn was promoted to Vulkan 1.2", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_buffer_device_address.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VkExtBufferDeviceAddress
    {
        public const int    VK_EXT_BUFFER_DEVICE_ADDRESS                = 1;
        public const int    VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION   = 2;
        public const string VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = "VK_EXT_buffer_device_address";

        public static readonly delegate*<
            VkDevice,                      /* device */
            VkBufferDeviceAddressInfoEXT*, /* pInfo */
            VkDeviceAddress> vkGetBufferDeviceAddressEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferDeviceAddressCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkDeviceAddress deviceAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        bufferDeviceAddress;
        public       VkBool32        bufferDeviceAddressCaptureReplay;
        public       VkBool32        bufferDeviceAddressMultiDevice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferDeviceAddressInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.BUFFER_DEVICE_ADDRESS_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBuffer        buffer;
    }
}