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
///     VkToolPurposeFlagBits - Bitmask specifying the purposes of an active tool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkToolPurposeFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkToolPurposeFlagBits.html</a>
/// </summary>
[Flags]
public enum VkToolPurposeFlagBits
{
    /// <summary>VK_TOOL_PURPOSE_VALIDATION_BIT specifies that the tool provides validation of API usage.</summary>
    VK_TOOL_PURPOSE_VALIDATION_BIT = 1 << 0,

    /// <summary>VK_TOOL_PURPOSE_PROFILING_BIT specifies that the tool provides profiling of API usage.</summary>
    VK_TOOL_PURPOSE_PROFILING_BIT = 1 << 1,

    /// <summary>
    ///     VK_TOOL_PURPOSE_TRACING_BIT specifies that the tool is capturing data about the application&#8217;s API usage,
    ///     including anything from simple logging to capturing data for later replay.
    /// </summary>
    VK_TOOL_PURPOSE_TRACING_BIT = 1 << 2,

    /// <summary>
    ///     VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT specifies that the tool provides additional API features/extensions on
    ///     top of the underlying implementation.
    /// </summary>
    VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT = 1 << 3,

    /// <summary>
    ///     VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT specifies that the tool modifies the API features/limits/extensions
    ///     presented to the application.
    /// </summary>
    VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT = 1 << 4,

    /// <summary>
    ///     VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT specifies that the tool reports additional information to the
    ///     application via callbacks specified by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html">vkCreateDebugReportCallbackEXT</a>
    ///     or
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html">vkCreateDebugUtilsMessengerEXT</a>
    /// </summary>
    VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = 1 << 5,

    /// <summary>
    ///     VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT specifies that the tool consumes
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#debugging-debug-markers">
    ///         debug
    ///         markers
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#debugging-object-debug-annotation">
    ///         object
    ///         debug annotation
    ///     </a>
    ///     ,
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#debugging-queue-labels">
    ///         queue
    ///         labels
    ///     </a>
    ///     , or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#debugging-command-buffer-labels">
    ///         command
    ///         buffer labels
    ///     </a>
    /// </summary>
    VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = 1 << 6,

    /// <summary>VK_TOOL_PURPOSE_VALIDATION_BIT specifies that the tool provides validation of API usage.</summary>
    VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = VK_TOOL_PURPOSE_VALIDATION_BIT,

    /// <summary>VK_TOOL_PURPOSE_PROFILING_BIT specifies that the tool provides profiling of API usage.</summary>
    VK_TOOL_PURPOSE_PROFILING_BIT_EXT = VK_TOOL_PURPOSE_PROFILING_BIT,

    /// <summary>
    ///     VK_TOOL_PURPOSE_TRACING_BIT specifies that the tool is capturing data about the application&#8217;s API usage,
    ///     including anything from simple logging to capturing data for later replay.
    /// </summary>
    VK_TOOL_PURPOSE_TRACING_BIT_EXT = VK_TOOL_PURPOSE_TRACING_BIT,

    /// <summary>
    ///     VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT specifies that the tool provides additional API features/extensions on
    ///     top of the underlying implementation.
    /// </summary>
    VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT,

    /// <summary>
    ///     VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT specifies that the tool modifies the API features/limits/extensions
    ///     presented to the application.
    /// </summary>
    VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT
}