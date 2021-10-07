#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtCalibratedTimestamps
    {
        public const int    VK_EXT_CALIBRATED_TIMESTAMPS                = 1;
        public const int    VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION   = 2;
        public const string VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME = "VK_EXT_calibrated_timestamps";

        public static readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint*,            /* pTimeDomainCount */
            VkTimeDomainEXT*, /* pTimeDomains */
            VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT = null;

        public static readonly delegate*<
            VkDevice,                      /* device */
            uint,                          /* timestampCount */
            VkCalibratedTimestampInfoEXT*, /* pTimestampInfos */
            ulong*,                        /* pTimestamps */
            ulong*,                        /* pMaxDeviation */
            VkResult> vkGetCalibratedTimestampsEXT = null;

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