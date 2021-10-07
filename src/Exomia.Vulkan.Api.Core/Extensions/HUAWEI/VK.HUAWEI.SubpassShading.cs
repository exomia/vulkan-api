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
namespace Exomia.Vulkan.Api.Core.Extensions.HUAWEI
{
    [VkExtGenerator]
    public static unsafe partial class VKHuaweiSubpassShading
    {
        public const int    VK_HUAWEI_SUBPASS_SHADING                = 1;
        public const int    VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION   = 2;
        public const string VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME = "VK_HUAWEI_subpass_shading";
        
        public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    void> vkCmdSubpassShadingHUAWEI = null;



        public static partial void Load(VkDevice vkDevice);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public const VkStructureType STYPE = VkStructureType.SUBPASSS_SHADING_PIPELINE_CREATE_INFO_HUAWEI;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkRenderPass    renderPass;
        public       uint            subpass;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        subpassShading;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxSubpassShadingWorkgroupSizeAspectRatio;
    }




}