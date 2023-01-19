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
///     VkBufferCreateInfo - Structure specifying the parameters of a newly created buffer object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkBufferCreateFlagBits specifying additional parameters of the buffer.</summary>
    public VkBufferCreateFlags flags;

    /// <summary>size is the size in bytes of the buffer to be created.</summary>
    public VkDeviceSize size;

    /// <summary>usage is a bitmask of VkBufferUsageFlagBits specifying allowed usages of the buffer.</summary>
    public VkBufferUsageFlags usage;

    /// <summary>
    ///     sharingMode is a VkSharingMode value specifying the sharing mode of the buffer when it will be accessed by
    ///     multiple queue families.
    /// </summary>
    public VkSharingMode sharingMode;

    /// <summary>queueFamilyIndexCount is the number of entries in the pQueueFamilyIndices array.</summary>
    public uint queueFamilyIndexCount;

    /// <summary>
    ///     pQueueFamilyIndices is a pointer to an array of queue families that will access this buffer. It is ignored if
    ///     sharingMode is not VK_SHARING_MODE_CONCURRENT.
    /// </summary>
    public uint* pQueueFamilyIndices;
}