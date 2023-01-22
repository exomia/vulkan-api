#region License

// Copyright (c) 2018-2023, exomia
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
///     VkAttachmentDescriptionFlagBits - Bitmask specifying additional properties of an attachment -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkAttachmentDescriptionFlagBits
{
    /// <summary>
    ///     VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT specifies that the attachment aliases the same device memory as other
    ///     attachments.
    /// </summary>
    VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = 0x1
}