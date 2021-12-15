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
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VkAmdDisplayNativeHdr
    {
        public const int    VK_AMD_DISPLAY_NATIVE_HDR                = 1;
        public const int    VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION   = 1;
        public const string VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME = "VK_AMD_display_native_hdr";

        public static readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapChain */
            uint,           /* localDimmingEnable */
            void> vkSetLocalDimmingAMD = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public const VkStructureType STYPE = VkStructureType.DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        localDimmingSupport;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public const VkStructureType STYPE = VkStructureType.SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        localDimmingEnable;
    }
}