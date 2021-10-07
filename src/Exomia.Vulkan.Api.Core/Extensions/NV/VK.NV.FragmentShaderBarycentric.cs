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
    [VkExtGenerator]
    public static unsafe partial class VKNvFragmentShaderBarycentric
    {
        public const int    VK_NV_FRAGMENT_SHADER_BARYCENTRIC                = 1;
        public const int    VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION   = 1;
        public const string VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME = "VK_NV_fragment_shader_barycentric";
        
       
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        fragmentShaderBarycentric;
    }




}