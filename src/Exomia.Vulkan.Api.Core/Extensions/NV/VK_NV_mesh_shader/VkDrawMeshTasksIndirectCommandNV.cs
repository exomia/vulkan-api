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
///     VkDrawMeshTasksIndirectCommandNV - Structure specifying a mesh tasks draw indirect command -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDrawMeshTasksIndirectCommandNV
{
    /// <summary>
    ///     taskCount is the number of local workgroups to dispatch in the X dimension. Y and Z dimension are implicitly
    ///     set to one.
    /// </summary>
    public uint taskCount;

    /// <summary>firstTask is the X component of the first workgroup ID.</summary>
    public uint firstTask;
}