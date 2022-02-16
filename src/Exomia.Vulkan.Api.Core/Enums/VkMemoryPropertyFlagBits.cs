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
///     VkMemoryPropertyFlagBits - Bitmask specifying properties for a memory type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryPropertyFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryPropertyFlagBits.html</a>
/// </summary>
[Flags]
public enum VkMemoryPropertyFlagBits
{
    /// <summary>
    ///     VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit specifies that memory allocated with this type is the most efficient
    ///     for device access. This property will be set if and only if the memory type belongs to a heap with the
    ///     VK_MEMORY_HEAP_DEVICE_LOCAL_BIT set.
    /// </summary>
    VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = 0x1,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT bit specifies that memory allocated with this type can be mapped for host
    ///     access using
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html">vkMapMemory</a>.
    /// </summary>
    VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x2,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bit specifies that the host cache management commands
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkFlushMappedMemoryRanges.html">vkFlushMappedMemoryRanges</a>
    ///     and
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkInvalidateMappedMemoryRanges.html">vkInvalidateMappedMemoryRanges</a>
    ///     are not needed to flush host writes to the device or make device writes visible to the host, respectively.
    /// </summary>
    VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = 0x4,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_HOST_CACHED_BIT bit specifies that memory allocated with this type is cached on the host.
    ///     Host memory accesses to uncached memory are slower than to cached memory, however uncached memory is always host
    ///     coherent.
    /// </summary>
    VK_MEMORY_PROPERTY_HOST_CACHED_BIT = 0x8,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT bit specifies that the memory type only allows device access to the memory.
    ///     Memory types must not have both VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT and VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT
    ///     set. Additionally, the object&#8217;s backing memory may be provided by the implementation lazily as specified in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#memory-device-lazy_allocation">
    ///         Lazily
    ///         Allocated Memory
    ///     </a>
    ///     .
    /// </summary>
    VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x10,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_PROTECTED_BIT bit specifies that the memory type only allows device access to the memory,
    ///     and allows protected queue operations to access the memory. Memory types must not have
    ///     VK_MEMORY_PROPERTY_PROTECTED_BIT set and any of VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT set, or
    ///     VK_MEMORY_PROPERTY_HOST_COHERENT_BIT set, or VK_MEMORY_PROPERTY_HOST_CACHED_BIT set.
    /// </summary>
    VK_MEMORY_PROPERTY_PROTECTED_BIT = 0x20,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD bit specifies that device accesses to allocations of this memory
    ///     type are automatically made available and visible.
    /// </summary>
    VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = 0x40,

    /// <summary>
    ///     VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD bit specifies that memory allocated with this type is not cached on
    ///     the device. Uncached device memory is always device coherent.
    /// </summary>
    VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = 0x80,

    /// <summary>VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV bit specifies that external devices can access this memory directly.</summary>
    VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV = 0x100
}