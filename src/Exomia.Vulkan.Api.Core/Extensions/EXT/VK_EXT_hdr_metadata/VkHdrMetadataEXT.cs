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
///     VkHdrMetadataEXT - Specify Hdr metadata -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrMetadataEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrMetadataEXT.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHdrMetadataEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_HDR_METADATA_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> displayPrimaryRed is a VkXYColorEXT structure specifying the reference monitor&#8217;s red primary in chromaticity coordinates </summary>
    public VkXYColorEXT displayPrimaryRed;

    /// <summary> displayPrimaryGreen is a VkXYColorEXT structure specifying the reference monitor&#8217;s green primary in chromaticity coordinates </summary>
    public VkXYColorEXT displayPrimaryGreen;

    /// <summary> displayPrimaryBlue is a VkXYColorEXT structure specifying the reference monitor&#8217;s blue primary in chromaticity coordinates </summary>
    public VkXYColorEXT displayPrimaryBlue;

    /// <summary> whitePoint is a VkXYColorEXT structure specifying the reference monitor&#8217;s white-point in chromaticity coordinates </summary>
    public VkXYColorEXT whitePoint;

    /// <summary> maxLuminance is the maximum luminance of the reference monitor in nits </summary>
    public float maxLuminance;

    /// <summary> minLuminance is the minimum luminance of the reference monitor in nits </summary>
    public float minLuminance;

    /// <summary> maxContentLightLevel is content&#8217;s maximum luminance in nits </summary>
    public float maxContentLightLevel;

    /// <summary> maxFrameAverageLightLevel is the maximum frame average light level in nits </summary>
    public float maxFrameAverageLightLevel;
}