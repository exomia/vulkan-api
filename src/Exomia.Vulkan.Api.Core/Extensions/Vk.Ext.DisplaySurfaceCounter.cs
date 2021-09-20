#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDisplaySurfaceCounter
    {
        public const int    VK_EXT_DISPLAY_SURFACE_COUNTER                = 1;
        public const int    VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION   = 1;
        public const string VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME = "VK_EXT_display_surface_counter";
        
        public static delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkSurfaceKHR,               /* surface */
            VkSurfaceCapabilities2EXT*, /* pSurfaceCapabilities */
            VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

        public static partial void Load(VkInstance vkInstance);
    }
}