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
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [Obsolete(
        "Deprecated by VK_KHR_external_memory_capabilities extension - Which in turn was promoted to Vulkan 1.1", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_NV_external_memory_capabilities.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VkNvExternalMemoryCapabilities
    {
        public const int    VK_NV_EXTERNAL_MEMORY_CAPABILITIES                = 1;
        public const int    VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION   = 1;
        public const string VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = "VK_NV_external_memory_capabilities";

        public static readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkFormat,                           /* format */
            VkImageType,                        /* type */
            VkImageTiling,                      /* tiling */
            VkImageUsageFlagBits,               /* usage */
            VkImageCreateFlagBits,              /* FlagBits */
            VkExternalMemoryHandleTypeFlagsNV,  /* externalHandleType */
            VkExternalImageFormatPropertiesNV*, /* pExternalImageFormatProperties */
            VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV = null;

        public static partial void Load(VkInstance vkInstance);
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV
    {
        DEDICATED_ONLY_BIT_NV = 0x00000001,
        EXPORTABLE_BIT_NV     = 0x00000002,
        IMPORTABLE_BIT_NV     = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsNV
    {
        OPAQUE_WIN32_BIT_NV     = 0x00000001,
        OPAQUE_WIN32_KMT_BIT_NV = 0x00000002,
        D3D11_IMAGE_BIT_NV      = 0x00000004,
        D3D11_IMAGE_KMT_BIT_NV  = 0x00000008,
        FLAG_BITS_MAX_ENUM_NV   = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties           imageFormatProperties;
        public VkExternalMemoryFeatureFlagsNV    externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }
}