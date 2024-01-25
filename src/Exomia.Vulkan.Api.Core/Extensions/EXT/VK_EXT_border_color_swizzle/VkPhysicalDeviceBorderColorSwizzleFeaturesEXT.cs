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
///     VkPhysicalDeviceBorderColorSwizzleFeaturesEXT - Structure describing whether samplers with custom border colors
///     require the component swizzle specified in order to have defined behavior -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBorderColorSwizzleFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBorderColorSwizzleFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     borderColorSwizzle indicates that defined values are returned by sampled image operations when used with a
    ///     sampler that uses a VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK, VK_BORDER_COLOR_INT_OPAQUE_BLACK,
    ///     VK_BORDER_COLOR_FLOAT_CUSTOM_EXT, or VK_BORDER_COLOR_INT_CUSTOM_EXT borderColor and an image view that uses a
    ///     non-identity component mapping, when either borderColorSwizzleFromImage is enabled or the
    ///     VkSamplerBorderColorComponentMappingCreateInfoEXTis specified.
    /// </summary>
    public VkBool32 borderColorSwizzle;

    /// <summary>
    ///     borderColorSwizzle indicates that defined values are returned by sampled image operations when used with a
    ///     sampler that uses a VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK, VK_BORDER_COLOR_INT_OPAQUE_BLACK,
    ///     VK_BORDER_COLOR_FLOAT_CUSTOM_EXT, or VK_BORDER_COLOR_INT_CUSTOM_EXT borderColor and an image view that uses a
    ///     non-identity component mapping, when either borderColorSwizzleFromImage is enabled or the
    ///     VkSamplerBorderColorComponentMappingCreateInfoEXTis specified.
    /// </summary>
    public VkBool32 borderColorSwizzleFromImage;
}