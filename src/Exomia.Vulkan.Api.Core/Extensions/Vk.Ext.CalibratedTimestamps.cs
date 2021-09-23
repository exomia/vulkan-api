#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtCalibratedTimestamps
    {
        public const int    VK_EXT_CALIBRATED_TIMESTAMPS                = 1;
        public const int    VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION   = 2;
        public const string VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME = "VK_EXT_calibrated_timestamps";
        
        public static delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint*,            /* pTimeDomainCount */
            VkTimeDomainEXT*, /* pTimeDomains */
            VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
        
        public static delegate*<
            VkDevice,                      /* device */
            uint,                          /* timestampCount */
            VkCalibratedTimestampInfoEXT*, /* pTimestampInfos */
            ulong*,                        /* pTimestamps */
            ulong*,                        /* pMaxDeviation */
            VkResult> vkGetCalibratedTimestampsEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}