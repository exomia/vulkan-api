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
///     VkRasterizationOrderAMD - Specify rasterization order for a graphics pipeline -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRasterizationOrderAMD.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRasterizationOrderAMD.html </a>
/// </summary>
public enum VkRasterizationOrderAMD
{
    /// <summary>
    ///     VK_RASTERIZATION_ORDER_STRICT_AMD specifies that operations for each primitive in a subpass must occur in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-primitive-order"> primitive order </a>
    ///     .
    /// </summary>
    VK_RASTERIZATION_ORDER_STRICT_AMD = 0,

    /// <summary>
    ///     VK_RASTERIZATION_ORDER_RELAXED_AMD specifies that operations for each primitive in a subpass may not occur in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-primitive-order"> primitive order </a>
    ///     .
    /// </summary>
    VK_RASTERIZATION_ORDER_RELAXED_AMD = 1
}