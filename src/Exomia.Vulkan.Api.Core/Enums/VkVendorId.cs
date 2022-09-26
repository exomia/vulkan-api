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
///     VkVendorId - Khronos vendor IDs -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVendorId.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVendorId.html </a>
/// </summary>
public enum VkVendorId
{
    /// <summary>
    ///     VK_VENDOR_ID_VIV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_VIV = 0x10001,

    /// <summary>
    ///     VK_VENDOR_ID_VSI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_VSI = 0x10002,

    /// <summary>
    ///     VK_VENDOR_ID_KAZAN<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_KAZAN = 0x10003,

    /// <summary>
    ///     VK_VENDOR_ID_CODEPLAY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_CODEPLAY = 0x10004,

    /// <summary>
    ///     VK_VENDOR_ID_MESA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_MESA = 0x10005,

    /// <summary>
    ///     VK_VENDOR_ID_POCL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVendorId </a>
    /// </summary>
    VK_VENDOR_ID_POCL = 0x10006
}