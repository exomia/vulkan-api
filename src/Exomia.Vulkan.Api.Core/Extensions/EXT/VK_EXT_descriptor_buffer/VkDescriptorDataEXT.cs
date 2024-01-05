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
///     VkDescriptorDataEXT - Structure specifying descriptor data -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorDataEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDescriptorDataEXT
{
    /// <summary>
    ///     pSampler is a pointer to a VkSampler handle specifying the parameters of a VK_DESCRIPTOR_TYPE_SAMPLER
    ///     descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkSampler* pSampler;

    /// <summary>
    ///     pCombinedImageSampler is a pointer to a VkDescriptorImageInfo structure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pCombinedImageSampler;

    /// <summary>
    ///     pInputAttachmentImage is a pointer to a VkDescriptorImageInfo structure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pInputAttachmentImage;

    /// <summary>
    ///     pSampledImage is a pointer to a VkDescriptorImageInfostructure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pSampledImage;

    /// <summary>
    ///     pStorageImage is a pointer to a VkDescriptorImageInfostructure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_STORAGE_IMAGE descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorImageInfo* pStorageImage;

    /// <summary>
    ///     pUniformTexelBuffer is a pointer to a VkDescriptorAddressInfoEXT structure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;

    /// <summary>
    ///     pStorageTexelBuffer is a pointer to a VkDescriptorAddressInfoEXT structure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;

    /// <summary>
    ///     pUniformBuffer is a pointer to a VkDescriptorAddressInfoEXTstructure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pUniformBuffer;

    /// <summary>
    ///     pStorageBuffer is a pointer to a VkDescriptorAddressInfoEXTstructure specifying the parameters of a
    ///     VK_DESCRIPTOR_TYPE_STORAGE_BUFFER descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDescriptorAddressInfoEXT* pStorageBuffer;

    /// <summary>
    ///     accelerationStructure is      the address of a VkAccelerationStructureKHR specifying the      parameters of a
    ///     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR     descriptor , or     a VkAccelerationStructureNV handle specifying
    ///     the parameters of a     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV descriptor.
    /// </summary>
    [FieldOffset(0)]
    public VkDeviceAddress accelerationStructure;
}