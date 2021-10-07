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
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VKAmdMemoryOverallocationBehavior
    {
        public const int    VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR                = 1;
        public const int    VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION   = 1;
        public const string VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME = "VK_AMD_memory_overallocation_behavior";
        
    }

    public enum VkMemoryOverallocationBehaviorAMD
    {
        DEFAULT_AMD    = 0,
        ALLOWED_AMD    = 1,
        DISALLOWED_AMD = 2,
        MAX_ENUM_AMD   = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public const VkStructureType                   STYPE = VkStructureType.DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkMemoryOverallocationBehaviorAMD overallocationBehavior;
    }

}