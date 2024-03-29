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
///     VkBufferMemoryBarrier - Structure specifying a buffer memory barrier -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferMemoryBarrier.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferMemoryBarrier.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryBarrier
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcAccessMask is a bitmask of VkAccessFlagBits specifying a source access mask.</summary>
    public VkAccessFlags srcAccessMask;

    /// <summary>dstAccessMask is a bitmask of VkAccessFlagBits specifying a destination access mask.</summary>
    public VkAccessFlags dstAccessMask;

    /// <summary>srcQueueFamilyIndex is the source queue family for a queue family ownership transfer.</summary>
    public uint srcQueueFamilyIndex;

    /// <summary>dstQueueFamilyIndex is the destination queue family for a queue family ownership transfer.</summary>
    public uint dstQueueFamilyIndex;

    /// <summary>buffer is a handle to the buffer whose backing memory is affected by the barrier.</summary>
    public VkBuffer buffer;

    /// <summary>
    ///     offset is an offset in bytes into the backing memory for buffer; this is relative to the base offset as bound
    ///     to the buffer (see vkBindBufferMemory).
    /// </summary>
    public VkDeviceSize offset;

    /// <summary>
    ///     size is a size in bytes of the affected area of backing memory for buffer, or VK_WHOLE_SIZE to use the range
    ///     from offsetto the end of the buffer.
    /// </summary>
    public VkDeviceSize size;
}