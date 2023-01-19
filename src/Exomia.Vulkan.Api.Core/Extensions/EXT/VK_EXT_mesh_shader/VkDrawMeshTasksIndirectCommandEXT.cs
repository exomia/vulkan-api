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
///     VkDrawMeshTasksIndirectCommandEXT - Structure specifying a mesh tasks draw indirect command -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawMeshTasksIndirectCommandEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDrawMeshTasksIndirectCommandEXT
{
    /// <summary>groupCountX is the number of local workgroups to dispatch in the X dimension.</summary>
    public uint groupCountX;

    /// <summary>groupCountY is the number of local workgroups to dispatch in the Y dimension.</summary>
    public uint groupCountY;

    /// <summary>groupCountZ is the number of local workgroups to dispatch in the Z dimension.</summary>
    public uint groupCountZ;
}