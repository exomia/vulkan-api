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
///     VkMemoryType - Structure specifying memory type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryType.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkMemoryType
{
    /// <summary> propertyFlags is a bitmask of VkMemoryPropertyFlagBits of properties for this memory type. </summary>
    public VkMemoryPropertyFlags propertyFlags;

    /// <summary> heapIndex describes which memory heap this memory type corresponds to, and must be less than memoryHeapCount from the VkPhysicalDeviceMemoryProperties structure. </summary>
    public uint heapIndex;
}