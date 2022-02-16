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
///     VkPhysicalDeviceMemoryProperties - Structure specifying physical device memory properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkPhysicalDeviceMemoryProperties
{
    /// <summary>memoryTypeCount is the number of valid elements in the memoryTypes array.</summary>
    public uint memoryTypeCount;

    /// <summary>
    ///     memoryTypes is an array of VK_MAX_MEMORY_TYPESVkMemoryType structures describing the memory types that can be
    ///     used to access memory allocated from the heaps specified by memoryHeaps.
    /// </summary>
    public VkArray32<VkMemoryType> memoryTypes;

    /// <summary>memoryHeapCount is the number of valid elements in the memoryHeaps array.</summary>
    public uint memoryHeapCount;

    /// <summary>
    ///     memoryHeaps is an array of VK_MAX_MEMORY_HEAPSVkMemoryHeap structures describing the memory heaps from which
    ///     memory can be allocated.
    /// </summary>
    public VkArray16<VkMemoryHeap> memoryHeaps;
}