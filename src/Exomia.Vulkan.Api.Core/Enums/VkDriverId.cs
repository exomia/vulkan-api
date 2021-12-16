#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

public enum VkDriverId
{
    AMD_PROPRIETARY               = 1,
    AMD_OPEN_SOURCE               = 2,
    MESA_RADV                     = 3,
    NVIDIA_PROPRIETARY            = 4,
    INTEL_PROPRIETARY_WINDOWS     = 5,
    INTEL_OPEN_SOURCE_MESA        = 6,
    IMAGINATION_PROPRIETARY       = 7,
    QUALCOMM_PROPRIETARY          = 8,
    ARM_PROPRIETARY               = 9,
    GOOGLE_SWIFTSHADER            = 10,
    GGP_PROPRIETARY               = 11,
    BROADCOM_PROPRIETARY          = 12,
    MESA_LLVMPIPE                 = 13,
    MOLTENVK                      = 14,
    COREAVI_PROPRIETARY           = 15,
    JUICE_PROPRIETARY             = 16,
    AMD_PROPRIETARY_KHR           = AMD_PROPRIETARY,
    AMD_OPEN_SOURCE_KHR           = AMD_OPEN_SOURCE,
    MESA_RADV_KHR                 = MESA_RADV,
    NVIDIA_PROPRIETARY_KHR        = NVIDIA_PROPRIETARY,
    INTEL_PROPRIETARY_WINDOWS_KHR = INTEL_PROPRIETARY_WINDOWS,
    INTEL_OPEN_SOURCE_MESA_KHR    = INTEL_OPEN_SOURCE_MESA,
    IMAGINATION_PROPRIETARY_KHR   = IMAGINATION_PROPRIETARY,
    QUALCOMM_PROPRIETARY_KHR      = QUALCOMM_PROPRIETARY,
    ARM_PROPRIETARY_KHR           = ARM_PROPRIETARY,
    GOOGLE_SWIFTSHADER_KHR        = GOOGLE_SWIFTSHADER,
    GGP_PROPRIETARY_KHR           = GGP_PROPRIETARY,
    BROADCOM_PROPRIETARY_KHR      = BROADCOM_PROPRIETARY,
    MAX_ENUM                      = 0x7FFFFFFF
}