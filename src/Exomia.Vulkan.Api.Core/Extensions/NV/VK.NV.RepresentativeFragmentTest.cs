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
    public static unsafe partial class VKNvRepresentativeFragmentTest
    {
        public const int    VK_NV_REPRESENTATIVE_FRAGMENT_TEST                = 1;
        public const int    VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION   = 2;
        public const string VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME = "VK_NV_representative_fragment_test";
        
        

        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        representativeFragmentTestEnable;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        representativeFragmentTest;
    }




}