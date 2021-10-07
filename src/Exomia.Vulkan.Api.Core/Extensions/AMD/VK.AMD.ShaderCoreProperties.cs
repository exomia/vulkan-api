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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VKAmdShaderCoreProperties
    {
        public const int    VK_AMD_SHADER_CORE_PROPERTIES                = 1;
        public const int    VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION   = 2;
        public const string VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME = "VK_AMD_shader_core_properties";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            shaderEngineCount;
        public       uint            shaderArraysPerEngineCount;
        public       uint            computeUnitsPerShaderArray;
        public       uint            simdPerComputeUnit;
        public       uint            wavefrontsPerSimd;
        public       uint            wavefrontSize;
        public       uint            sgprsPerSimd;
        public       uint            minSgprAllocation;
        public       uint            maxSgprAllocation;
        public       uint            sgprAllocationGranularity;
        public       uint            vgprsPerSimd;
        public       uint            minVgprAllocation;
        public       uint            maxVgprAllocation;
        public       uint            vgprAllocationGranularity;
    }
}