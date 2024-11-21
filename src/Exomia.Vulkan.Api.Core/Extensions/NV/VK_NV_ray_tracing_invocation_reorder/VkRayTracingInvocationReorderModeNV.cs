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
///     VkRayTracingInvocationReorderModeNV - Enum providing a hint on how the application may: reorder -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingInvocationReorderModeNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingInvocationReorderModeNV.html
///     </a>
/// </summary>
public enum VkRayTracingInvocationReorderModeNV
{
    /// <summary>
    ///     VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV specifies that the implementation is likely to not reorder at
    ///     reorder calls.
    /// </summary>
    VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV = 0,

    /// <summary>
    ///     VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV specifies that the implementation is likely to reorder at
    ///     reorder calls.
    /// </summary>
    VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV = 1
}