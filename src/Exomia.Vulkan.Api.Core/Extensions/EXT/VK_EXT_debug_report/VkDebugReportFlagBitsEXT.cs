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
///     VkDebugReportFlagBitsEXT - Bitmask specifying events which cause a debug report callback -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkDebugReportFlagBitsEXT
{
    /// <summary>
    ///     VK_DEBUG_REPORT_INFORMATION_BIT_EXT specifies an informational message such as resource details that may be
    ///     handy when debugging an application.
    /// </summary>
    VK_DEBUG_REPORT_INFORMATION_BIT_EXT = 1 << 0,

    /// <summary>
    ///     VK_DEBUG_REPORT_WARNING_BIT_EXT specifies use of Vulkan that mayexpose an app bug. Such cases may not be
    ///     immediately harmful, such as a fragment shader outputting to a location with no attachment. Other cases may point
    ///     to behavior that is almost certainly bad when unintended such as using an image whose memory has not been filled.
    ///     In general if you see a warning but you know that the behavior is intended/desired, then simply ignore the warning.
    /// </summary>
    VK_DEBUG_REPORT_WARNING_BIT_EXT = 1 << 1,

    /// <summary>
    ///     VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT specifies a potentially non-optimal use of Vulkan, e.g. using
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdClearColorImage.html">vkCmdClearColorImage</a>
    ///     when setting
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescription.html">VkAttachmentDescription</a>
    ///     ::loadOp to VK_ATTACHMENT_LOAD_OP_CLEAR would have worked.
    /// </summary>
    VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = 1 << 2,

    /// <summary>
    ///     VK_DEBUG_REPORT_ERROR_BIT_EXT specifies that the application has violated a valid usage condition of the
    ///     specification.
    /// </summary>
    VK_DEBUG_REPORT_ERROR_BIT_EXT = 1 << 3,

    /// <summary>VK_DEBUG_REPORT_DEBUG_BIT_EXT specifies diagnostic information from the implementation and layers.</summary>
    VK_DEBUG_REPORT_DEBUG_BIT_EXT = 1 << 4
}