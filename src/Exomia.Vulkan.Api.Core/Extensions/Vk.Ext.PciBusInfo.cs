#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtPciBusInfo
{
    public const int    VK_EXT_PCI_BUS_INFO                = 1;
    public const int    VK_EXT_PCI_BUS_INFO_SPEC_VERSION   = 2;
    public const string VK_EXT_PCI_BUS_INFO_EXTENSION_NAME = "VK_EXT_pci_bus_info";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       uint            pciDomain;
    public       uint            pciBus;
    public       uint            pciDevice;
    public       uint            pciFunction;
}