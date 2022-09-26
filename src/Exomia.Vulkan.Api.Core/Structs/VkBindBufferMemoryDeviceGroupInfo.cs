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
///     VkBindBufferMemoryDeviceGroupInfo - Structure specifying device within a group to bind to -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryDeviceGroupInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryDeviceGroupInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkBindBufferMemoryInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBindBufferMemoryInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> deviceIndexCount is the number of elements in pDeviceIndices. </summary>
    public uint deviceIndexCount;

    /// <summary> pDeviceIndices is a pointer to an array of device indices. </summary>
    public uint* pDeviceIndices;
}