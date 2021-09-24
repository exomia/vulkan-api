#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

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

    public enum VkTimeDomainEXT
    {
        DEVICE_EXT                    = 0,
        CLOCK_MONOTONIC_EXT           = 1,
        CLOCK_MONOTONIC_RAW_EXT       = 2,
        QUERY_PERFORMANCE_COUNTER_EXT = 3,
        MAX_ENUM_EXT                  = 0x7FFFFFFF
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCalibratedTimestampInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.CALIBRATED_TIMESTAMP_INFO_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkTimeDomainEXT timeDomain;
    }
}