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
///     VkDeviceFaultAddressInfoEXT - Structure specifying GPU virtual address information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDeviceFaultAddressInfoEXT
{
    /// <summary>
    ///     addressType is either the type of memory operation that triggered a page fault, or the type of association
    ///     between an instruction pointer and a fault.
    /// </summary>
    public VkDeviceFaultAddressTypeEXT addressType;

    /// <summary>reportedAddress is the GPU virtual address recorded by the device.</summary>
    public VkDeviceAddress reportedAddress;

    /// <summary>addressPrecision is a power of two value that specifies how precisely the device can report the address.</summary>
    public VkDeviceSize addressPrecision;
}