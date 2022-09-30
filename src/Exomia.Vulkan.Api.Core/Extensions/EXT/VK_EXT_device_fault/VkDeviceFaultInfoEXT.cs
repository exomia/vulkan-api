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
///     VkDeviceFaultInfoEXT - Structure specifying device fault information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceFaultInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     description is an array of VK_MAX_DESCRIPTION_SIZE charcontaining a null-terminated UTF-8 string which is a
    ///     human readable description of the fault.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     pAddressInfos is NULL or a pointer to an array of VkDeviceFaultAddressInfoEXT structures describing either
    ///     memory accesses which may have caused a page fault, or describing active instruction pointers at the time of the
    ///     fault. If not NULL, each element of pAddressInfos describes the a bounded region of GPU virtual address space
    ///     containing either the GPU virtual address accessed, or the value of an active instruction pointer.
    /// </summary>
    public VkDeviceFaultAddressInfoEXT* pAddressInfos;

    /// <summary>
    ///     pVendorInfos is NULL or a pointer to an array of VkDeviceFaultVendorInfoEXT structures describing
    ///     vendor-specific fault information.
    /// </summary>
    public VkDeviceFaultVendorInfoEXT* pVendorInfos;

    /// <summary>
    ///     pVendorBinaryData is NULL or a pointer to vendorBinarySizenumber of bytes of data, which will be populated
    ///     with a vendor-specific binary crash dump, as described in Vendor Binary Crash Dumps.
    /// </summary>
    public void* pVendorBinaryData;
}