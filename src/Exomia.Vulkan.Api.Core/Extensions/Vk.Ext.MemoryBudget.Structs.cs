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
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public const VkStructureType         STYPE = VkStructureType.PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       VkArray16<VkDeviceSize> heapBudget;
        public       VkArray16<VkDeviceSize> heapUsage;
    }
}
