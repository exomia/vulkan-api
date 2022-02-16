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
///     VkCopyBufferInfo2 - Structure specifying parameters of a buffer copy command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyBufferInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyBufferInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcBuffer is the source buffer.</summary>
    public VkBuffer srcBuffer;

    /// <summary>dstBuffer is the destination buffer.</summary>
    public VkBuffer dstBuffer;

    /// <summary>regionCount is the number of regions to copy.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to an array of VkBufferCopy2structures specifying the regions to copy.</summary>
    public VkBufferCopy2* pRegions;
}