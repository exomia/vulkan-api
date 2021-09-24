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
    public static partial class VkExtAstcDecodeMode
    {
        public const int    VK_EXT_ASTC_DECODE_MODE                = 1;
        public const int    VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION   = 1;
        public const string VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME = "VK_EXT_astc_decode_mode";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewASTCDecodeModeEXT
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_VIEW_ASTC_DECODE_MODE_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkFormat        decodeMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        decodeModeSharedExponent;
    }
}