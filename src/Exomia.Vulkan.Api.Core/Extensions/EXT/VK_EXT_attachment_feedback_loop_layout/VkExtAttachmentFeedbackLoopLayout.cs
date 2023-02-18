#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtAttachmentFeedbackLoopLayout;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_attachment_feedback_loop_layout - device extension (nr. 340) - author 'EXT' [platform '' | contact 'Joshua
///     Ashton @Joshua-Ashton']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_attachment_feedback_loop_layout.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_attachment_feedback_loop_layout.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
public static class VkExtAttachmentFeedbackLoopLayout
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME = "VK_EXT_attachment_feedback_loop_layout";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u415f\u5454\u4341\u4d48\u4e45\u5f54\u4546\u4445\u4142\u4b43\u4c5f\u4f4f\u5f50\u414c\u4f59\u5455\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}