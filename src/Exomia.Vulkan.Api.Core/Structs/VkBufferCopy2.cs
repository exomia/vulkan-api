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
///     VkBufferCopy2 - Structure specifying a buffer copy operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCopy2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCopy2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCopy2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_COPY_2;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcOffset is the starting offset in bytes from the start of srcBuffer.</summary>
    public VkDeviceSize srcOffset;

    /// <summary>dstOffset is the starting offset in bytes from the start of dstBuffer.</summary>
    public VkDeviceSize dstOffset;

    /// <summary>size is the number of bytes to copy.</summary>
    public VkDeviceSize size;
}