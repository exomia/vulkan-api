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
    public static partial class VkExtMemoryBudget
    {
        public const int    VK_EXT_MEMORY_BUDGET                = 1;
        public const int    VK_EXT_MEMORY_BUDGET_SPEC_VERSION   = 1;
        public const string VK_EXT_MEMORY_BUDGET_EXTENSION_NAME = "VK_EXT_memory_budget";
    }

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