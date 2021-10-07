#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public const VkStructureType                   STYPE = VkStructureType.PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES;
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkDriverId                        driverID;
        public fixed sbyte                             driverName[(int)Vk.VK_MAX_DRIVER_NAME_SIZE];
        public fixed sbyte                             driverInfo[(int)Vk.VK_MAX_DRIVER_INFO_SIZE];
        public       VkConformanceVersion              conformanceVersion;
        public       VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public       VkShaderFloatControlsIndependence roundingModeIndependence;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat16;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat32;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat64;
        public       VkBool32                          shaderDenormPreserveFloat16;
        public       VkBool32                          shaderDenormPreserveFloat32;
        public       VkBool32                          shaderDenormPreserveFloat64;
        public       VkBool32                          shaderDenormFlushToZeroFloat16;
        public       VkBool32                          shaderDenormFlushToZeroFloat32;
        public       VkBool32                          shaderDenormFlushToZeroFloat64;
        public       VkBool32                          shaderRoundingModeRTEFloat16;
        public       VkBool32                          shaderRoundingModeRTEFloat32;
        public       VkBool32                          shaderRoundingModeRTEFloat64;
        public       VkBool32                          shaderRoundingModeRTZFloat16;
        public       VkBool32                          shaderRoundingModeRTZFloat32;
        public       VkBool32                          shaderRoundingModeRTZFloat64;
        public       uint                              maxUpdateAfterBindDescriptorsInAllPools;
        public       VkBool32                          shaderUniformBufferArrayNonUniformIndexingNative;
        public       VkBool32                          shaderSampledImageArrayNonUniformIndexingNative;
        public       VkBool32                          shaderStorageBufferArrayNonUniformIndexingNative;
        public       VkBool32                          shaderStorageImageArrayNonUniformIndexingNative;
        public       VkBool32                          shaderInputAttachmentArrayNonUniformIndexingNative;
        public       VkBool32                          robustBufferAccessUpdateAfterBind;
        public       VkBool32                          quadDivergentImplicitLod;
        public       uint                              maxPerStageDescriptorUpdateAfterBindSamplers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindSampledImages;
        public       uint                              maxPerStageDescriptorUpdateAfterBindStorageImages;
        public       uint                              maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public       uint                              maxPerStageUpdateAfterBindResources;
        public       uint                              maxDescriptorSetUpdateAfterBindSamplers;
        public       uint                              maxDescriptorSetUpdateAfterBindUniformBuffers;
        public       uint                              maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageBuffers;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public       uint                              maxDescriptorSetUpdateAfterBindSampledImages;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageImages;
        public       uint                              maxDescriptorSetUpdateAfterBindInputAttachments;
        public       VkResolveModeFlagBits             supportedDepthResolveModes;
        public       VkResolveModeFlagBits             supportedStencilResolveModes;
        public       VkBool32                          independentResolveNone;
        public       VkBool32                          independentResolve;
        public       VkBool32                          filterMinmaxSingleComponentFormats;
        public       VkBool32                          filterMinmaxImageComponentMapping;
        public       ulong                             maxTimelineSemaphoreValueDifference;
        public       VkSampleCountFlagBits             framebufferIntegerColorSampleCounts;
    }
}