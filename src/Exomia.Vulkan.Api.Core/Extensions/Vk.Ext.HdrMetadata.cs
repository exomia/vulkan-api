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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtHdrMetadata
    {
        public const int    VK_EXT_HDR_METADATA                = 1;
        public const int    VK_EXT_HDR_METADATA_SPEC_VERSION   = 2;
        public const string VK_EXT_HDR_METADATA_EXTENSION_NAME = "VK_EXT_hdr_metadata";

        public static delegate*<
            VkDevice,          /* device */
            uint,              /* swapchainCount */
            VkSwapchainKHR*,   /* pSwapchains */
            VkHdrMetadataEXT*, /* pMetadata */
            void> vkSetHdrMetadataEXT;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkXYColorEXT
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkHdrMetadataEXT
    {
        public const VkStructureType STYPE = VkStructureType.HDR_METADATA_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkXYColorEXT    displayPrimaryRed;
        public       VkXYColorEXT    displayPrimaryGreen;
        public       VkXYColorEXT    displayPrimaryBlue;
        public       VkXYColorEXT    whitePoint;
        public       float           maxLuminance;
        public       float           minLuminance;
        public       float           maxContentLightLevel;
        public       float           maxFrameAverageLightLevel;
    }
}