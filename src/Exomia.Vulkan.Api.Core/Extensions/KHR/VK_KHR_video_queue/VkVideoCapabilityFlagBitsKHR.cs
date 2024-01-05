#region License

// Copyright (c) 2018-2024, exomia
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
///     VkVideoCapabilityFlagBitsKHR - Video decode and encode capability bits -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilityFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilityFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkVideoCapabilityFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR indicates that video sessions support producing and consuming
    ///     protected content.
    /// </summary>
    VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoCapabilityFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoCapabilityFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = 0x2
}