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
///     VkInternalAllocationType - Allocation type -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInternalAllocationType.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInternalAllocationType.html</a>
/// </summary>
public enum VkInternalAllocationType
{
    /// <summary>VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE specifies that the allocation is intended for execution by the host.</summary>
    VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = 0
}