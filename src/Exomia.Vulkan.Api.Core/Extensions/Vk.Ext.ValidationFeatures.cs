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
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtValidationFeatures
{
    public const int    VK_EXT_VALIDATION_FEATURES                = 1;
    public const int    VK_EXT_VALIDATION_FEATURES_SPEC_VERSION   = 5;
    public const string VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME = "VK_EXT_validation_features";
}

public enum VkValidationFeatureEnableEXT
{
    GPU_ASSISTED_EXT                      = 0,
    GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
    BEST_PRACTICES_EXT                    = 2,
    DEBUG_PRINTF_EXT                      = 3,
    SYNCHRONIZATION_VALIDATION_EXT        = 4,
    MAX_ENUM_EXT                          = 0x7FFFFFFF
}

public enum VkValidationFeatureDisableEXT
{
    ALL_EXT                     = 0,
    SHADERS_EXT                 = 1,
    THREAD_SAFETY_EXT           = 2,
    API_PARAMETERS_EXT          = 3,
    OBJECT_LIFETIMES_EXT        = 4,
    CORE_CHECKS_EXT             = 5,
    UNIQUE_HANDLES_EXT          = 6,
    SHADER_VALIDATION_CACHE_EXT = 7,
    MAX_ENUM_EXT                = 0x7FFFFFFF
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationFeaturesEXT
{
    public const VkStructureType                STYPE = VkStructureType.VALIDATION_FEATURES_EXT;
    public       VkStructureType                sType;
    public       void*                          pNext;
    public       uint                           enabledValidationFeatureCount;
    public       VkValidationFeatureEnableEXT*  pEnabledValidationFeatures;
    public       uint                           disabledValidationFeatureCount;
    public       VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}