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
    public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxUpdateAfterBindDescriptorsInAllPools;
        public       VkBool32        shaderUniformBufferArrayNonUniformIndexingNative;
        public       VkBool32        shaderSampledImageArrayNonUniformIndexingNative;
        public       VkBool32        shaderStorageBufferArrayNonUniformIndexingNative;
        public       VkBool32        shaderStorageImageArrayNonUniformIndexingNative;
        public       VkBool32        shaderInputAttachmentArrayNonUniformIndexingNative;
        public       VkBool32        robustBufferAccessUpdateAfterBind;
        public       VkBool32        quadDivergentImplicitLod;
        public       uint            maxPerStageDescriptorUpdateAfterBindSamplers;
        public       uint            maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public       uint            maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public       uint            maxPerStageDescriptorUpdateAfterBindSampledImages;
        public       uint            maxPerStageDescriptorUpdateAfterBindStorageImages;
        public       uint            maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public       uint            maxPerStageUpdateAfterBindResources;
        public       uint            maxDescriptorSetUpdateAfterBindSamplers;
        public       uint            maxDescriptorSetUpdateAfterBindUniformBuffers;
        public       uint            maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public       uint            maxDescriptorSetUpdateAfterBindStorageBuffers;
        public       uint            maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public       uint            maxDescriptorSetUpdateAfterBindSampledImages;
        public       uint            maxDescriptorSetUpdateAfterBindStorageImages;
        public       uint            maxDescriptorSetUpdateAfterBindInputAttachments;
    }
}