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
///     VkTilePropertiesQCOM - Structure holding available tile properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTilePropertiesQCOM.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTilePropertiesQCOM.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTilePropertiesQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     tileSize is the dimensions of a tile, with width and height describing the width and height of a tile in
    ///     pixels, and depth corresponding to the number of slices the tile spans.
    /// </summary>
    public VkExtent3D tileSize;

    /// <summary>apronSize is the dimension of the apron.</summary>
    public VkExtent2D apronSize;

    /// <summary>origin is the top-left corner of the first tile in attachment space.</summary>
    public VkOffset2D origin;
}