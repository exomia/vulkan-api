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
///     VkViewportWScalingNV - Structure specifying a viewport -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportWScalingNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportWScalingNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkViewportWScalingNV
{
    /// <summary>xcoeff and ycoeff are the viewport&#8217;s W scaling factor for x and y respectively.</summary>
    public float xcoeff;

    /// <summary>xcoeff and ycoeff are the viewport&#8217;s W scaling factor for x and y respectively.</summary>
    public float ycoeff;
}