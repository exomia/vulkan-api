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
        "Obsoleted by VK_KHR_maintenance1 extension - Which in turn was promoted to Vulkan 1.1", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_negative_viewport_height.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkAmdNegativeViewportHeight
    {
        public const int VK_AMD_NEGATIVE_VIEWPORT_HEIGHT              = 1;
        public const int VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;

        [Obsolete(
            "Obsoletion by VK_KHR_maintenance1 and Vulkan 1.1", false,
            UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_negative_viewport_height.html#_obsoletion_by_vk_khr_maintenance1_and_vulkan_1_1")]
        public const string VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME = "VK_AMD_negative_viewport_height";
    }
}