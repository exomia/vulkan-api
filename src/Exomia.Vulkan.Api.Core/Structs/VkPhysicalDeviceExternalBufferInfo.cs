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
///     VkPhysicalDeviceExternalBufferInfo - Structure specifying buffer creation parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalBufferInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalBufferInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkBufferCreateFlagBits describing additional parameters of the buffer, corresponding to
    ///     VkBufferCreateInfo::flags.
    /// </summary>
    public VkBufferCreateFlags flags;

    /// <summary>
    ///     usage is a bitmask of VkBufferUsageFlagBits describing the intended usage of the buffer, corresponding to
    ///     VkBufferCreateInfo::usage.
    /// </summary>
    public VkBufferUsageFlags usage;

    /// <summary>
    ///     handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the memory handle type that will be used
    ///     with the memory associated with the buffer.
    /// </summary>
    public VkExternalMemoryHandleTypeFlagBits handleType;
}