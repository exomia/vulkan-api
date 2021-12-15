﻿#region License

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
    public static partial class VkExt4444Formats
    {
        public const int    VK_EXT_4444_FORMATS                = 1;
        public const int    VK_EXT_4444_FORMATS_SPEC_VERSION   = 1;
        public const string VK_EXT_4444_FORMATS_EXTENSION_NAME = "VK_EXT_4444_formats";
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        formatA4R4G4B4;
        public       VkBool32        formatA4B4G4R4;
    }
}