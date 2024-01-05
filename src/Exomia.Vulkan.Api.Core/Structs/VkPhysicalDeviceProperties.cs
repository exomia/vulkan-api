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
///     VkPhysicalDeviceProperties - Structure specifying physical device properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProperties
{
    /// <summary>
    ///     apiVersion is the version of Vulkan supported by the device, encoded as described in
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-coreversions-versionnumbers.
    /// </summary>
    public VkVersion apiVersion;

    /// <summary>driverVersion is the vendor-specified version of the driver.</summary>
    public VkVersion driverVersion;

    /// <summary>vendorID is a unique identifier for the vendor (see below) of the physical device.</summary>
    public uint vendorID;

    /// <summary>deviceID is a unique identifier for the physical device among devices available from the vendor.</summary>
    public uint deviceID;

    /// <summary>deviceType is a VkPhysicalDeviceType specifying the type of device.</summary>
    public VkPhysicalDeviceType deviceType;

    /// <summary>
    ///     deviceName is an array of VK_MAX_PHYSICAL_DEVICE_NAME_SIZEchar containing a null-terminated UTF-8 string which
    ///     is the name of the device.
    /// </summary>
    public fixed byte deviceName[(int)VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];

    /// <summary>
    ///     pipelineCacheUUID is an array of VK_UUID_SIZE uint8_tvalues representing a universally unique identifier for
    ///     the device.
    /// </summary>
    public fixed byte pipelineCacheUUID[(int)VK_UUID_SIZE];

    /// <summary>
    ///     limits is the VkPhysicalDeviceLimits structure specifying device-specific limits of the physical device. See
    ///     Limits for details.
    /// </summary>
    public VkPhysicalDeviceLimits limits;

    /// <summary>
    ///     sparseProperties is the VkPhysicalDeviceSparsePropertiesstructure specifying various sparse related properties
    ///     of the physical device. See Sparse Properties for details.
    /// </summary>
    public VkPhysicalDeviceSparseProperties sparseProperties;
}