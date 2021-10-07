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
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static partial class VkAmdDeviceCoherentMemory
    {
        public const int    VK_AMD_DEVICE_COHERENT_MEMORY                = 1;
        public const int    VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION   = 1;
        public const string VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME = "VK_AMD_device_coherent_memory";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        deviceCoherentMemory;
    }
}