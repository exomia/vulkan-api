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
///     VkBufferUsageFlags2CreateInfoKHR - Extended buffer usage flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlags2CreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlags2CreateInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkBufferViewCreateInfo,VkBufferCreateInfo,VkPhysicalDeviceExternalBufferInfo,VkDescriptorBufferBindingInfoEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBufferViewCreateInfo,VkBufferCreateInfo,VkPhysicalDeviceExternalBufferInfo,VkDescriptorBufferBindingInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferUsageFlags2CreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>usage is a bitmask of VkBufferUsageFlagBits2KHR specifying allowed usages of the buffer.</summary>
    public VkBufferUsageFlags2KHR usage;
}