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
///     VkQueryControlFlagBits - Bitmask specifying constraints on a query -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryControlFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryControlFlagBits.html</a>
/// </summary>
[Flags]
public enum VkQueryControlFlagBits
{
    /// <summary>
    ///     VK_QUERY_CONTROL_PRECISE_BIT specifies the precision of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#queries-occlusion">
    ///         occlusion
    ///         queries
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_CONTROL_PRECISE_BIT = 0
}