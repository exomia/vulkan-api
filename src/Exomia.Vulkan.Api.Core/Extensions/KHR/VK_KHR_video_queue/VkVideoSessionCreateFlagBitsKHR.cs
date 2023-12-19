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
///     VkVideoSessionCreateFlagBitsKHR - Video session creation flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoSessionCreateFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR specifies that the video session uses protected video
    ///     content.
    /// </summary>
    VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoSessionCreateFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoSessionCreateFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR specifies that queries within video coding scopes using the created
    ///     video session are
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-inline-queries">
    ///         executed
    ///         inline
    ///     </a>
    ///     with video coding operations.
    /// </summary>
    VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR = 0x4
}