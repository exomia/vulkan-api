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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_separate_stencil_usage.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtSeparateStencilUsage
    {
        public const int VK_EXT_SEPARATE_STENCIL_USAGE              = 1;
        public const int VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = 1;

        [Obsolete(
            "Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_separate_stencil_usage.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME = "VK_EXT_separate_stencil_usage";
    }
}