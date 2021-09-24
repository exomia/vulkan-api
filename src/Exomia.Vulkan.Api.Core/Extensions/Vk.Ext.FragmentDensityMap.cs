#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtFragmentDensityMap
    {
        public const int    VK_EXT_FRAGMENT_DENSITY_MAP                = 1;
        public const int    VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION   = 1;
        public const string VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME = "VK_EXT_fragment_density_map";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        fragmentDensityMap;
        public       VkBool32        fragmentDensityMapDynamic;
        public       VkBool32        fragmentDensityMapNonSubsampledImages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkExtent2D      minFragmentDensityTexelSize;
        public       VkExtent2D      maxFragmentDensityTexelSize;
        public       VkBool32        fragmentDensityInvocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public const VkStructureType       STYPE = VkStructureType.RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkAttachmentReference fragmentDensityMapAttachment;
    }
}