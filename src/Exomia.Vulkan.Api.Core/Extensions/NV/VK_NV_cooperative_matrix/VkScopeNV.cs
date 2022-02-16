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
///     VkScopeNV - Specify SPIR-V scope -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScopeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScopeNV.html</a>
/// </summary>
public enum VkScopeNV
{
    /// <summary>VK_SCOPE_DEVICE_NV corresponds to SPIR-V Device scope.</summary>
    VK_SCOPE_DEVICE_NV = 1,

    /// <summary>VK_SCOPE_WORKGROUP_NV corresponds to SPIR-V Workgroup scope.</summary>
    VK_SCOPE_WORKGROUP_NV = 2,

    /// <summary>VK_SCOPE_SUBGROUP_NV corresponds to SPIR-V Subgroup scope.</summary>
    VK_SCOPE_SUBGROUP_NV = 3,

    /// <summary>VK_SCOPE_QUEUE_FAMILY_NV corresponds to SPIR-V QueueFamilyscope.</summary>
    VK_SCOPE_QUEUE_FAMILY_NV = 5
}