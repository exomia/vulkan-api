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
///     VkFenceImportFlagBits - Bitmask specifying additional parameters of fence payload import -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceImportFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceImportFlagBits.html</a>
/// </summary>
[Flags]
public enum VkFenceImportFlagBits
{
    /// <summary>
    ///     VK_FENCE_IMPORT_TEMPORARY_BIT specifies that the fence payload will be imported only temporarily, as described in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-fences-importing">
    ///         Importing
    ///         Fence Payloads
    ///     </a>
    ///     , regardless of the permanence of handleType.
    /// </summary>
    VK_FENCE_IMPORT_TEMPORARY_BIT = 0x1,

    /// <summary>
    ///     VK_FENCE_IMPORT_TEMPORARY_BIT specifies that the fence payload will be imported only temporarily, as described in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-fences-importing">
    ///         Importing
    ///         Fence Payloads
    ///     </a>
    ///     , regardless of the permanence of handleType.
    /// </summary>
    VK_FENCE_IMPORT_TEMPORARY_BIT_KHR = VK_FENCE_IMPORT_TEMPORARY_BIT
}