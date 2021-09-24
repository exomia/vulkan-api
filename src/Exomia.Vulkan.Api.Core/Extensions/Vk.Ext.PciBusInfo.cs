#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
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
}