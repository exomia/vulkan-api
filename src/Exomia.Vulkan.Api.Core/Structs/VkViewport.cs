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
///     VkViewport - Structure specifying a viewport -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewport.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewport.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkViewport
{
    /// <summary>x and y are the viewport&#8217;s upper left corner (x,y).</summary>
    public float x;

    /// <summary>x and y are the viewport&#8217;s upper left corner (x,y).</summary>
    public float y;

    /// <summary>width and height are the viewport&#8217;s width and height, respectively.</summary>
    public float width;

    /// <summary>width and height are the viewport&#8217;s width and height, respectively.</summary>
    public float height;

    /// <summary>minDepth and maxDepth are the depth range for the viewport.</summary>
    public float minDepth;

    /// <summary>minDepth and maxDepth are the depth range for the viewport.</summary>
    public float maxDepth;
}