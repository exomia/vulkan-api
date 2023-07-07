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
///     VkPhysicalDeviceVulkan12Features - Structure describing the Vulkan 1.2 features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Features.html
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
public unsafe struct VkPhysicalDeviceVulkan12Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     samplerMirrorClampToEdgeindicates whether the implementation supports the
    ///     VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE sampler address mode. If this feature is not enabled, the
    ///     VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE sampler address mode must not be used.
    /// </summary>
    public VkBool32 samplerMirrorClampToEdge;

    /// <summary>
    ///     drawIndirectCount indicates whether the implementation supports the vkCmdDrawIndirectCount and
    ///     vkCmdDrawIndexedIndirectCount functions. If this feature is not enabled, these functions must not be used.
    /// </summary>
    public VkBool32 drawIndirectCount;

    /// <summary>
    ///     storageBuffer8BitAccess indicates whether objects in the     StorageBuffer, ShaderRecordBufferKHR,     or
    ///     PhysicalStorageBuffer    storage class with the Block decoration can have 8-bit integer     members.     If this
    ///     feature is not enabled, 8-bit integer members must not be used     in such objects.     This also indicates whether
    ///     shader modules can declare the     StorageBuffer8BitAccess capability.
    /// </summary>
    public VkBool32 storageBuffer8BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer8BitAccess indicates whether objects in the Uniform storage class with the Block
    ///     decoration can have 8-bit integer members. If this feature is not enabled, 8-bit integer members must not be used
    ///     in such objects. This also indicates whether shader modules can declare the UniformAndStorageBuffer8BitAccess
    ///     capability.
    /// </summary>
    public VkBool32 uniformAndStorageBuffer8BitAccess;

    /// <summary>
    ///     storagePushConstant8 indicates whether objects in the PushConstant storage class can have 8-bit integer
    ///     members. If this feature is not enabled, 8-bit integer members must not be used in such objects. This also
    ///     indicates whether shader modules can declare the StoragePushConstant8 capability.
    /// </summary>
    public VkBool32 storagePushConstant8;

    /// <summary>
    ///     shaderBufferInt64Atomics indicates whether shaders can perform 64-bit unsigned and signed integer atomic
    ///     operations on buffers.
    /// </summary>
    public VkBool32 shaderBufferInt64Atomics;

    /// <summary>
    ///     shaderSharedInt64Atomics indicates whether shaders can perform 64-bit unsigned and signed integer atomic
    ///     operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedInt64Atomics;

    /// <summary>
    ///     shaderFloat16 indicates whether 16-bit floats (halfs) are supported in shader code. This also indicates
    ///     whether shader modules can declare the Float16capability. However, this only enables a subset of the storage
    ///     classes that SPIR-V allows for the Float16 SPIR-V capability: Declaring and using 16-bit floats in the Private,
    ///     Workgroup (for non-Block variables), and Function storage classes is enabled, while declaring them in the interface
    ///     storage classes (e.g., UniformConstant, Uniform, StorageBuffer, Input, Output, and PushConstant) is not enabled.
    /// </summary>
    public VkBool32 shaderFloat16;

    /// <summary>
    ///     shaderInt8 indicates whether 8-bit integers (signed and unsigned) are supported in shader code. This also
    ///     indicates whether shader modules can declare the Int8capability. However, this only enables a subset of the storage
    ///     classes that SPIR-V allows for the Int8 SPIR-V capability: Declaring and using 8-bit integers in the Private,
    ///     Workgroup (for non-Block variables), and Function storage classes is enabled, while declaring them in the interface
    ///     storage classes (e.g., UniformConstant, Uniform, StorageBuffer, Input, Output, and PushConstant) is not enabled.
    /// </summary>
    public VkBool32 shaderInt8;

    /// <summary>
    ///     descriptorIndexing indicates whether the implementation supports the minimum set of descriptor indexing
    ///     features as described in the Feature Requirements section. Enabling the descriptorIndexing member when
    ///     vkCreateDeviceis called does not imply the other minimum descriptor indexing features are also enabled. Those other
    ///     descriptor indexing features must be enabled individually as needed by the application.
    /// </summary>
    public VkBool32 descriptorIndexing;

    /// <summary>
    ///     shaderInputAttachmentArrayDynamicIndexing indicates whether arrays of input attachments can be indexed by
    ///     dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor
    ///     type of VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT must be indexed only by constant integral expressions when aggregated
    ///     into arrays in shader code. This also indicates whether shader modules can declare the
    ///     InputAttachmentArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayDynamicIndexing indicates whether arrays of uniform texel buffers can be indexed
    ///     by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER must be indexed only by constant integral expressions
    ///     when aggregated into arrays in shader code. This also indicates whether shader modules can declare the
    ///     UniformTexelBufferArrayDynamicIndexing capability.
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayDynamicIndexing indicates whether arrays of storage texel buffers can be indexed
    ///     by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a
    ///     descriptor type of VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER must be indexed only by constant integral expressions
    ///     when aggregated into arrays in shader code. This also indicates whether shader modules can declare the
    ///     StorageTexelBufferArrayDynamicIndexing capability.
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

    /// <summary>
    ///     samplerFilterMinmax indicates whether the implementation supports a minimum set of required formats
    ///     supporting min/max filtering as defined by the filterMinmaxSingleComponentFormats property minimum requirements. If
    ///     this feature is not enabled, then VkSamplerReductionModeCreateInfo must only use
    ///     VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE.
    /// </summary>
    public VkBool32 samplerFilterMinmax;

    /// <summary>
    ///     scalarBlockLayoutindicates that the implementation supports the layout of resource blocks in shaders using
    ///     scalar alignment.
    /// </summary>
    public VkBool32 scalarBlockLayout;

    /// <summary>
    ///     imagelessFramebuffer indicates that the implementation supports specifying the image view for attachments at
    ///     render pass begin time via VkRenderPassAttachmentBeginInfo.
    /// </summary>
    public VkBool32 imagelessFramebuffer;

    /// <summary>
    ///     uniformBufferStandardLayout indicates that the implementation supports the same layouts for uniform buffers as
    ///     for storage and other kinds of buffers. See Standard Buffer Layout.
    /// </summary>
    public VkBool32 uniformBufferStandardLayout;

    /// <summary>
    ///     shaderSubgroupExtendedTypes is a boolean specifying whether subgroup operations can use 8-bit integer, 16-bit
    ///     integer, 64-bit integer, 16-bit floating-point, and vectors of these types in group operations with subgroup scope,
    ///     if the implementation supports the types.
    /// </summary>
    public VkBool32 shaderSubgroupExtendedTypes;

    /// <summary>
    ///     separateDepthStencilLayouts indicates whether the implementation supports a VkImageMemoryBarrier for a
    ///     depth/stencil image with only one of VK_IMAGE_ASPECT_DEPTH_BIT or VK_IMAGE_ASPECT_STENCIL_BIT set, and whether
    ///     VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL, VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL,
    ///     VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL, or VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL can be used.
    /// </summary>
    public VkBool32 separateDepthStencilLayouts;

    /// <summary>
    ///     hostQueryResetindicates that the implementation supports resetting queries from the host with
    ///     vkResetQueryPool.
    /// </summary>
    public VkBool32 hostQueryReset;

    /// <summary>
    ///     timelineSemaphoreindicates whether semaphores created with a VkSemaphoreType of VK_SEMAPHORE_TYPE_TIMELINE
    ///     are supported.
    /// </summary>
    public VkBool32 timelineSemaphore;

    /// <summary>
    ///     bufferDeviceAddress indicates that the implementation supports accessing buffer memory in shaders as storage
    ///     buffers via an address queried from vkGetBufferDeviceAddress.
    /// </summary>
    public VkBool32 bufferDeviceAddress;

    /// <summary>
    ///     bufferDeviceAddressCaptureReplay indicates that the implementation supports saving and reusing buffer and
    ///     device addresses, e.g. for trace capture and replay.
    /// </summary>
    public VkBool32 bufferDeviceAddressCaptureReplay;

    /// <summary>
    ///     bufferDeviceAddressMultiDevice indicates that the implementation supports the bufferDeviceAddress,
    ///     rayTracingPipeline and rayQuery features for logical devices created with multiple physical devices. If this
    ///     feature is not supported, buffer and acceleration structure addresses must not be queried on a logical device
    ///     created with more than one physical device.
    /// </summary>
    public VkBool32 bufferDeviceAddressMultiDevice;

    /// <summary> vulkanMemoryModelindicates whether shader modules can declare the VulkanMemoryModelcapability.</summary>
    public VkBool32 vulkanMemoryModel;

    /// <summary>
    ///     vulkanMemoryModelDeviceScope indicates whether the Vulkan Memory Model can use Device scope synchronization.
    ///     This also indicates whether shader modules can declare the VulkanMemoryModelDeviceScope capability.
    /// </summary>
    public VkBool32 vulkanMemoryModelDeviceScope;

    /// <summary>
    ///     vulkanMemoryModelAvailabilityVisibilityChains indicates whether the Vulkan Memory Model can use availability
    ///     and visibility chains with more than one element.
    /// </summary>
    public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;

    /// <summary>
    ///     shaderOutputViewportIndex    indicates whether the implementation supports the     ShaderViewportIndex SPIR-V
    ///     capability enabling variables decorated     with the ViewportIndex built-in to be exported from mesh,     vertex or
    ///     tessellation evaluation shaders.     If this feature is not enabled, the ViewportIndex built-in     decoration must
    ///     not be used on outputs in mesh,     vertex or tessellation evaluation shaders.
    /// </summary>
    public VkBool32 shaderOutputViewportIndex;

    /// <summary>
    ///     shaderOutputLayer indicates whether     the implementation supports the ShaderLayer SPIR-V capability
    ///     enabling variables decorated with the Layer built-in to be exported     from mesh,     vertex or tessellation
    ///     evaluation shaders.     If this feature is not enabled, the Layer built-in decoration must    not be used on
    ///     outputs in mesh,     vertex or tessellation evaluation shaders.
    /// </summary>
    public VkBool32 shaderOutputLayer;

    /// <summary>
    ///     If subgroupBroadcastDynamicId is VK_TRUE, the &#8220;Id&#8221; operand of OpGroupNonUniformBroadcast can be
    ///     dynamically uniform within a subgroup, and the &#8220;Index&#8221; operand of OpGroupNonUniformQuadBroadcast can be
    ///     dynamically uniform within the derivative group. If it is VK_FALSE, these operands must be constants.
    /// </summary>
    public VkBool32 subgroupBroadcastDynamicId;
}