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
    public static unsafe partial class VKAmdShaderCoreProperties2
    {
        public const int    VK_AMD_SHADER_CORE_PROPERTIES2                = 1;
        public const int    VK_AMD_SHADER_CORE_PROPERTIES2_SPEC_VERSION   = 1;
        public const string VK_AMD_SHADER_CORE_PROPERTIES2_EXTENSION_NAME = "VK_AMD_shader_core_properties2";
    }


    [Flags]
    public enum VkShaderCorePropertiesFlagsAMD
    {
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public const VkStructureType                STYPE = VkStructureType.PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD;
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
        public       uint                           activeComputeUnitCount;
    }

}