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
///     VkPhysicalDeviceIDProperties - Structure specifying IDs related to the physical device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceIDProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceIDProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIDProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     deviceUUID is an array of VK_UUID_SIZE uint8_t values representing a universally unique identifier for the
    ///     device.
    /// </summary>
    public fixed byte deviceUUID[(int)VK_UUID_SIZE];

    /// <summary>
    ///     driverUUID is an array of VK_UUID_SIZE uint8_t values representing a universally unique identifier for the
    ///     driver build in use by the device.
    /// </summary>
    public fixed byte driverUUID[(int)VK_UUID_SIZE];

    /// <summary>deviceLUID is an array of VK_LUID_SIZE uint8_t values representing a locally unique identifier for the device.</summary>
    public fixed byte deviceLUID[(int)VK_LUID_SIZE];

    /// <summary>
    ///     deviceNodeMask is a uint32_t bitfield identifying the node within a linked device adapter corresponding to the
    ///     device.
    /// </summary>
    public uint deviceNodeMask;

    /// <summary>
    ///     deviceLUIDValid is a boolean value that will be VK_TRUE if deviceLUID contains a valid LUID and deviceNodeMask
    ///     contains a valid node mask, and VK_FALSE if they do not.
    /// </summary>
    public VkBool32 deviceLUIDValid;
}