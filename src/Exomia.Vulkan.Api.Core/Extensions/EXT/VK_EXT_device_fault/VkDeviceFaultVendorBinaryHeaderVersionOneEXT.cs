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
///     VkDeviceFaultVendorBinaryHeaderVersionOneEXT - Structure describing the layout of the vendor binary crash dump
///     header -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorBinaryHeaderVersionOneEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorBinaryHeaderVersionOneEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    /// <summary>headerSize is the length in bytes of the crash dump header.</summary>
    public uint headerSize;

    /// <summary>
    ///     headerVersion is a VkDeviceFaultVendorBinaryHeaderVersionEXTenum value specifying the version of the header. A
    ///     consumer of the crash dump should use the header version to interpret the remainder of the header.
    /// </summary>
    public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;

    /// <summary>vendorID is the VkPhysicalDeviceProperties::vendorIDof the implementation.</summary>
    public uint vendorID;

    /// <summary>deviceID is the VkPhysicalDeviceProperties::deviceIDof the implementation.</summary>
    public uint deviceID;

    /// <summary>driverVersion is the VkPhysicalDeviceProperties::driverVersion of the implementation.</summary>
    public VkVersion driverVersion;

    /// <summary>
    ///     pipelineCacheUUID is an array of VK_UUID_SIZE uint8_tvalues matching the
    ///     VkPhysicalDeviceProperties::pipelineCacheUUID property of the implementation.
    /// </summary>
    public fixed byte pipelineCacheUUID[(int)VK_UUID_SIZE];

    /// <summary>
    ///     applicationNameOffset is zero, or an offset from the base address of the crash dump header to a
    ///     null-terminated UTF-8 string containing the name of the application. If applicationNameOffset is non-zero, this
    ///     string must match the application name specified via VkApplicationInfo::pApplicationName during instance creation.
    /// </summary>
    public uint applicationNameOffset;

    /// <summary>
    ///     applicationVersion must be zero or the value specified by VkApplicationInfo::applicationVersion during
    ///     instance creation.
    /// </summary>
    public VkVersion applicationVersion;

    /// <summary>
    ///     engineNameOffset is zero, or an offset from the base address of the crash dump header to a null-terminated
    ///     UTF-8 string containing the name of the engine (if any) used to create the application. If engineNameOffset is
    ///     non-zero, this string must match the engine name specified via VkApplicationInfo::pEngineNameduring instance
    ///     creation.
    /// </summary>
    public uint engineNameOffset;

    /// <summary>
    ///     engineVersion must be zero or the value specified by VkApplicationInfo::engineVersion during instance
    ///     creation.
    /// </summary>
    public VkVersion engineVersion;

    /// <summary>apiVersion must be zero or the value specified by VkApplicationInfo::apiVersion during instance creation.</summary>
    public VkVersion apiVersion;
}