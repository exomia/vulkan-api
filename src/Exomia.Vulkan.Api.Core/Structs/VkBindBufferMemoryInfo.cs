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
///     VkBindBufferMemoryInfo - Structure specifying how to bind a buffer to memory -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>buffer is the buffer to be attached to memory.</summary>
    public VkBuffer buffer;

    /// <summary>memory is a VkDeviceMemory object describing the device memory to attach.</summary>
    public VkDeviceMemory memory;

    /// <summary>
    ///     memoryOffset is the start offset of the region of memorywhich is to be bound to the buffer. The number of
    ///     bytes returned in the VkMemoryRequirements::size member in memory, starting from memoryOffset bytes, will be bound
    ///     to the specified buffer.
    /// </summary>
    public VkDeviceSize memoryOffset;
}