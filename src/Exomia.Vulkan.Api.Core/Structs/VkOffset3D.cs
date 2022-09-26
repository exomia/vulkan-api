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
///     VkOffset3D - Structure specifying a three-dimensional offset -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOffset3D.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOffset3D.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkOffset3D
{
    /// <summary> x is the x offset. </summary>
    public int x;

    /// <summary> y is the y offset. </summary>
    public int y;

    /// <summary> z is the z offset. </summary>
    public int z;
}