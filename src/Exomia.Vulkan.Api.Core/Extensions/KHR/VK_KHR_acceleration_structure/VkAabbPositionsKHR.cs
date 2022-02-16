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
///     VkAabbPositionsKHR - Structure specifying two opposing corners of an axis-aligned bounding box -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAabbPositionsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAabbPositionsKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAabbPositionsKHR
{
    /// <summary>minX is the x position of one opposing corner of a bounding box.</summary>
    public float minX;

    /// <summary>minY is the y position of one opposing corner of a bounding box.</summary>
    public float minY;

    /// <summary>minZ is the z position of one opposing corner of a bounding box.</summary>
    public float minZ;

    /// <summary>maxX is the x position of the other opposing corner of a bounding box.</summary>
    public float maxX;

    /// <summary>maxY is the y position of the other opposing corner of a bounding box.</summary>
    public float maxY;

    /// <summary>maxZ is the z position of the other opposing corner of a bounding box.</summary>
    public float maxZ;
}