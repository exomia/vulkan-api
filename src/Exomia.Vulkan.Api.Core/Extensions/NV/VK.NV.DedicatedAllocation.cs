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
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [Obsolete(
        "Deprecated by VK_KHR_dedicated_allocation extension - Which in turn was promoted to Vulkan 1.1", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_NV_dedicated_allocation.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VKNvDedicatedAllocation
    {
        public const int    VK_NV_DEDICATED_ALLOCATION                = 1;
        public const int    VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION   = 1;
        public const string VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME = "VK_NV_dedicated_allocation";
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        dedicatedAllocation;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        dedicatedAllocation;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkImage         image;
        public       VkBuffer        buffer;
    }




}