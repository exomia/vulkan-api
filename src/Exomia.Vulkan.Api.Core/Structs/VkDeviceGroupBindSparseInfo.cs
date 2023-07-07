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
///     VkDeviceGroupBindSparseInfo - Structure indicating which instances are bound -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupBindSparseInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupBindSparseInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkBindSparseInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBindSparseInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupBindSparseInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>resourceDeviceIndex is a device index indicating which instance of the resource is bound.</summary>
    public uint resourceDeviceIndex;

    /// <summary>memoryDeviceIndex is a device index indicating which instance of the memory the resource instance is bound to.</summary>
    public uint memoryDeviceIndex;
}