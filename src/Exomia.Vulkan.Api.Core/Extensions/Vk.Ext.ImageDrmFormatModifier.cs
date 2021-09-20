#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

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
}
