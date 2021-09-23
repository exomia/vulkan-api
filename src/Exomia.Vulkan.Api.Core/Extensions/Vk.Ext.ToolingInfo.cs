#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtToolingInfo
    {
        public const int    VK_EXT_TOOLING_INFO                = 1;
        public const int    VK_EXT_TOOLING_INFO_SPEC_VERSION   = 1;
        public const string VK_EXT_TOOLING_INFO_EXTENSION_NAME = "VK_EXT_tooling_info";
        
        public static delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            uint*,                              /* pToolCount */
            VkPhysicalDeviceToolPropertiesEXT*, /* pToolProperties */
            VkResult> vkGetPhysicalDeviceToolPropertiesEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
