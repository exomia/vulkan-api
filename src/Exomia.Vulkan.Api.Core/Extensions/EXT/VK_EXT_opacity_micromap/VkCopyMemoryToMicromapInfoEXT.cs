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
///     VkCopyMemoryToMicromapInfoEXT - Parameters for deserializing a micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToMicromapInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToMicromapInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToMicromapInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>src is the device or host address to memory containing the source data for the copy.</summary>
    public VkDeviceOrHostAddressConstKHR src;

    /// <summary>dst is the target micromap for the copy.</summary>
    public VkMicromapEXT dst;

    /// <summary>mode is a VkCopyMicromapModeEXT value specifying additional operations to perform during the copy.</summary>
    public VkCopyMicromapModeEXT mode;
}