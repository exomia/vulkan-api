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
///     VkDeviceDiagnosticsConfigFlagBitsNV - Bitmask specifying diagnostics flags -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceDiagnosticsConfigFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceDiagnosticsConfigFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkDeviceDiagnosticsConfigFlagBitsNV
{
    /// <summary>
    ///     VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NVenables the generation of debug information for
    ///     shaders.
    /// </summary>
    VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV = 0x1,

    /// <summary>
    ///     VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NVenables driver side tracking of resources (images,
    ///     buffers, etc.) used to augment the device fault information.
    /// </summary>
    VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV = 0x2,

    /// <summary>
    ///     VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NVenables automatic insertion of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#device-diagnostic-checkpoints">
    ///         diagnostic
    ///         checkpoints
    ///     </a>
    ///     for draw calls, dispatches, trace rays, and copies. The CPU call stack at the time of the
    ///     command will be associated as the marker data for the automatically inserted checkpoints.
    /// </summary>
    VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = 0x4,

    /// <summary>VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NVenables shader error reporting.</summary>
    VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV = 0x8
}