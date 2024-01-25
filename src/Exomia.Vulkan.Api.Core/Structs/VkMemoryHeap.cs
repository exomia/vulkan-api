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
///     VkMemoryHeap - Structure specifying a memory heap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryHeap.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryHeap.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkMemoryHeap
{
    /// <summary>size is the total memory size in bytes in the heap.</summary>
    public VkDeviceSize size;

    /// <summary>flags is a bitmask of VkMemoryHeapFlagBits specifying attribute flags for the heap.</summary>
    public VkMemoryHeapFlags flags;
}