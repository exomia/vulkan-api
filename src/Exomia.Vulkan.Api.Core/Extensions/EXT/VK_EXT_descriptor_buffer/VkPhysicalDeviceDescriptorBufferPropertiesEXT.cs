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
///     VkPhysicalDeviceDescriptorBufferPropertiesEXT - Structure describing descriptor buffer properties supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferPropertiesEXT.html
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
public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     combinedImageSamplerDescriptorSingleArray indicates that the implementation does not require an array of
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER descriptors to be written into a descriptor buffer as an array of image
    ///     descriptors, immediately followed by an array of sampler descriptors.
    /// </summary>
    public VkBool32 combinedImageSamplerDescriptorSingleArray;

    /// <summary>
    ///     bufferlessPushDescriptorsindicates that the implementation does not require a buffer created with
    ///     VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT to be bound when using push descriptors.
    /// </summary>
    public VkBool32 bufferlessPushDescriptors;

    /// <summary>
    ///     allowSamplerImageViewPostSubmitCreation indicates that the implementation does not restrict when the VkSampler
    ///     or VkImageView objects used to retrieve descriptor data can be created in relation to command buffer submission. If
    ///     this value is VK_FALSE, then the application must create any VkSampler or VkImageView objects whose descriptor data
    ///     is accessed during the execution of a command buffer, before the vkQueueSubmit, or vkQueueSubmit2, call that
    ///     submits that command buffer.
    /// </summary>
    public VkBool32 allowSamplerImageViewPostSubmitCreation;

    /// <summary>
    ///     descriptorBufferOffsetAlignment indicates the required alignment in bytes when setting offsets into the
    ///     descriptor buffer.
    /// </summary>
    public VkDeviceSize descriptorBufferOffsetAlignment;

    /// <summary>
    ///     maxDescriptorBufferBindingsindicates the maximum sum total number of descriptor buffers and embedded
    ///     immutable sampler sets that can be bound.
    /// </summary>
    public uint maxDescriptorBufferBindings;

    /// <summary>
    ///     maxResourceDescriptorBufferBindings indicates the maximum number of resource descriptor buffers that can be
    ///     bound.
    /// </summary>
    public uint maxResourceDescriptorBufferBindings;

    /// <summary>
    ///     maxSamplerDescriptorBufferBindings indicates the maximum number of sampler descriptor buffers that can be
    ///     bound.
    /// </summary>
    public uint maxSamplerDescriptorBufferBindings;

    /// <summary>
    ///     maxEmbeddedImmutableSamplerBindings indicates the maximum number of embedded immutable sampler sets that can
    ///     be bound.
    /// </summary>
    public uint maxEmbeddedImmutableSamplerBindings;

    /// <summary>
    ///     maxEmbeddedImmutableSamplers indicates the maximum number of unique immutable samplers in descriptor set
    ///     layouts created with VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT, and pipeline layouts
    ///     created from them, which can simultaneously exist on a device.
    /// </summary>
    public uint maxEmbeddedImmutableSamplers;

    /// <summary>
    ///     bufferCaptureReplayDescriptorDataSize indicates the maximum size in bytes of the opaque data used for capture
    ///     and replay with buffers.
    /// </summary>
    public nuint bufferCaptureReplayDescriptorDataSize;

    /// <summary>
    ///     imageCaptureReplayDescriptorDataSize indicates the maximum size in bytes of the opaque data used for capture
    ///     and replay with images.
    /// </summary>
    public nuint imageCaptureReplayDescriptorDataSize;

    /// <summary>
    ///     imageViewCaptureReplayDescriptorDataSize indicates the maximum size in bytes of the opaque data used for
    ///     capture and replay with image views.
    /// </summary>
    public nuint imageViewCaptureReplayDescriptorDataSize;

    /// <summary>
    ///     samplerCaptureReplayDescriptorDataSize indicates the maximum size in bytes of the opaque data used for capture
    ///     and replay with samplers.
    /// </summary>
    public nuint samplerCaptureReplayDescriptorDataSize;

    /// <summary>
    ///     accelerationStructureCaptureReplayDescriptorDataSize indicates the maximum size in bytes of the opaque data
    ///     used for capture and replay with acceleration structures.
    /// </summary>
    public nuint accelerationStructureCaptureReplayDescriptorDataSize;

    /// <summary> samplerDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_SAMPLER descriptor.</summary>
    public nuint samplerDescriptorSize;

    /// <summary>
    ///     combinedImageSamplerDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER
    ///     descriptor.
    /// </summary>
    public nuint combinedImageSamplerDescriptorSize;

    /// <summary> sampledImageDescriptorSizeindicates the size in bytes of a VK_DESCRIPTOR_TYPE_SAMPLED_IMAGEdescriptor.</summary>
    public nuint sampledImageDescriptorSize;

    /// <summary> storageImageDescriptorSizeindicates the size in bytes of a VK_DESCRIPTOR_TYPE_STORAGE_IMAGEdescriptor.</summary>
    public nuint storageImageDescriptorSize;

    /// <summary>
    ///     uniformTexelBufferDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER
    ///     descriptor if the robustBufferAccess feature is not enabled.
    /// </summary>
    public nuint uniformTexelBufferDescriptorSize;

    /// <summary>
    ///     robustUniformTexelBufferDescriptorSize indicates the size in bytes of a
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor if the robustBufferAccess feature is enabled.
    /// </summary>
    public nuint robustUniformTexelBufferDescriptorSize;

    /// <summary>
    ///     storageTexelBufferDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER
    ///     descriptor if the robustBufferAccess feature is not enabled.
    /// </summary>
    public nuint storageTexelBufferDescriptorSize;

    /// <summary>
    ///     robustStorageTexelBufferDescriptorSize indicates the size in bytes of a
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor if the robustBufferAccess feature is enabled.
    /// </summary>
    public nuint robustStorageTexelBufferDescriptorSize;

    /// <summary> uniformBufferDescriptorSizeindicates the size in bytes of a VK_DESCRIPTOR_TYPE_UNIFORM_BUFFERdescriptor.</summary>
    public nuint uniformBufferDescriptorSize;

    /// <summary>
    ///     robustUniformBufferDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER
    ///     descriptor if the robustBufferAccess feature is enabled.
    /// </summary>
    public nuint robustUniformBufferDescriptorSize;

    /// <summary> storageBufferDescriptorSizeindicates the size in bytes of a VK_DESCRIPTOR_TYPE_STORAGE_BUFFERdescriptor.</summary>
    public nuint storageBufferDescriptorSize;

    /// <summary>
    ///     robustStorageBufferDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_STORAGE_BUFFER
    ///     descriptor if the robustBufferAccess feature is enabled.
    /// </summary>
    public nuint robustStorageBufferDescriptorSize;

    /// <summary>inputAttachmentDescriptorSize indicates the size in bytes of a VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT descriptor.</summary>
    public nuint inputAttachmentDescriptorSize;

    /// <summary>
    ///     accelerationStructureDescriptorSize indicates the size in bytes of a
    ///     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR or VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV descriptor.
    /// </summary>
    public nuint accelerationStructureDescriptorSize;

    /// <summary>
    ///     maxSamplerDescriptorBufferRange indicates the maximum range in bytes from the address of a sampler descriptor
    ///     buffer binding that is accessible to a shader.
    /// </summary>
    public VkDeviceSize maxSamplerDescriptorBufferRange;

    /// <summary>
    ///     maxResourceDescriptorBufferRange indicates the maximum range in bytes from the address of a resource
    ///     descriptor buffer binding that is accessible to a shader.
    /// </summary>
    public VkDeviceSize maxResourceDescriptorBufferRange;

    /// <summary>
    ///     samplerDescriptorBufferAddressSpaceSize indicates the total size in bytes of the address space available for
    ///     descriptor buffers created with VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT.
    /// </summary>
    public VkDeviceSize samplerDescriptorBufferAddressSpaceSize;

    /// <summary>
    ///     resourceDescriptorBufferAddressSpaceSize indicates the total size in bytes of the address space available for
    ///     descriptor buffers created with VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT.
    /// </summary>
    public VkDeviceSize resourceDescriptorBufferAddressSpaceSize;

    /// <summary>
    ///     descriptorBufferAddressSpaceSize indicates the total size in bytes of the address space available for
    ///     descriptor buffers created with both VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT and
    ///     VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT.
    /// </summary>
    public VkDeviceSize descriptorBufferAddressSpaceSize;
}