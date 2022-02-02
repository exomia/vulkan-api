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
///     VkCoarseSampleLocationNV - Structure specifying parameters controlling shading rate image usage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleLocationNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleLocationNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkCoarseSampleLocationNV
{
    /// <summary>
    ///     pixelX is added to the x coordinate of the upper-leftmost pixel of each fragment to identify the pixel
    ///     containing the coverage sample.
    /// </summary>
    public uint pixelX;

    /// <summary>
    ///     pixelY is added to the y coordinate of the upper-leftmost pixel of each fragment to identify the pixel
    ///     containing the coverage sample.
    /// </summary>
    public uint pixelY;

    /// <summary>sample is the number of the coverage sample in the pixel identified by pixelX and pixelY.</summary>
    public uint sample;
}