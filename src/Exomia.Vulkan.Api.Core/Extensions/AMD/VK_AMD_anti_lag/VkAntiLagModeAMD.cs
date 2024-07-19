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
///     VkAntiLagModeAMD - Set the status of the anti-lag feature -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagModeAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAntiLagModeAMD.html</a>
/// </summary>
public enum VkAntiLagModeAMD
{
    /// <summary>
    ///     VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD specifies that anti-lag will be enabled or disabled depending on driver
    ///     settings.
    /// </summary>
    VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD = 0,

    /// <summary>VK_ANTI_LAG_MODE_ON_AMD specifies that anti-lag will be enabled.</summary>
    VK_ANTI_LAG_MODE_ON_AMD = 1,

    /// <summary>VK_ANTI_LAG_MODE_OFF_AMD specifies that anti-lag will be disabled.</summary>
    VK_ANTI_LAG_MODE_OFF_AMD = 2
}