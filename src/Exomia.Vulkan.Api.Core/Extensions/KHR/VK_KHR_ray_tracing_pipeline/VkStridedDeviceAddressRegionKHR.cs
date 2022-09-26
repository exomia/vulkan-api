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
///     VkStridedDeviceAddressRegionKHR - Structure specifying a region of device addresses with a stride -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStridedDeviceAddressRegionKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStridedDeviceAddressRegionKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkStridedDeviceAddressRegionKHR
{
    /// <summary> deviceAddress is the device address (as returned by the vkGetBufferDeviceAddress command) at which the region starts, or zero if the region is unused. </summary>
    public VkDeviceAddress deviceAddress;

    /// <summary> stride is the byte stride between consecutive elements. </summary>
    public VkDeviceSize stride;

    /// <summary> size is the size in bytes of the region starting at deviceAddress. </summary>
    public VkDeviceSize size;
}