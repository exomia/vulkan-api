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
///     VkBufferViewCreateInfo - Structure specifying parameters of a newly created buffer view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferViewCreateInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferViewCreateInfo.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferViewCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkBufferViewCreateFlags flags;

    /// <summary> buffer is a VkBuffer on which the view will be created. </summary>
    public VkBuffer buffer;

    /// <summary> format is a VkFormat describing the format of the data elements in the buffer. </summary>
    public VkFormat format;

    /// <summary> offset is an offset in bytes from the base address of the buffer. Accesses to the buffer view from shaders use addressing that is relative to this starting offset. </summary>
    public VkDeviceSize offset;

    /// <summary> range is a size in bytes of the buffer view. If range is equal to VK_WHOLE_SIZE, the range from offset to the end of the buffer is used. If VK_WHOLE_SIZE is used and the remaining size of the buffer is not a multiple of the texel block size of format, the nearest smaller multiple is used. </summary>
    public VkDeviceSize range;
}