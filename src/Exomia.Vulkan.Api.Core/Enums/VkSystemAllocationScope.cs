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
///     VkSystemAllocationScope - Allocation scope -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSystemAllocationScope.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSystemAllocationScope.html</a>
/// </summary>
public enum VkSystemAllocationScope
{
    /// <summary>
    ///     VK_SYSTEM_ALLOCATION_SCOPE_COMMAND specifies that the allocation is scoped to the duration of the Vulkan
    ///     command.
    /// </summary>
    VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = 0,

    /// <summary>
    ///     VK_SYSTEM_ALLOCATION_SCOPE_OBJECT specifies that the allocation is scoped to the lifetime of the Vulkan object
    ///     that is being created or used.
    /// </summary>
    VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = 1,

    /// <summary>
    ///     VK_SYSTEM_ALLOCATION_SCOPE_CACHE specifies that the allocation is scoped to the lifetime of a
    ///     VkPipelineCacheor VkValidationCacheEXTobject.
    /// </summary>
    VK_SYSTEM_ALLOCATION_SCOPE_CACHE = 2,

    /// <summary>
    ///     VK_SYSTEM_ALLOCATION_SCOPE_DEVICE specifies that the allocation is scoped to the lifetime of the Vulkan
    ///     device.
    /// </summary>
    VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = 3,

    /// <summary>
    ///     VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE specifies that the allocation is scoped to the lifetime of the Vulkan
    ///     instance.
    /// </summary>
    VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = 4
}