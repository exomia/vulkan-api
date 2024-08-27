#region License

// Copyright (c) 2018-2024, exomia
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
///     VkPhysicalDeviceDescriptorIndexingFeatures - Structure describing descriptor indexing features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingFeatures.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderInputAttachmentArrayDynamicIndexing indicates whether arrays of input attachments can be indexed by
    ///     integer expressions that are dynamically uniform within either the subgroup or the invocation group in shader code.
    ///     If this feature is not enabled, resources with a descriptor type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT must be
    ///     indexed only by constant integral expressions when aggregated into arrays in shader code. This also indicates
    ///     whether shader modules can declare the InputAttachmentArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayDynamicIndexing indicates whether arrays of uniform texel buffers can be indexed
    ///     by integer expressions that are dynamically uniform within either the subgroup or the invocation group in shader
    ///     code. If this feature is not enabled, resources with a descriptor type of VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER
    ///     must be indexed only by constant integral expressions when aggregated into arrays in shader code. This also
    ///     indicates whether shader modules can declare the UniformTexelBufferArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayDynamicIndexing indicates whether arrays of storage texel buffers can be indexed
    ///     by integer expressions that are dynamically uniform within either the subgroup or the invocation group in shader
    ///     code. If this feature is not enabled, resources with a descriptor type of VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER
    ///     must be indexed only by constant integral expressions when aggregated into arrays in shader code. This also
    ///     indicates whether shader modules can declare the StorageTexelBufferArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformBufferArrayNonUniformIndexing indicates whether arrays of uniform buffers can be indexed by
    ///     non-uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC must not be indexed by non-uniform
    ///     integer expressions when aggregated into arrays in shader code. This also indicates whether shader modules can
    ///     declare the UniformBufferArrayNonUniformIndexing capability.
    /// </summary>
    public VkBool32 shaderUniformBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderSampledImageArrayNonUniformIndexing indicates whether arrays of samplers or sampled images can be
    ///     indexed by non-uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_SAMPLER, VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE must not be indexed by non-uniform integer expressions when aggregated into arrays
    ///     in shader code. This also indicates whether shader modules can declare the SampledImageArrayNonUniformIndexing
    ///     capability.
    /// </summary>
    public VkBool32 shaderSampledImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageBufferArrayNonUniformIndexing indicates whether arrays of storage buffers can be indexed by
    ///     non-uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC must not be indexed by non-uniform
    ///     integer expressions when aggregated into arrays in shader code. This also indicates whether shader modules can
    ///     declare the StorageBufferArrayNonUniformIndexing capability.
    /// </summary>
    public VkBool32 shaderStorageBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageImageArrayNonUniformIndexing indicates whether arrays of storage images can be indexed by
    ///     non-uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_STORAGE_IMAGE must not be indexed by non-uniform integer expressions when aggregated into arrays
    ///     in shader code. This also indicates whether shader modules can declare the StorageImageArrayNonUniformIndexing
    ///     capability.
    /// </summary>
    public VkBool32 shaderStorageImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderInputAttachmentArrayNonUniformIndexing indicates whether arrays of input attachments can be indexed by
    ///     non-uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT must not be indexed by non-uniform integer expressions when aggregated into
    ///     arrays in shader code. This also indicates whether shader modules can declare the
    ///     InputAttachmentArrayNonUniformIndexing capability.
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayNonUniformIndexing indicates whether arrays of uniform texel buffers can be
    ///     indexed by non-uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER must not be indexed by non-uniform integer expressions
    ///     when aggregated into arrays in shader code. This also indicates whether shader modules can declare the
    ///     UniformTexelBufferArrayNonUniformIndexing capability.
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayNonUniformIndexing indicates whether arrays of storage texel buffers can be
    ///     indexed by non-uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER must not be indexed by non-uniform integer expressions
    ///     when aggregated into arrays in shader code. This also indicates whether shader modules can declare the
    ///     StorageTexelBufferArrayNonUniformIndexing capability.
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     descriptorBindingUniformBufferUpdateAfterBind indicates whether the implementation supports updating uniform
    ///     buffer descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER.
    /// </summary>
    public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingSampledImageUpdateAfterBind indicates whether the implementation supports updating sampled
    ///     image descriptors after a set is bound. If this feature is not enabled, VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT
    ///     must not be used with VK_DESCRIPTOR_TYPE_SAMPLER, VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE.
    /// </summary>
    public VkBool32 descriptorBindingSampledImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageImageUpdateAfterBind indicates whether the implementation supports updating storage
    ///     image descriptors after a set is bound. If this feature is not enabled, VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT
    ///     must not be used with VK_DESCRIPTOR_TYPE_STORAGE_IMAGE.
    /// </summary>
    public VkBool32 descriptorBindingStorageImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageBufferUpdateAfterBind indicates whether the implementation supports updating storage
    ///     buffer descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_STORAGE_BUFFER.
    /// </summary>
    public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUniformTexelBufferUpdateAfterBind indicates whether the implementation supports updating
    ///     uniform texel buffer descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.
    /// </summary>
    public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageTexelBufferUpdateAfterBind indicates whether the implementation supports updating
    ///     storage texel buffer descriptors after a set is bound. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT must not be used with VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.
    /// </summary>
    public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUpdateUnusedWhilePending indicates whether the implementation supports updating descriptors
    ///     while the set is in use. If this feature is not enabled, VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT must
    ///     not be used.
    /// </summary>
    public VkBool32 descriptorBindingUpdateUnusedWhilePending;

    /// <summary>
    ///     descriptorBindingPartiallyBound indicates whether the implementation supports statically using a descriptor
    ///     set binding in which some descriptors are not valid. If this feature is not enabled,
    ///     VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT must not be used.
    /// </summary>
    public VkBool32 descriptorBindingPartiallyBound;

    /// <summary>
    ///     descriptorBindingVariableDescriptorCount indicates whether the implementation supports descriptor sets with a
    ///     variable-sized last binding. If this feature is not enabled, VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT
    ///     must not be used.
    /// </summary>
    public VkBool32 descriptorBindingVariableDescriptorCount;

    /// <summary>
    ///     runtimeDescriptorArray indicates whether the implementation supports the SPIR-V RuntimeDescriptorArray
    ///     capability. If this feature is not enabled, descriptors must not be declared in runtime arrays.
    /// </summary>
    public VkBool32 runtimeDescriptorArray;
}