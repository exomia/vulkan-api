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
///     VkPhysicalDeviceDriverProperties - Structure containing driver identification information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDriverProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDriverProperties.html
///     </a>
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
public unsafe struct VkPhysicalDeviceDriverProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>driverID is a unique identifier for the driver of the physical device.</summary>
    public VkDriverId driverID;

    /// <summary>
    ///     driverName is an array of VK_MAX_DRIVER_NAME_SIZE charcontaining a null-terminated UTF-8 string which is the
    ///     name of the driver.
    /// </summary>
    public fixed byte driverName[(int)VK_MAX_DRIVER_NAME_SIZE];

    /// <summary>
    ///     driverInfo is an array of VK_MAX_DRIVER_INFO_SIZE charcontaining a null-terminated UTF-8 string with
    ///     additional information about the driver.
    /// </summary>
    public fixed byte driverInfo[(int)VK_MAX_DRIVER_INFO_SIZE];

    /// <summary>
    ///     conformanceVersion is the version of the Vulkan conformance test this driver is conformant against (see
    ///     VkConformanceVersion).
    /// </summary>
    public VkConformanceVersion conformanceVersion;
}