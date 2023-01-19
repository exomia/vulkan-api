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
///     VkSampleLocationEXT - Structure specifying the coordinates of a sample location -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleLocationEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleLocationEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSampleLocationEXT
{
    /// <summary>x is the horizontal coordinate of the sample&#8217;s location.</summary>
    public float x;

    /// <summary>y is the vertical coordinate of the sample&#8217;s location.</summary>
    public float y;
}