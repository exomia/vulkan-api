#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkFramebufferCreateFlagBits - Bitmask specifying framebuffer properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateFlagBits.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateFlagBits.html </a>
/// </summary>
[Flags]
public enum VkFramebufferCreateFlagBits
{
    /// <summary>
    ///     VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT specifies that image views are not specified, and only attachment compatibility information will be provided via a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentImageInfo.html">
    ///         VkFramebufferAttachmentImageInfo
    ///     </a>
    ///     structure.
    /// </summary>
    VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = 0x1,

    /// <summary>
    ///     VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT specifies that image views are not specified, and only attachment compatibility information will be provided via a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentImageInfo.html">
    ///         VkFramebufferAttachmentImageInfo
    ///     </a>
    ///     structure.
    /// </summary>
    VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR = VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT
}