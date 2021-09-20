#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtSampleLocations
    {
        public const int    VK_EXT_SAMPLE_LOCATIONS                = 1;
        public const int    VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION   = 1;
        public const string VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME = "VK_EXT_sample_locations";
        
        public static delegate*<
            VkCommandBuffer,           /* commandBuffer */
            VkSampleLocationsInfoEXT*, /* pSampleLocationsInfo */
            void> vkCmdSetSampleLocationsEXT;

        public static delegate*<
            VkPhysicalDevice,            /* physicalDevice */
            VkSampleCountFlagBits,       /* samples */
            VkMultisamplePropertiesEXT*, /* pMultisampleProperties */
            void> vkGetPhysicalDeviceMultisamplePropertiesEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
