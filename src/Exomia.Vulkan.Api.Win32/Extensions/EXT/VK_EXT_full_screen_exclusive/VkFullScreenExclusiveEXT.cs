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
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VkFullScreenExclusiveEXT - Hint values an application can specify affecting full-screen transition behavior -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFullScreenExclusiveEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFullScreenExclusiveEXT.html </a>
/// </summary>
public enum VkFullScreenExclusiveEXT
{
    /// <summary> VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT indicates the implementation should determine the appropriate full-screen method by whatever means it deems appropriate. </summary>
    VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = 0,

    /// <summary> VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT indicates the implementation may use full-screen exclusive mechanisms when available. Such mechanisms may result in better performance and/or the availability of different presentation capabilities, but may require a more disruptive transition during swapchain initialization, first presentation and/or destruction. </summary>
    VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = 1,

    /// <summary> VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT indicates the implementation should avoid using full-screen mechanisms which rely on disruptive transitions. </summary>
    VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = 2,

    /// <summary>
    ///     VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT indicates the application will manage full-screen exclusive mode by using the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html">
    ///         vkAcquireFullScreenExclusiveModeEXT
    ///     </a>
    ///     and
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html">
    ///         vkReleaseFullScreenExclusiveModeEXT
    ///     </a>
    ///     commands.
    /// </summary>
    VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = 3
}