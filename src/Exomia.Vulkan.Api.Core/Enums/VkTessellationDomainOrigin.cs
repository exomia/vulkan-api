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
///     VkTessellationDomainOrigin - Enum describing tessellation domain origin -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTessellationDomainOrigin.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTessellationDomainOrigin.html</a>
/// </summary>
public enum VkTessellationDomainOrigin
{
    /// <summary>
    ///     VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT specifies that the origin of the domain space is in the upper left corner,
    ///     as shown in figure
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ul">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ul
    ///     </a>
    ///     .
    /// </summary>
    VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = 0,

    /// <summary>
    ///     VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT specifies that the origin of the domain space is in the lower left corner,
    ///     as shown in figure
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ll">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ll
    ///     </a>
    ///     .
    /// </summary>
    VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = 1,

    /// <summary>
    ///     VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT specifies that the origin of the domain space is in the upper left corner,
    ///     as shown in figure
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ul">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ul
    ///     </a>
    ///     .
    /// </summary>
    VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT,

    /// <summary>
    ///     VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT specifies that the origin of the domain space is in the lower left corner,
    ///     as shown in figure
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ll">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#img-tessellation-topology-ll
    ///     </a>
    ///     .
    /// </summary>
    VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT
}