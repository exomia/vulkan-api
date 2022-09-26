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
///     VkTransformMatrixKHR - Structure specifying a 3x4 affine transformation matrix -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTransformMatrixKHR.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTransformMatrixKHR.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTransformMatrixKHR
{
    /// <summary> matrix is a 3x4 row-major affine transformation matrix. </summary>
    public fixed float matrix[12];
}