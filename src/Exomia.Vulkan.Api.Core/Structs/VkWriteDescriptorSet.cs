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
///     VkWriteDescriptorSet - Structure specifying the parameters of a descriptor set write operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSet.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSet.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSet
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>dstSet is the destination descriptor set to update.</summary>
    public VkDescriptorSet dstSet;

    /// <summary>dstBinding is the descriptor binding within that set.</summary>
    public uint dstBinding;

    /// <summary>
    ///     dstArrayElement is the starting element in that array. If the descriptor binding identified by dstSet and
    ///     dstBinding has a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then dstArrayElementspecifies the
    ///     starting byte offset within the binding.
    /// </summary>
    public uint dstArrayElement;

    /// <summary>
    ///     descriptorCount is the number of descriptors to update. If the descriptor binding identified by dstSet and
    ///     dstBinding has a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK, then descriptorCount specifies the
    ///     number of bytes to update. Otherwise, descriptorCount is one ofthe number of elements in pImageInfothe number of
    ///     elements in pBufferInfothe number of elements in pTexelBufferViewa value matching the dataSize member of a
    ///     VkWriteDescriptorSetInlineUniformBlock structure in the pNext chaina value matching the accelerationStructureCount
    ///     of a VkWriteDescriptorSetAccelerationStructureKHR structure in the pNext chain
    /// </summary>
    public uint descriptorCount;

    /// <summary>
    ///     descriptorType is a VkDescriptorType specifying the type of each descriptor in pImageInfo, pBufferInfo, or
    ///     pTexelBufferView, as described below. If VkDescriptorSetLayoutBinding for dstSet at dstBinding is not equal to
    ///     VK_DESCRIPTOR_TYPE_MUTABLE_EXT, descriptorType mustbe the same type as the descriptorType specified in
    ///     VkDescriptorSetLayoutBinding for dstSet at dstBinding. The type of the descriptor also controls which array the
    ///     descriptors are taken from.
    /// </summary>
    public VkDescriptorType descriptorType;

    /// <summary>pImageInfo is a pointer to an array of VkDescriptorImageInfostructures or is ignored, as described below.</summary>
    public VkDescriptorImageInfo* pImageInfo;

    /// <summary>pBufferInfo is a pointer to an array of VkDescriptorBufferInfo structures or is ignored, as described below.</summary>
    public VkDescriptorBufferInfo* pBufferInfo;

    /// <summary>
    ///     pTexelBufferView is a pointer to an array of VkBufferViewhandles as described in the Buffer Viewssection or is
    ///     ignored, as described below.
    /// </summary>
    public VkBufferView* pTexelBufferView;
}