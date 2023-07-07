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
///     VkSampleLocationsInfoEXT - Structure specifying a set of sample locations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleLocationsInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleLocationsInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageMemoryBarrier,VkImageMemoryBarrier2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageMemoryBarrier,VkImageMemoryBarrier2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSampleLocationsInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>sampleLocationsPerPixel is a VkSampleCountFlagBits value specifying the number of sample locations per pixel.</summary>
    public VkSampleCountFlagBits sampleLocationsPerPixel;

    /// <summary>sampleLocationGridSize is the size of the sample location grid to select custom sample locations for.</summary>
    public VkExtent2D sampleLocationGridSize;

    /// <summary>sampleLocationsCount is the number of sample locations in pSampleLocations.</summary>
    public uint sampleLocationsCount;

    /// <summary>pSampleLocations is a pointer to an array of sampleLocationsCount VkSampleLocationEXT structures.</summary>
    public VkSampleLocationEXT* pSampleLocations;
}