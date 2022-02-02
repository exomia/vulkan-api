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
///     VkMemoryHeapFlagBits - Bitmask specifying attribute flags for a heap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryHeapFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryHeapFlagBits.html</a>
/// </summary>
[Flags]
public enum VkMemoryHeapFlagBits
{
    /// <summary>
    ///     VK_MEMORY_HEAP_DEVICE_LOCAL_BIT specifies that the heap corresponds to device-local memory. Device-local
    ///     memory may have different performance characteristics than host-local memory, and may support different memory
    ///     property flags.
    /// </summary>
    VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = 0,

    /// <summary>
    ///     VK_MEMORY_HEAP_MULTI_INSTANCE_BIT specifies that in a logical device representing more than one physical
    ///     device, there is a per-physical device instance of the heap memory. By default, an allocation from such a heap will
    ///     be replicated to each physical device&#8217;s instance of the heap.
    /// </summary>
    VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = 1,

    /// <summary>
    ///     VK_MEMORY_HEAP_RESERVED_2_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkMemoryHeapFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkMemoryHeapFlagBits</a>
    /// </summary>
    VK_MEMORY_HEAP_RESERVED_2_BIT_KHR = 2,

    /// <summary>
    ///     VK_MEMORY_HEAP_MULTI_INSTANCE_BIT specifies that in a logical device representing more than one physical
    ///     device, there is a per-physical device instance of the heap memory. By default, an allocation from such a heap will
    ///     be replicated to each physical device&#8217;s instance of the heap.
    /// </summary>
    VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR = VK_MEMORY_HEAP_MULTI_INSTANCE_BIT
}