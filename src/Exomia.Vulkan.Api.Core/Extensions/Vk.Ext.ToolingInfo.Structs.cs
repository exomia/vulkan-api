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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public fixed sbyte                 name[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
        public fixed sbyte                 version[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
        public       VkToolPurposeFlagsEXT purposes;
        public fixed sbyte                 description[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                 layer[(int)Vk.VK_MAX_EXTENSION_NAME_SIZE];
    }
}
