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
///     VkCopyDescriptorSet - Structure specifying a copy descriptor set operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyDescriptorSet.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyDescriptorSet.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyDescriptorSet
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     srcSet, srcBinding, and srcArrayElement are the source set, binding, and array element, respectively. If the
    ///     descriptor binding identified by srcSet and srcBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then srcArrayElementspecifies the starting byte offset within the binding
    ///     to copy from.
    /// </summary>
    public VkDescriptorSet srcSet;

    /// <summary>
    ///     srcSet, srcBinding, and srcArrayElement are the source set, binding, and array element, respectively. If the
    ///     descriptor binding identified by srcSet and srcBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then srcArrayElementspecifies the starting byte offset within the binding
    ///     to copy from.
    /// </summary>
    public uint srcBinding;

    /// <summary>
    ///     srcSet, srcBinding, and srcArrayElement are the source set, binding, and array element, respectively. If the
    ///     descriptor binding identified by srcSet and srcBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then srcArrayElementspecifies the starting byte offset within the binding
    ///     to copy from.
    /// </summary>
    public uint srcArrayElement;

    /// <summary>
    ///     dstSet, dstBinding, and dstArrayElement are the destination set, binding, and array element, respectively. If
    ///     the descriptor binding identified by dstSet and dstBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then dstArrayElementspecifies the starting byte offset within the binding
    ///     to copy to.
    /// </summary>
    public VkDescriptorSet dstSet;

    /// <summary>
    ///     dstSet, dstBinding, and dstArrayElement are the destination set, binding, and array element, respectively. If
    ///     the descriptor binding identified by dstSet and dstBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then dstArrayElementspecifies the starting byte offset within the binding
    ///     to copy to.
    /// </summary>
    public uint dstBinding;

    /// <summary>
    ///     dstSet, dstBinding, and dstArrayElement are the destination set, binding, and array element, respectively. If
    ///     the descriptor binding identified by dstSet and dstBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then dstArrayElementspecifies the starting byte offset within the binding
    ///     to copy to.
    /// </summary>
    public uint dstArrayElement;

    /// <summary>
    ///     descriptorCount is the number of descriptors to copy from the source to destination. If descriptorCount is
    ///     greater than the number of remaining array elements in the source or destination binding, those affect consecutive
    ///     bindings in a manner similar to VkWriteDescriptorSet above. If the descriptor binding identified by srcSet and
    ///     srcBinding has a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then descriptorCountspecifies the
    ///     number of bytes to copy and the remaining array elements in the source or destination binding refer to the
    ///     remaining number of bytes in those.
    /// </summary>
    public uint descriptorCount;
}