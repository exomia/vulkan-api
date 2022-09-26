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
///     VkMemoryRequirements - Structure specifying memory requirements -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryRequirements.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryRequirements.html </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> returnedonly </term><description> true </description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkMemoryRequirements
{
    /// <summary> size is the size, in bytes, of the memory allocation required for the resource. </summary>
    public VkDeviceSize size;

    /// <summary> alignment is the alignment, in bytes, of the offset within the allocation required for the resource. </summary>
    public VkDeviceSize alignment;

    /// <summary> memoryTypeBits is a bitmask and contains one bit set for every supported memory type for the resource. Bit i is set if and only if the memory type i in the VkPhysicalDeviceMemoryProperties structure for the physical device is supported for the resource. </summary>
    public uint memoryTypeBits;
}