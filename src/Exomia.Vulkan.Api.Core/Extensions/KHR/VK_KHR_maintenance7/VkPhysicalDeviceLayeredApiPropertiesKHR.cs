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
///     VkPhysicalDeviceLayeredApiPropertiesKHR - Structure describing a single layered implementation underneath the
///     Vulkan physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiPropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLayeredApiPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>vendorID is a unique identifier for the vendor of the layered implementation.</summary>
    public uint vendorID;

    /// <summary>deviceID is a unique identifier for the layered implementation among devices available from the vendor.</summary>
    public uint deviceID;

    /// <summary>layeredAPI is a VkPhysicalDeviceLayeredApiKHR specifying the API implemented by the layered implementation.</summary>
    public VkPhysicalDeviceLayeredApiKHR layeredAPI;

    /// <summary>
    ///     deviceName is an array of VK_MAX_PHYSICAL_DEVICE_NAME_SIZEchar containing a null-terminated UTF-8 string which
    ///     is the name of the device.
    /// </summary>
    public fixed byte deviceName[(int)VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
}