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
///     VkSemaphoreImportFlagBits - Bitmask specifying additional parameters of semaphore payload import -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreImportFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreImportFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSemaphoreImportFlagBits
{
    /// <summary>
    ///     VK_SEMAPHORE_IMPORT_TEMPORARY_BIT specifies that the semaphore payload will be imported only temporarily, as
    ///     described in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-semaphores-importing">
    ///         Importing
    ///         Semaphore Payloads
    ///     </a>
    ///     , regardless of the permanence of handleType.
    /// </summary>
    VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = 1 << 0,

    /// <summary>
    ///     VK_SEMAPHORE_IMPORT_TEMPORARY_BIT specifies that the semaphore payload will be imported only temporarily, as
    ///     described in
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#synchronization-semaphores-importing">
    ///         Importing
    ///         Semaphore Payloads
    ///     </a>
    ///     , regardless of the permanence of handleType.
    /// </summary>
    VK_SEMAPHORE_IMPORT_TEMPORARY_BIT_KHR = VK_SEMAPHORE_IMPORT_TEMPORARY_BIT
}