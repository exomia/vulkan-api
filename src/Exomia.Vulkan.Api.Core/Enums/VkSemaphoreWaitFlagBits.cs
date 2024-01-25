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
///     VkSemaphoreWaitFlagBits - Bitmask specifying additional parameters of a semaphore wait operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSemaphoreWaitFlagBits
{
    /// <summary>
    ///     VK_SEMAPHORE_WAIT_ANY_BIT specifies that the semaphore wait condition is that at least one of the semaphores
    ///     in VkSemaphoreWaitInfo::pSemaphores has reached the value specified by the corresponding element of
    ///     VkSemaphoreWaitInfo::pValues. If VK_SEMAPHORE_WAIT_ANY_BIT is not set, the semaphore wait condition is that all of
    ///     the semaphores in VkSemaphoreWaitInfo::pSemaphores have reached the value specified by the corresponding element of
    ///     VkSemaphoreWaitInfo::pValues.
    /// </summary>
    VK_SEMAPHORE_WAIT_ANY_BIT = 0x1,

    /// <summary>
    ///     VK_SEMAPHORE_WAIT_ANY_BIT specifies that the semaphore wait condition is that at least one of the semaphores
    ///     in VkSemaphoreWaitInfo::pSemaphores has reached the value specified by the corresponding element of
    ///     VkSemaphoreWaitInfo::pValues. If VK_SEMAPHORE_WAIT_ANY_BIT is not set, the semaphore wait condition is that all of
    ///     the semaphores in VkSemaphoreWaitInfo::pSemaphores have reached the value specified by the corresponding element of
    ///     VkSemaphoreWaitInfo::pValues.
    /// </summary>
    VK_SEMAPHORE_WAIT_ANY_BIT_KHR = VK_SEMAPHORE_WAIT_ANY_BIT
}