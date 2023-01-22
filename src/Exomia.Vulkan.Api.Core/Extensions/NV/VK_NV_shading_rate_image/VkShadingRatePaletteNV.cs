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
///     VkShadingRatePaletteNV - Structure specifying a single shading rate palette -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShadingRatePaletteNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShadingRatePaletteNV
{
    /// <summary>shadingRatePaletteEntryCount specifies the number of entries in the shading rate image palette.</summary>
    public uint shadingRatePaletteEntryCount;

    /// <summary>
    ///     pShadingRatePaletteEntries is a pointer to an array of VkShadingRatePaletteEntryNV enums defining the shading
    ///     rate for each palette entry.
    /// </summary>
    public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
}