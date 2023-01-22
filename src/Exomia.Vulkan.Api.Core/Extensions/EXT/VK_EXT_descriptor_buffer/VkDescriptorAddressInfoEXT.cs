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
///     VkDescriptorAddressInfoEXT - Structure specifying descriptor buffer address info -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorAddressInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorAddressInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorAddressInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     address is either 0 or a device address at an offset in a buffer, where the base address can be queried from
    ///     vkGetBufferDeviceAddress.
    /// </summary>
    public VkDeviceAddress address;

    /// <summary>range is the size in bytes of the buffer or buffer view used by the descriptor.</summary>
    public VkDeviceSize range;

    /// <summary>format is the format of the data elements in the buffer view and is ignored for buffers.</summary>
    public VkFormat format;
}