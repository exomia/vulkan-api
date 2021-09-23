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
    public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        deviceMemoryReport;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceMemoryReportCallbackDataEXT
    {
        public const VkStructureType                  STYPE = VkStructureType.DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT;
        public       VkStructureType                  sType;
        public       void*                            pNext;
        public       VkDeviceMemoryReportFlagsEXT     flags;
        public       VkDeviceMemoryReportEventTypeEXT type;
        public       ulong                            memoryObjectId;
        public       VkDeviceSize                     size;
        public       VkObjectType                     objectType;
        public       ulong                            objectHandle;
        public       uint                             heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public const VkStructureType               STYPE = VkStructureType.DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkDeviceMemoryReportFlagsEXT  flags;
        public       DeviceMemoryReportCallbackEXT pfnUserCallback;
        public       void*                         pUserData;
    }
}
