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
    public static unsafe partial class VKNvFragmentShadingRateEnums
    {
        public const int    VK_NV_FRAGMENT_SHADING_RATE_ENUMS                = 1;
        public const int    VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION   = 1;
        public const string VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME = "VK_NV_fragment_shading_rate_enums";
        
        public static readonly delegate*<
    VkCommandBuffer, /* commandBuffer */
    VkFragmentShadingRateNV, /* shadingRate */
    VkFragmentShadingRateCombinerOpKHR, /* combinerOps1 */
    VkFragmentShadingRateCombinerOpKHR, /* combinerOps2 */
    void> vkCmdSetFragmentShadingRateEnumNV = null;



        public static partial void Load(VkDevice vkDevice);
    }


    public enum VkFragmentShadingRateNV
    {
        _1_INVOCATION_PER_PIXEL_NV      = 0,
        _1_INVOCATION_PER_1X2_PIXELS_NV = 1,
        _1_INVOCATION_PER_2X1_PIXELS_NV = 4,
        _1_INVOCATION_PER_2X2_PIXELS_NV = 5,
        _1_INVOCATION_PER_2X4_PIXELS_NV = 6,
        _1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        _1_INVOCATION_PER_4X4_PIXELS_NV = 10,
        _2_INVOCATIONS_PER_PIXEL_NV     = 11,
        _4_INVOCATIONS_PER_PIXEL_NV     = 12,
        _8_INVOCATIONS_PER_PIXEL_NV     = 13,
        _16_INVOCATIONS_PER_PIXEL_NV    = 14,
        NO_INVOCATIONS_NV               = 15,
        MAX_ENUM_NV                     = 0x7FFFFFFF
    }


    public enum VkFragmentShadingRateTypeNV
    {
        FRAGMENT_SIZE_NV = 0,
        ENUMS_NV         = 1,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public const VkStructureType                    STYPE = VkStructureType.PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV;
        public       VkStructureType                    sType;
        public       void*                              pNext;
        public       VkFragmentShadingRateTypeNV        shadingRateType;
        public       VkFragmentShadingRateNV            shadingRate;
        public       VkFragmentShadingRateCombinerOpKHR combinerOps1;
        public       VkFragmentShadingRateCombinerOpKHR combinerOps2;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        fragmentShadingRateEnums;
        public       VkBool32        supersampleFragmentShadingRates;
        public       VkBool32        noInvocationFragmentShadingRates;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public const VkStructureType       STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkSampleCountFlagBits maxFragmentShadingRateInvocationCount;
    }




}