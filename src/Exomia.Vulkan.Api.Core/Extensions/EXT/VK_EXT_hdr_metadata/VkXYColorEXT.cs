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
///     VkXYColorEXT - Specify X,Y chromaticity coordinates -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXYColorEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkXYColorEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkXYColorEXT
{
    /// <summary>x is the x chromaticity coordinate.</summary>
    public float x;

    /// <summary>y is the y chromaticity coordinate.</summary>
    public float y;
}