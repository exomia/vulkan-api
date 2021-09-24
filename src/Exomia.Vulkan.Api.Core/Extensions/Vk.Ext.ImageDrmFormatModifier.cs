#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtImageDrmFormatModifier
    {
        public const int    VK_EXT_IMAGE_DRM_FORMAT_MODIFIER                = 1;
        public const int    VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION   = 1;
        public const string VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME = "VK_EXT_image_drm_format_modifier";
        
        public static delegate*<
            VkDevice,                               /* device */
            VkImage,                                /* image */
            VkImageDrmFormatModifierPropertiesEXT*, /* pProperties */
            VkResult> vkGetImageDrmFormatModifierPropertiesEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlagBits drmFormatModifierTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public const VkStructureType STYPE = VkStructureType.DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
    }
}