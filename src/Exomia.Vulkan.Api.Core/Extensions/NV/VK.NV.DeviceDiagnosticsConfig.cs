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
    [VkExtGenerator]
    public static unsafe partial class VKNvDeviceDiagnosticsConfig
    {
        public const int    VK_NV_DEVICE_DIAGNOSTICS_CONFIG                = 1;
        public const int    VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION   = 1;
        public const string VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME = "VK_NV_device_diagnostics_config";
    }


    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagsNV
    {
        ENABLE_SHADER_DEBUG_INFO_BIT_NV     = 0x00000001,
        ENABLE_RESOURCE_TRACKING_BIT_NV     = 0x00000002,
        ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV               = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public const VkStructureType                  STYPE = VkStructureType.DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV;
        public       VkStructureType                  sType;
        public       void*                            pNext;
        public       VkDeviceDiagnosticsConfigFlagsNV flags;
    }


    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        diagnosticsConfig;
    }




}