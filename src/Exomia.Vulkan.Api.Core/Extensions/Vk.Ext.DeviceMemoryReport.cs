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
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtDeviceMemoryReport
    {
        public const int    VK_EXT_DEVICE_MEMORY_REPORT                = 1;
        public const int    VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION   = 2;
        public const string VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME = "VK_EXT_device_memory_report";
    }

    public unsafe delegate void DeviceMemoryReportCallbackEXT(
        VkDeviceMemoryReportCallbackDataEXT* pCallbackData,
        void*                                pUserData);

    public enum VkDeviceMemoryReportEventTypeEXT
    {
        ALLOCATE_EXT          = 0,
        FREE_EXT              = 1,
        IMPORT_EXT            = 2,
        UNIMPORT_EXT          = 3,
        ALLOCATION_FAILED_EXT = 4,
        MAX_ENUM_EXT          = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDeviceMemoryReportFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

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