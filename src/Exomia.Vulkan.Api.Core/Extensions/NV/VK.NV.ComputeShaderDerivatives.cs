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
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static partial class VKNvComputeShaderDerivatives
    {
        public const int    VK_NV_COMPUTE_SHADER_DERIVATIVES                = 1;
        public const int    VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION   = 1;
        public const string VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME = "VK_NV_compute_shader_derivatives";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        computeDerivativeGroupQuads;
        public       VkBool32        computeDerivativeGroupLinear;
    }
}