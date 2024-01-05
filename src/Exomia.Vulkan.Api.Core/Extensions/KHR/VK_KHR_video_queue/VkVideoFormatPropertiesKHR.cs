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
///     VkVideoFormatPropertiesKHR - Structure enumerating the video image formats -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatPropertiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoFormatPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     format is a VkFormat that specifies the format that can be used with the specified video profiles and image
    ///     usages.
    /// </summary>
    public VkFormat format;

    /// <summary>
    ///     componentMapping defines the color channel order used for the format. format along with componentMapping
    ///     describe how the color channels are ordered when producing video decoder output or are expected to be ordered in
    ///     video encoder input, when applicable. If the format reported does not require component swizzling then all members
    ///     of componentMapping will be set to VK_COMPONENT_SWIZZLE_IDENTITY.
    /// </summary>
    public VkComponentMapping componentMapping;

    /// <summary>
    ///     imageCreateFlags is a bitmask of VkImageCreateFlagBitsspecifying the supported image creation flags for the
    ///     format.
    /// </summary>
    public VkImageCreateFlags imageCreateFlags;

    /// <summary>imageType is a VkImageType that specifies the image type the format can be used with.</summary>
    public VkImageType imageType;

    /// <summary>imageTiling is a VkImageTiling that specifies the image tiling the format can be used with.</summary>
    public VkImageTiling imageTiling;

    /// <summary>imageUsageFlags is a bitmask of VkImageUsageFlagBitsspecifying the supported image usage flags for the format.</summary>
    public VkImageUsageFlags imageUsageFlags;
}