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
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [Obsolete(
        "Deprecated by VK_KHR_shader_float16_int8 extension - Which in turn was promoted to Vulkan 1.2", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_gpu_shader_half_float.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VKAmdGpuShaderHalfFloat
    {
        public const int VK_AMD_GPU_SHADER_HALF_FLOAT              = 1;
        public const int VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = 2;

        [Obsolete(
            "Deprecation by VK_KHR_shader_float16_int8", false,
            UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_gpu_shader_half_float.html#_deprecation_by_vk_khr_shader_float16_int8")]
        public const string VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME = "VK_AMD_gpu_shader_half_float";
    }
}