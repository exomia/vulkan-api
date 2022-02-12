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
///     VkDependencyFlagBits - Bitmask specifying how execution and memory dependencies are formed -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDependencyFlagBits.html</a>
/// </summary>
[Flags]
public enum VkDependencyFlagBits
{
    /// <summary>
    ///     VK_DEPENDENCY_BY_REGION_BIT specifies that dependencies will be
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-framebuffer-regions">
    ///         framebuffer-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_BY_REGION_BIT = 1 << 0,

    /// <summary>
    ///     VK_DEPENDENCY_DEVICE_GROUP_BIT specifies that dependencies are
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-device-local-dependencies">
    ///         non-device-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_DEVICE_GROUP_BIT = 1 << 2,

    /// <summary>
    ///     VK_DEPENDENCY_VIEW_LOCAL_BIT specifies that a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-pipeline-barriers-subpass-self-dependencies">
    ///         subpass
    ///         has more than one view
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_VIEW_LOCAL_BIT = 1 << 1,

    /// <summary>
    ///     VK_DEPENDENCY_VIEW_LOCAL_BIT specifies that a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-pipeline-barriers-subpass-self-dependencies">
    ///         subpass
    ///         has more than one view
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,

    /// <summary>
    ///     VK_DEPENDENCY_DEVICE_GROUP_BIT specifies that dependencies are
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-device-local-dependencies">
    ///         non-device-local
    ///     </a>
    ///     .
    /// </summary>
    VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT
}