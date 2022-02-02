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
///     VkCoarseSampleOrderCustomNV - Structure specifying parameters controlling shading rate image usage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderCustomNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderCustomNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCoarseSampleOrderCustomNV
{
    /// <summary>
    ///     shadingRate is a shading rate palette entry that identifies the fragment width and height for the combination
    ///     of fragment area and per-pixel coverage sample count to control.
    /// </summary>
    public VkShadingRatePaletteEntryNV shadingRate;

    /// <summary>
    ///     sampleCount identifies the per-pixel coverage sample count for the combination of fragment area and coverage
    ///     sample count to control.
    /// </summary>
    public uint sampleCount;

    /// <summary>sampleLocationCount specifies the number of sample locations in the custom ordering.</summary>
    public uint sampleLocationCount;

    /// <summary>
    ///     pSampleLocations is a pointer to an array of VkCoarseSampleLocationNV structures specifying the location of
    ///     each sample in the custom ordering.
    /// </summary>
    public VkCoarseSampleLocationNV* pSampleLocations;
}