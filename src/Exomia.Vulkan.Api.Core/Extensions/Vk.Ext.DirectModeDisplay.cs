#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDirectModeDisplay
    {
        public const int    VK_EXT_DIRECT_MODE_DISPLAY                = 1;
        public const int    VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION   = 1;
        public const string VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME = "VK_EXT_direct_mode_display";
        
        public static delegate*<
            VkPhysicalDevice, /* physicalDevice */
            VkDisplayKHR,     /* display */
            VkResult> vkReleaseDisplayEXT;

        public static partial void Load(VkInstance vkInstance);
    }
}
