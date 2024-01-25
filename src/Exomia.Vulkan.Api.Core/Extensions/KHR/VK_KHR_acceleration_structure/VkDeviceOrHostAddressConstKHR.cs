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
///     VkDeviceOrHostAddressConstKHR - Union specifying a const device or host address -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceOrHostAddressConstKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceOrHostAddressConstKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressConstKHR
{
    /// <summary>deviceAddress is a buffer device address as returned by the vkGetBufferDeviceAddressKHR command.</summary>
    [FieldOffset(0)]
    public VkDeviceAddress deviceAddress;

    /// <summary>hostAddress is a const host memory address.</summary>
    [FieldOffset(0)]
    public void* hostAddress;
}