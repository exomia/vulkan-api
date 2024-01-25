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
///     VkLayeredDriverUnderlyingApiMSFT - Layered driver underlying APIs -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayeredDriverUnderlyingApiMSFT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayeredDriverUnderlyingApiMSFT.html
///     </a>
/// </summary>
public enum VkLayeredDriverUnderlyingApiMSFT
{
    /// <summary>
    ///     VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayeredDriverUnderlyingApiMSFT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayeredDriverUnderlyingApiMSFT
    ///     </a>
    /// </summary>
    VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT = 0,

    /// <summary>
    ///     VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayeredDriverUnderlyingApiMSFT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkLayeredDriverUnderlyingApiMSFT
    ///     </a>
    /// </summary>
    VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT = 1
}