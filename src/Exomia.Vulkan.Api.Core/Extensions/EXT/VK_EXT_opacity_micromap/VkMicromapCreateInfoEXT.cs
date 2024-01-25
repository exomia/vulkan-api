#region License

// Copyright (c) 2018-2024, exomia
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
///     VkMicromapCreateInfoEXT - Structure specifying the parameters of a newly created micromap object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     createFlags is a bitmask of VkMicromapCreateFlagBitsEXTspecifying additional creation parameters of the
    ///     micromap.
    /// </summary>
    public VkMicromapCreateFlagsEXT createFlags;

    /// <summary>buffer is the buffer on which the micromap will be stored.</summary>
    public VkBuffer buffer;

    /// <summary>
    ///     offset is an offset in bytes from the base address of the buffer at which the micromap will be stored, and
    ///     must be a multiple of 256.
    /// </summary>
    public VkDeviceSize offset;

    /// <summary>size is the size required for the micromap.</summary>
    public VkDeviceSize size;

    /// <summary>type is a VkMicromapTypeEXT value specifying the type of micromap that will be created.</summary>
    public VkMicromapTypeEXT type;

    /// <summary>
    ///     deviceAddress is the device address requested for the micromap if the micromapCaptureReplayfeature is being
    ///     used.
    /// </summary>
    public VkDeviceAddress deviceAddress;
}