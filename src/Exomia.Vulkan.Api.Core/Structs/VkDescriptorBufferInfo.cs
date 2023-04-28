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
///     VkDescriptorBufferInfo - Structure specifying descriptor buffer information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorBufferInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorBufferInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDescriptorBufferInfo
{
    /// <summary>buffer is VK_NULL_HANDLE or the buffer resource.</summary>
    public VkBuffer buffer;

    /// <summary>
    ///     offset is the offset in bytes from the start of buffer. Access to buffer memory via this descriptor uses
    ///     addressing that is relative to this starting offset.
    /// </summary>
    public VkDeviceSize offset;

    /// <summary>
    ///     range is the size in bytes that is used for this descriptor update, or VK_WHOLE_SIZE to use the range from
    ///     offset to the end of the buffer.NoteWhen setting range to VK_WHOLE_SIZE, the effective range must not be larger
    ///     than the maximum range for the descriptor type (maxUniformBufferRange or maxStorageBufferRange). This means that
    ///     VK_WHOLE_SIZE is not typically useful in the common case where uniform buffer descriptors are suballocated from a
    ///     buffer that is much larger than maxUniformBufferRange.
    /// </summary>
    public VkDeviceSize range;
}