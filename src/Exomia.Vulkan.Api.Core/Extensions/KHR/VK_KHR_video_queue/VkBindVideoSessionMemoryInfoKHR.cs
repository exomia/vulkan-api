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
///     VkBindVideoSessionMemoryInfoKHR - Structure specifying memory bindings for a video session object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindVideoSessionMemoryInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindVideoSessionMemoryInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindVideoSessionMemoryInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>memoryBindIndex is the memory binding index to bind memory to.</summary>
    public uint memoryBindIndex;

    /// <summary>
    ///     memory is the allocated device memory to be bound to the video session&#8217;s memory binding with index
    ///     memoryBindIndex.
    /// </summary>
    public VkDeviceMemory memory;

    /// <summary>memoryOffset is the start offset of the region of memorywhich is to be bound.</summary>
    public VkDeviceSize memoryOffset;

    /// <summary>memorySize is the size in bytes of the region of memory, starting from memoryOffset bytes, to be bound.</summary>
    public VkDeviceSize memorySize;
}