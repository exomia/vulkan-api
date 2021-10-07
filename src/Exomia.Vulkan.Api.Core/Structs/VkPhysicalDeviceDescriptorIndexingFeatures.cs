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
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        shaderInputAttachmentArrayDynamicIndexing;
        public       VkBool32        shaderUniformTexelBufferArrayDynamicIndexing;
        public       VkBool32        shaderStorageTexelBufferArrayDynamicIndexing;
        public       VkBool32        shaderUniformBufferArrayNonUniformIndexing;
        public       VkBool32        shaderSampledImageArrayNonUniformIndexing;
        public       VkBool32        shaderStorageBufferArrayNonUniformIndexing;
        public       VkBool32        shaderStorageImageArrayNonUniformIndexing;
        public       VkBool32        shaderInputAttachmentArrayNonUniformIndexing;
        public       VkBool32        shaderUniformTexelBufferArrayNonUniformIndexing;
        public       VkBool32        shaderStorageTexelBufferArrayNonUniformIndexing;
        public       VkBool32        descriptorBindingUniformBufferUpdateAfterBind;
        public       VkBool32        descriptorBindingSampledImageUpdateAfterBind;
        public       VkBool32        descriptorBindingStorageImageUpdateAfterBind;
        public       VkBool32        descriptorBindingStorageBufferUpdateAfterBind;
        public       VkBool32        descriptorBindingUniformTexelBufferUpdateAfterBind;
        public       VkBool32        descriptorBindingStorageTexelBufferUpdateAfterBind;
        public       VkBool32        descriptorBindingUpdateUnusedWhilePending;
        public       VkBool32        descriptorBindingPartiallyBound;
        public       VkBool32        descriptorBindingVariableDescriptorCount;
        public       VkBool32        runtimeDescriptorArray;
    }
}