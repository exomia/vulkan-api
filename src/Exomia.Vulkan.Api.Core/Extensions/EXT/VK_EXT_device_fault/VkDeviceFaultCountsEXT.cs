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
///     VkDeviceFaultCountsEXT - Structure specifying device fault information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultCountsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultCountsEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultCountsEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     addressInfoCount is the number of VkDeviceFaultAddressInfoEXT structures describing either memory accesses
    ///     which may have caused a page fault, or the addresses of active instructions at the time of the fault.
    /// </summary>
    public uint addressInfoCount;

    /// <summary>
    ///     vendorInfoCount is the number of VkDeviceFaultVendorInfoEXTstructures describing vendor-specific fault
    ///     information.
    /// </summary>
    public uint vendorInfoCount;

    /// <summary>
    ///     vendorBinarySize is the size in bytes of a vendor-specific binary crash dump, which may provide additional
    ///     information when imported into external tools.
    /// </summary>
    public VkDeviceSize vendorBinarySize;
}