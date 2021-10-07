#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static unsafe partial class VkExtAcquireDrmDisplay
    {
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY                = 1;
        public const int    VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION   = 1;
        public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_NV_coverage_reduction_mode";
        public static readonly delegate*<
    VkPhysicalDevice, /* physicalDevice */
    uint*, /* pCombinationCount */
    VkFramebufferMixedSamplesCombinationNV*, /* pCombinations */
    VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = null;

        public static partial void Load(VkInstance vkInstance);
    }

    public enum VkCoverageReductionModeNV
    {
        MERGE_NV    = 0,
        TRUNCATE_NV = 1,
        MAX_ENUM_NV = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineCoverageReductionStateCreateFlagsNV : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFramebufferMixedSamplesCombinationNV
    {
        public const VkStructureType           STYPE = VkStructureType.FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV;
        public       VkStructureType           sType;
        public       void*                     pNext;
        public       VkCoverageReductionModeNV coverageReductionMode;
        public       VkSampleCountFlagBits     rasterizationSamples;
        public       VkSampleCountFlagBits     depthStencilSamples;
        public       VkSampleCountFlagBits     colorSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        coverageReductionMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public const VkStructureType                               STYPE = VkStructureType.PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV;
        public       VkStructureType                               sType;
        public       void*                                         pNext;
        public       VkPipelineCoverageReductionStateCreateFlagsNV flags;
        public       VkCoverageReductionModeNV                     coverageReductionMode;
    }
}