#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrVideoEncodeAv1;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_video_encode_av1 - device extension (nr. 514) - author 'KHR' [platform '' | contact 'Daniel Rakos @aqnuep']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_av1.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_av1.html</a>
/// </summary>
[VkDepends("VK_KHR_video_encode_queue")]
[VkDeviceExt]
public static class VkKhrVideoEncodeAv1
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_VIDEO_ENCODE_AV1_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME = "VK_KHR_video_encode_av1";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u565f\u4449\u4f45\u455f\u434e\u444f\u5f45\u5641\u5f31\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    public const uint VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR = 7;
}