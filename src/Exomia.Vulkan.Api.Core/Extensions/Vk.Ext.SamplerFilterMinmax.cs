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
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_sampler_filter_minmax.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtSamplerFilterMinmax
    {
        public const int VK_EXT_SAMPLER_FILTER_MINMAX              = 1;
        public const int VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = 2;

        [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_sampler_filter_minmax.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME = "VK_EXT_sampler_filter_minmax";
    }

    public enum VkSamplerReductionModeEXT
    {
        WEIGHTED_AVERAGE     = 0,
        MIN                  = 1,
        MAX                  = 2,
        WEIGHTED_AVERAGE_EXT = WEIGHTED_AVERAGE,
        MIN_EXT              = MIN,
        MAX_EXT              = MAX,
        MAX_ENUM             = 0x7FFFFFFF
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerReductionModeCreateInfoEXT
    {
        public const VkStructureType           STYPE = VkStructureType.SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT;
        public       VkStructureType           sType;
        public       void*                     pNext;
        public       VkSamplerReductionModeEXT reductionMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        filterMinmaxSingleComponentFormats;
        public       VkBool32        filterMinmaxImageComponentMapping;
    }
}