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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_descriptor_indexing.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtDescriptorIndexing
    {
        public const int VK_EXT_DESCRIPTOR_INDEXING              = 1;
        public const int VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = 2;

        [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_descriptor_indexing.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME = "VK_EXT_descriptor_indexing";
    }

    [Flags]
    public enum VkDescriptorBindingFlagBitsEXT
    {
        UPDATE_AFTER_BIND_BIT               = 0x00000001,
        UPDATE_UNUSED_WHILE_PENDING_BIT     = 0x00000002,
        PARTIALLY_BOUND_BIT                 = 0x00000004,
        VARIABLE_DESCRIPTOR_COUNT_BIT       = 0x00000008,
        UPDATE_AFTER_BIND_BIT_EXT           = UPDATE_AFTER_BIND_BIT,
        UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = UPDATE_UNUSED_WHILE_PENDING_BIT,
        PARTIALLY_BOUND_BIT_EXT             = PARTIALLY_BOUND_BIT,
        VARIABLE_DESCRIPTOR_COUNT_BIT_EXT   = VARIABLE_DESCRIPTOR_COUNT_BIT,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
    {
        public const VkStructureType                 STYPE = VkStructureType.DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT;
        public       VkStructureType                 sType;
        public       void*                           pNext;
        public       uint                            bindingCount;
        public       VkDescriptorBindingFlagBitsEXT* pBindingFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT;
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

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT;
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

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            descriptorSetCount;
        public       uint*           pDescriptorCounts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
    {
        public const VkStructureType STYPE = VkStructureType.DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxVariableDescriptorCount;
    }
}