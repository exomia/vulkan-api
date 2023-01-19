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
///     VkPhysicalDeviceImageDrmFormatModifierInfoEXT - Structure specifying a DRM format modifier as image creation
///     parameter -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageDrmFormatModifierInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageDrmFormatModifierInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceImageFormatInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceImageFormatInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     drmFormatModifier is the image&#8217;s Linux DRM format modifier, corresponding to
    ///     VkImageDrmFormatModifierExplicitCreateInfoEXT::modifier or to
    ///     VkImageDrmFormatModifierListCreateInfoEXT::pModifiers.
    /// </summary>
    public ulong drmFormatModifier;

    /// <summary>sharingMode specifies how the image will be accessed by multiple queue families.</summary>
    public VkSharingMode sharingMode;

    /// <summary>queueFamilyIndexCount is the number of entries in the pQueueFamilyIndices array.</summary>
    public uint queueFamilyIndexCount;

    /// <summary>
    ///     pQueueFamilyIndices is a pointer to an array of queue families that will access the image. It is ignored if
    ///     sharingMode is not VK_SHARING_MODE_CONCURRENT.
    /// </summary>
    public uint* pQueueFamilyIndices;
}