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
///     VkDependencyFlagBits - Bitmask specifying how execution and memory dependencies are formed -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyFlagBits.html</a>
/// </summary>
[Flags]
public enum VkDependencyFlagBits
{
    /// <summary>
    ///     VK_DEPENDENCY_BY_REGION_BIT specifies that dependencies will be
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-framebuffer-regions">
    ///         framebuffer-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_BY_REGION_BIT = 0x1,

    /// <summary>
    ///     VK_DEPENDENCY_DEVICE_GROUP_BIT specifies that dependencies are
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-device-local-dependencies">
    ///         non-device-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x4,

    /// <summary>
    ///     VK_DEPENDENCY_VIEW_LOCAL_BIT specifies that dependencies will be
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-view-local-dependencies">
    ///         view-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x2,

    /// <summary>
    ///     VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT specifies that the render pass will write to and read from the same image
    ///     using the VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT layout.
    /// </summary>
    VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_DEPENDENCY_VIEW_LOCAL_BIT specifies that dependencies will be
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-view-local-dependencies">
    ///         view-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,

    /// <summary>
    ///     VK_DEPENDENCY_DEVICE_GROUP_BIT specifies that dependencies are
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-device-local-dependencies">
    ///         non-device-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT
}