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
///     VkSemaphoreType - Sepcifies the type of a semaphore object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreType.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreType.html</a>
/// </summary>
public enum VkSemaphoreType
{
    /// <summary>
    ///     VK_SEMAPHORE_TYPE_BINARY specifies a binary semaphore type that has a boolean payload indicating whether the
    ///     semaphore is currently signaled or unsignaled. When created, the semaphore is in the unsignaled state.
    /// </summary>
    VK_SEMAPHORE_TYPE_BINARY = 0,

    /// <summary>
    ///     VK_SEMAPHORE_TYPE_TIMELINE specifies a timeline semaphore type that has a strictly increasing 64-bit unsigned
    ///     integer payload indicating whether the semaphore is signaled with respect to a particular reference value. When
    ///     created, the semaphore payload has the value given by the initialValue field of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreTypeCreateInfo.html">VkSemaphoreTypeCreateInfo</a>
    ///     .
    /// </summary>
    VK_SEMAPHORE_TYPE_TIMELINE = 1,

    /// <summary>
    ///     VK_SEMAPHORE_TYPE_BINARY specifies a binary semaphore type that has a boolean payload indicating whether the
    ///     semaphore is currently signaled or unsignaled. When created, the semaphore is in the unsignaled state.
    /// </summary>
    VK_SEMAPHORE_TYPE_BINARY_KHR = VK_SEMAPHORE_TYPE_BINARY,

    /// <summary>
    ///     VK_SEMAPHORE_TYPE_TIMELINE specifies a timeline semaphore type that has a strictly increasing 64-bit unsigned
    ///     integer payload indicating whether the semaphore is signaled with respect to a particular reference value. When
    ///     created, the semaphore payload has the value given by the initialValue field of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreTypeCreateInfo.html">VkSemaphoreTypeCreateInfo</a>
    ///     .
    /// </summary>
    VK_SEMAPHORE_TYPE_TIMELINE_KHR = VK_SEMAPHORE_TYPE_TIMELINE
}