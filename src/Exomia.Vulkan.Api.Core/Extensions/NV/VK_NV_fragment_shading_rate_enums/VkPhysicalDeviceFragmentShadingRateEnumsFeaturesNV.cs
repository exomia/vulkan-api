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
///     VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV - Structure indicating support for fragment shading rate enums -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV.html
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
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     fragmentShadingRateEnumsindicates that the implementation supports specifying fragment shading rates using
    ///     the VkFragmentShadingRateNV enumerated type.
    /// </summary>
    public VkBool32 fragmentShadingRateEnums;

    /// <summary>
    ///     supersampleFragmentShadingRates indicates that the implementation supports fragment shading rate enum values
    ///     indicating more than one invocation per fragment.
    /// </summary>
    public VkBool32 supersampleFragmentShadingRates;

    /// <summary>
    ///     noInvocationFragmentShadingRates indicates that the implementation supports a fragment shading rate enum value
    ///     indicating that no fragment shaders should be invoked when that shading rate is used.
    /// </summary>
    public VkBool32 noInvocationFragmentShadingRates;
}