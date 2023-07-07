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
///     VkPhysicalDeviceCustomBorderColorFeaturesEXT - Structure describing whether custom border colors can be supported
///     by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCustomBorderColorFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCustomBorderColorFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     customBorderColors indicates that the implementation supports providing a borderColor value with one of the
    ///     following values at sampler creation time:VK_BORDER_COLOR_FLOAT_CUSTOM_EXTVK_BORDER_COLOR_INT_CUSTOM_EXT
    /// </summary>
    public VkBool32 customBorderColors;

    /// <summary>
    ///     customBorderColorWithoutFormat indicates that explicit formats are not required for custom border colors and
    ///     the value of the formatmember of the VkSamplerCustomBorderColorCreateInfoEXT structure may be VK_FORMAT_UNDEFINED.
    ///     If this feature bit is not set, applications must provide the VkFormat of the image view(s) being sampled by this
    ///     sampler in the format member of the VkSamplerCustomBorderColorCreateInfoEXTstructure.
    /// </summary>
    public VkBool32 customBorderColorWithoutFormat;
}