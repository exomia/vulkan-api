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
///     VkDebugUtilsMessageSeverityFlagBitsEXT - Bitmask specifying which severities of events cause a debug messenger
///     callback -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessageSeverityFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessageSeverityFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkDebugUtilsMessageSeverityFlagBitsEXT
{
    /// <summary>
    ///     VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT specifies the most verbose output indicating all diagnostic
    ///     messages from the Vulkan loader, layers, and drivers should be captured.
    /// </summary>
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = 1 << 0,

    /// <summary>
    ///     VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT specifies an informational message such as resource details that
    ///     may be handy when debugging an application.
    /// </summary>
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = 1 << 4,

    /// <summary>
    ///     VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT specifies use of Vulkan that may expose an app bug. Such cases
    ///     may not be immediately harmful, such as a fragment shader outputting to a location with no attachment. Other cases
    ///     may point to behavior that is almost certainly bad when unintended such as using an image whose memory has not been
    ///     filled. In general if you see a warning but you know that the behavior is intended/desired, then simply ignore the
    ///     warning.
    /// </summary>
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = 1 << 8,

    /// <summary>
    ///     VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT specifies that the application has violated a valid usage
    ///     condition of the specification.
    /// </summary>
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = 1 << 12
}