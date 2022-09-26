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
///     VkBindImageMemoryDeviceGroupInfo - Structure specifying device within a group to bind to -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryDeviceGroupInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryDeviceGroupInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkBindImageMemoryInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBindImageMemoryInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> deviceIndexCount is the number of elements in pDeviceIndices. </summary>
    public uint deviceIndexCount;

    /// <summary> pDeviceIndices is a pointer to an array of device indices. </summary>
    public uint* pDeviceIndices;

    /// <summary> splitInstanceBindRegionCount is the number of elements in pSplitInstanceBindRegions. </summary>
    public uint splitInstanceBindRegionCount;

    /// <summary> pSplitInstanceBindRegions is a pointer to an array of VkRect2D structures describing which regions of the image are attached to each instance of memory. </summary>
    public VkRect2D* pSplitInstanceBindRegions;
}