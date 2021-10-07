#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan12Features
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_VULKAN_1_2_FEATURES;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        samplerMirrorClampToEdge;
        public       VkBool32        drawIndirectCount;
        public       VkBool32        storageBuffer8BitAccess;
        public       VkBool32        uniformAndStorageBuffer8BitAccess;
        public       VkBool32        storagePushConstant8;
        public       VkBool32        shaderBufferInt64Atomics;
        public       VkBool32        shaderSharedInt64Atomics;
        public       VkBool32        shaderFloat16;
        public       VkBool32        shaderInt8;
        public       VkBool32        descriptorIndexing;
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
        public       VkBool32        samplerFilterMinmax;
        public       VkBool32        scalarBlockLayout;
        public       VkBool32        imagelessFramebuffer;
        public       VkBool32        uniformBufferStandardLayout;
        public       VkBool32        shaderSubgroupExtendedTypes;
        public       VkBool32        separateDepthStencilLayouts;
        public       VkBool32        hostQueryReset;
        public       VkBool32        timelineSemaphore;
        public       VkBool32        bufferDeviceAddress;
        public       VkBool32        bufferDeviceAddressCaptureReplay;
        public       VkBool32        bufferDeviceAddressMultiDevice;
        public       VkBool32        vulkanMemoryModel;
        public       VkBool32        vulkanMemoryModelDeviceScope;
        public       VkBool32        vulkanMemoryModelAvailabilityVisibilityChains;
        public       VkBool32        shaderOutputViewportIndex;
        public       VkBool32        shaderOutputLayer;
        public       VkBool32        subgroupBroadcastDynamicId;
    }
}