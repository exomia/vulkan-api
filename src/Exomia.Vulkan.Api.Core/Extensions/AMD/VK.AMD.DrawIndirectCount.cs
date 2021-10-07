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
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [Obsolete("Promoted to VK_KHR_draw_indirect_count extension - Which in turn was promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_draw_indirect_count.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VKAmdDrawIndirectCount
    {
        public const int    VK_AMD_DRAW_INDIRECT_COUNT                = 1;
        public const int    VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION   = 2;
        [Obsolete("Promoted to VK_KHR_draw_indirect_count", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_AMD_draw_indirect_count.html#_promotion_to_vk_khr_draw_indirect_count")]
        public const string VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME = "VK_AMD_draw_indirect_count";
        
        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer, /* buffer */
            VkDeviceSize, /* offset */
            VkBuffer, /* countBuffer */
            VkDeviceSize, /* countBufferOffset */
            uint, /* maxDrawCount */
            uint, /* stride */
            void> vkCmdDrawIndexedIndirectCountAMD = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer, /* buffer */
            VkDeviceSize, /* offset */
            VkBuffer, /* countBuffer */
            VkDeviceSize, /* countBufferOffset */
            uint, /* maxDrawCount */
            uint, /* stride */
            void> vkCmdDrawIndirectCountAMD = null;


        public static partial void Load(VkDevice vkDevice);
    }
}