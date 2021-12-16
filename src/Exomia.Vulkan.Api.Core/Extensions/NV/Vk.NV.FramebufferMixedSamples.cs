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
namespace Exomia.Vulkan.Api.Core.Extensions.NV;

[VkExtGenerator]
public static partial class VkNvFramebufferMixedSamples
{
    public const int    VK_NV_FRAMEBUFFER_MIXED_SAMPLES                = 1;
    public const int    VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION   = 1;
    public const string VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME = "VK_NV_framebuffer_mixed_samples";
}

public enum VkCoverageModulationModeNV
{
    NONE_NV     = 0,
    RGB_NV      = 1,
    ALPHA_NV    = 2,
    RGBA_NV     = 3,
    MAX_ENUM_NV = 0x7FFFFFFF
}

[Flags]
public enum VkPipelineCoverageModulationStateCreateFlagsNV : uint
{
    /// <summary>
    ///     Reserved for future use
    /// </summary>
    Reserved = 0
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
    public const VkStructureType                                STYPE = VkStructureType.PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV;
    public       VkStructureType                                sType;
    public       void*                                          pNext;
    public       VkPipelineCoverageModulationStateCreateFlagsNV flags;
    public       VkCoverageModulationModeNV                     coverageModulationMode;
    public       VkBool32                                       coverageModulationTableEnable;
    public       uint                                           coverageModulationTableCount;
    public       float*                                         pCoverageModulationTable;
}