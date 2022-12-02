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
///     VkDirectDriverLoadingModeLUNARG - Specify loader behavior of added drivers -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingModeLUNARG.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDirectDriverLoadingModeLUNARG.html
///     </a>
/// </summary>
public enum VkDirectDriverLoadingModeLUNARG
{
    /// <summary>
    ///     VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingModeLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingModeLUNARG
    ///     </a>
    /// </summary>
    VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG = 0,

    /// <summary>
    ///     VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingModeLUNARG">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDirectDriverLoadingModeLUNARG
    ///     </a>
    /// </summary>
    VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG = 1
}