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
///     VkDeviceFaultVendorInfoEXT - Structure specifying vendor-specific fault information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultVendorInfoEXT
{
    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a
    ///     human readable description of the fault.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>vendorFaultCode is the vendor-specific fault code for this fault.</summary>
    public ulong vendorFaultCode;

    /// <summary>vendorFaultData is the vendor-specific fault data associated with this fault.</summary>
    public ulong vendorFaultData;
}