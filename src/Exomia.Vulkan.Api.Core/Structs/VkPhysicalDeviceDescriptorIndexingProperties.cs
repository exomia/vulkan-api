#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPhysicalDeviceDescriptorIndexingProperties - Structure describing descriptor indexing properties that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxUpdateAfterBindDescriptorsInAllPools is the maximum number of descriptors (summed over all descriptor
    ///     types) that can be created across all pools that are created with the
    ///     VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT bit set. Pool creation may fail when this limit is exceeded, or
    ///     when the space this limit represents is unable to satisfy a pool creation due to fragmentation.
    /// </summary>
    public uint maxUpdateAfterBindDescriptorsInAllPools;

    /// <summary>
    ///     shaderUniformBufferArrayNonUniformIndexingNative is a boolean value indicating whether uniform buffer
    ///     descriptors natively support nonuniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that nonuniformly indexes an array of uniform buffers mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderSampledImageArrayNonUniformIndexingNative is a boolean value indicating whether sampler and image
    ///     descriptors natively support nonuniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that nonuniformly indexes an array of samplers or images may execute multiple times in order to access
    ///     all the descriptors.
    /// </summary>
    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderStorageBufferArrayNonUniformIndexingNative is a boolean value indicating whether storage buffer
    ///     descriptors natively support nonuniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that nonuniformly indexes an array of storage buffers mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderStorageImageArrayNonUniformIndexingNative is a boolean value indicating whether storage image
    ///     descriptors natively support nonuniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that nonuniformly indexes an array of storage images mayexecute multiple times in order to access all
    ///     the descriptors.
    /// </summary>
    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;

    /// <summary>
    ///     shaderInputAttachmentArrayNonUniformIndexingNative is a boolean value indicating whether input attachment
    ///     descriptors natively support nonuniform indexing. If this is VK_FALSE, then a single dynamic instance of an
    ///     instruction that nonuniformly indexes an array of input attachments mayexecute multiple times in order to access
    ///     all the descriptors.
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;

    /// <summary>
    ///     robustBufferAccessUpdateAfterBind is a boolean value indicating whether robustBufferAccess canbe enabled on a
    ///     device simultaneously with descriptorBindingUniformBufferUpdateAfterBind,
    ///     descriptorBindingStorageBufferUpdateAfterBind, descriptorBindingUniformTexelBufferUpdateAfterBind, and/or
    ///     descriptorBindingStorageTexelBufferUpdateAfterBind. If this is VK_FALSE, then either robustBufferAccess must be
    ///     disabled or all of these update-after-bind features must be disabled.
    /// </summary>
    public VkBool32 robustBufferAccessUpdateAfterBind;

    /// <summary>
    ///     quadDivergentImplicitLod is a boolean value indicating whether implicit LOD calculations for image operations
    ///     have well-defined results when the image and/or sampler objects used for the instruction are not uniform within a
    ///     quad. See Derivative Image Operations.
    /// </summary>
    public VkBool32 quadDivergentImplicitLod;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindSamplers is similar to maxPerStageDescriptorSamplers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindUniformBuffers is similar to maxPerStageDescriptorUniformBuffers but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindStorageBuffers is similar to maxPerStageDescriptorStorageBuffers but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindSampledImages is similar to maxPerStageDescriptorSampledImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindStorageImages is similar to maxPerStageDescriptorStorageImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindInputAttachments is similar to maxPerStageDescriptorInputAttachments but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;

    /// <summary>
    ///     maxPerStageUpdateAfterBindResources is similar to maxPerStageResources but counts descriptors from descriptor
    ///     sets created with or without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageUpdateAfterBindResources;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindSamplers is similar to maxDescriptorSetSamplers but counts descriptors from
    ///     descriptor sets created with or without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindSamplers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindUniformBuffers is similar to maxDescriptorSetUniformBuffers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindUniformBuffersDynamic is similar to maxDescriptorSetUniformBuffersDynamic but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set. While an application can allocate dynamic
    ///     uniform buffer descriptors from a pool created with the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///     bindings for these descriptors must not be present in any descriptor set layout that includes bindings created with
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageBuffers is similar to maxDescriptorSetStorageBuffers but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageBuffersDynamic is similar to maxDescriptorSetStorageBuffersDynamic but
    ///     counts descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set. While an application can allocate dynamic
    ///     storage buffer descriptors from a pool created with the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///     bindings for these descriptors must not be present in any descriptor set layout that includes bindings created with
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindSampledImages is similar to maxDescriptorSetSampledImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindSampledImages;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindStorageImages is similar to maxDescriptorSetStorageImages but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindStorageImages;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindInputAttachments is similar to maxDescriptorSetInputAttachments but counts
    ///     descriptors from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}