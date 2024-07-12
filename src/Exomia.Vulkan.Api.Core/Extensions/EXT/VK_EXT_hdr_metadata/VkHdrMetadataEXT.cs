#region License

// Copyright (c) 2018-2024, exomia
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
///     VkHdrMetadataEXT - Specify HDR metadata -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrMetadataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkHdrMetadataEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHdrMetadataEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_HDR_METADATA_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     displayPrimaryRed is a VkXYColorEXT structure specifying the red primary of the display used to optimize the
    ///     content
    /// </summary>
    public VkXYColorEXT displayPrimaryRed;

    /// <summary>
    ///     displayPrimaryGreen is a VkXYColorEXT structure specifying the green primary of the display used to optimize
    ///     the content
    /// </summary>
    public VkXYColorEXT displayPrimaryGreen;

    /// <summary>
    ///     displayPrimaryBlue is a VkXYColorEXT structure specifying the blue primary of the display used to optimize the
    ///     content
    /// </summary>
    public VkXYColorEXT displayPrimaryBlue;

    /// <summary>whitePoint is a VkXYColorEXT structure specifying the white-point of the display used to optimize the content</summary>
    public VkXYColorEXT whitePoint;

    /// <summary>maxLuminance is the maximum luminance of the display used to optimize the content in nits</summary>
    public float maxLuminance;

    /// <summary>minLuminance is the minimum luminance of the display used to optimize the content in nits</summary>
    public float minLuminance;

    /// <summary>
    ///     maxContentLightLevel is the value in nits of the desired luminance for the brightest pixels in the displayed
    ///     image.
    /// </summary>
    public float maxContentLightLevel;

    /// <summary>
    ///     maxFrameAverageLightLevel is the value in nits of the average luminance of the frame which has the brightest
    ///     average luminance anywhere in the content.
    /// </summary>
    public float maxFrameAverageLightLevel;
}