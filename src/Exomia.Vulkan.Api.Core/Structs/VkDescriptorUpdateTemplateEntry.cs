#region License

// Copyright (c) 2018-2022, exomia
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
///     VkDescriptorUpdateTemplateEntry - Describes a single descriptor update of the descriptor update template -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateEntry.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateEntry.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDescriptorUpdateTemplateEntry
{
    /// <summary>dstBinding is the descriptor binding to update when using this descriptor update template.</summary>
    public uint dstBinding;

    /// <summary>
    ///     dstArrayElement is the starting element in the array belonging to dstBinding. If the descriptor binding
    ///     identified by dstBinding has a descriptor type of VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then dstArrayElement
    ///     specifies the starting byte offset to update.
    /// </summary>
    public uint dstArrayElement;

    /// <summary>
    ///     descriptorCount is the number of descriptors to update. If descriptorCount is greater than the number of
    ///     remaining array elements in the destination binding, those affect consecutive bindings in a manner similar to
    ///     VkWriteDescriptorSet above. If the descriptor binding identified by dstBinding has a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK then descriptorCount specifies the number of bytes to update and the
    ///     remaining array elements in the destination binding refer to the remaining number of bytes in it.
    /// </summary>
    public uint descriptorCount;

    /// <summary>descriptorType is a VkDescriptorType specifying the type of the descriptor.</summary>
    public VkDescriptorType descriptorType;

    /// <summary>offset is the offset in bytes of the first binding in the raw data structure.</summary>
    public nuint offset;

    /// <summary>
    ///     stride is the stride in bytes between two consecutive array elements of the descriptor update information in
    ///     the raw data structure. The actual pointer ptr for each array element j of update entry i is computed using the
    ///     following formula:    const char *ptr = (const char *)pData + pDescriptorUpdateEntries[i].offset + j *
    ///     pDescriptorUpdateEntries[i].strideThe stride is useful in case the bindings are stored in structs along with other
    ///     data. If descriptorType is VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCKthen the value of stride is ignored and the
    ///     stride is assumed to be 1, i.e. the descriptor update information for them is always specified as a contiguous
    ///     range.
    /// </summary>
    public nuint stride;
}