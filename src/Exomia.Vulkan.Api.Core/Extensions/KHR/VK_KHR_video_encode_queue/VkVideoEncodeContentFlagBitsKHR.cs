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
///     VkVideoEncodeContentFlagBitsKHR - Video encode content flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeContentFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeContentFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeContentFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeContentFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoEncodeContentFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR = 0,

    /// <summary>
    ///     VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR specifies that video encoding is intended to be used to encode camera
    ///     content.
    /// </summary>
    VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR specifies that video encoding is intended to be used to encode desktop
    ///     content.
    /// </summary>
    VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR specified that video encoding is intended to be used to encode
    ///     rendered (e.g. game) content.
    /// </summary>
    VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR = 0x4
}