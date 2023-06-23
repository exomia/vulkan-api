#region License

// Copyright (c) 2018-2023, exomia
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
///     VkScopeKHR - Specify SPIR-V scope -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScopeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScopeKHR.html</a>
/// </summary>
public enum VkScopeKHR
{
    /// <summary>VK_SCOPE_DEVICE_KHR corresponds to SPIR-V Device scope.</summary>
    VK_SCOPE_DEVICE_KHR = 1,

    /// <summary>VK_SCOPE_WORKGROUP_KHR corresponds to SPIR-V Workgroup scope.</summary>
    VK_SCOPE_WORKGROUP_KHR = 2,

    /// <summary>VK_SCOPE_SUBGROUP_KHR corresponds to SPIR-V Subgroup scope.</summary>
    VK_SCOPE_SUBGROUP_KHR = 3,

    /// <summary>VK_SCOPE_QUEUE_FAMILY_KHR corresponds to SPIR-V QueueFamilyscope.</summary>
    VK_SCOPE_QUEUE_FAMILY_KHR = 5
}