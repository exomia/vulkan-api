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
        "Deprecated by VK_KHR_external_memory extension - Which in turn was promoted to Vulkan 1.1", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_NV_external_memory.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkNvExternalMemory
    {
        public const int    VK_NV_EXTERNAL_MEMORY                = 1;
        public const int    VK_NV_EXTERNAL_MEMORY_SPEC_VERSION   = 1;
        public const string VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_NV_external_memory";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalMemoryImageCreateInfoNV
    {
        public const VkStructureType                   STYPE = VkStructureType.EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExportMemoryAllocateInfoNV
    {
        public const VkStructureType                   STYPE = VkStructureType.EXPORT_MEMORY_ALLOCATE_INFO_NV;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }
}