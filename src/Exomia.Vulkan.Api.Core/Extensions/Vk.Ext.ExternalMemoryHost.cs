#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtExternalMemoryHost
    {
        public const int    VK_EXT_EXTERNAL_MEMORY_HOST                = 1;
        public const int    VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION   = 1;
        public const string VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME = "VK_EXT_external_memory_host";

        public static delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            void*,                              /* pHostPointer */
            VkMemoryHostPointerPropertiesEXT*,  /* pMemoryHostPointerProperties */
            VkResult> vkGetMemoryHostPointerPropertiesEXT;

        public static partial void Load(VkDevice vkDevice);
    }

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