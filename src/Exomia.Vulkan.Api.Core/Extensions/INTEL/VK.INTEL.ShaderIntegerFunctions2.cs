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
namespace Exomia.Vulkan.Api.Core.Extensions.INTEL
{
    [VkExtGenerator]
    public static unsafe partial class VKIntelShaderIntegerFunctions2
    {
        public const int    VK_INTEL_SHADER_INTEGER_FUNCTIONS2                = 1;
        public const int    VK_INTEL_SHADER_INTEGER_FUNCTIONS2_SPEC_VERSION   = 1;
        public const string VK_INTEL_SHADER_INTEGER_FUNCTIONS2_EXTENSION_NAME = "VK_INTEL_shader_integer_functions2";
        
        

        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        shaderIntegerFunctions2;
    }




}