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
    public unsafe struct VkImportMemoryHostPointerInfoEXT
    {
        public const VkStructureType                    STYPE = VkStructureType.IMPORT_MEMORY_HOST_POINTER_INFO_EXT;
        public       VkStructureType                    sType;
        public       void*                              pNext;
        public       VkExternalMemoryHandleTypeFlagBits handleType;
        public       void*                              pHostPointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryHostPointerPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.MEMORY_HOST_POINTER_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkDeviceSize    minImportedHostPointerAlignment;
    }

}
