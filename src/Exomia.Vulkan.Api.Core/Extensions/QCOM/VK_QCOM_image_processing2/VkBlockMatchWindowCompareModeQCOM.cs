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
///     VkBlockMatchWindowCompareModeQCOM - Block match window compare modes -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlockMatchWindowCompareModeQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBlockMatchWindowCompareModeQCOM.html
///     </a>
/// </summary>
public enum VkBlockMatchWindowCompareModeQCOM
{
    /// <summary>
    ///     VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM specifies that windowed block match operations return the minimum
    ///     error within the window.
    /// </summary>
    VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM = 0,

    /// <summary>
    ///     VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM specifies that windowed block match operations return the maximum
    ///     error within the window.
    /// </summary>
    VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM = 1
}