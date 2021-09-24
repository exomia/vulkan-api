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
    public static partial class VkExtGlobalPriorityQuery
    {
        public const int    VK_EXT_GLOBAL_PRIORITY_QUERY                = 1;
        public const uint   VK_MAX_GLOBAL_PRIORITY_SIZE_EXT             = 16U;
        public const int    VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION   = 1;
        public const string VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME = "VK_EXT_global_priority_query";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        globalPriorityQuery;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
        public const VkStructureType                     STYPE = VkStructureType.QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT;
        public       VkStructureType                     sType;
        public       void*                               pNext;
        public       uint                                priorityCount;
        public       VkArray16<VkQueueGlobalPriorityEXT> priorities;
    }
}