#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_host_query_reset.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VkExtHostQueryReset
    {
        public const int VK_EXT_HOST_QUERY_RESET              = 1;
        public const int VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;

        [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_host_query_reset.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME = "VK_EXT_host_query_reset";

        public static readonly delegate*<
            VkDevice,    /* device */
            VkQueryPool, /* queryPool */
            uint,        /* firstQuery */
            uint,        /* queryCount */
            void> vkResetQueryPoolEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        hostQueryReset;
    }
}