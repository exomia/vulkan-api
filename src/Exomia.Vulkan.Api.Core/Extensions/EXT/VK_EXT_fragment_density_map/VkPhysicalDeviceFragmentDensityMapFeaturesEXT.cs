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
///     VkPhysicalDeviceFragmentDensityMapFeaturesEXT - Structure describing fragment density map features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapFeaturesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     fragmentDensityMap specifies whether the implementation supports render passes with a fragment density map
    ///     attachment. If this feature is not enabled and the pNext chain of VkRenderPassCreateInfo includes a
    ///     VkRenderPassFragmentDensityMapCreateInfoEXT structure, fragmentDensityMapAttachment must be VK_ATTACHMENT_UNUSED.
    /// </summary>
    public VkBool32 fragmentDensityMap;

    /// <summary>
    ///     fragmentDensityMapDynamicspecifies whether the implementation supports dynamic fragment density map image
    ///     views. If this feature is not enabled, VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT mustnot be
    ///     included in VkImageViewCreateInfo::flags.
    /// </summary>
    public VkBool32 fragmentDensityMapDynamic;

    /// <summary>
    ///     fragmentDensityMapNonSubsampledImages specifies whether the implementation supports regular non-subsampled
    ///     image attachments with fragment density map render passes. If this feature is not enabled, render passes with a
    ///     fragment density map attachment must only have subsampled attachments bound.
    /// </summary>
    public VkBool32 fragmentDensityMapNonSubsampledImages;
}