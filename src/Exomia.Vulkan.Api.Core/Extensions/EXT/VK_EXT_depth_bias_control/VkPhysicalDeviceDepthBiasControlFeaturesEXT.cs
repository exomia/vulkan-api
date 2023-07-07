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
///     VkPhysicalDeviceDepthBiasControlFeaturesEXT - Structure indicating support for depth bias scaling and
///     representation control -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDepthBiasControlFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDepthBiasControlFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     depthBiasControl indicates whether the implementation supports the vkCmdSetDepthBias2EXT command and the
    ///     VkDepthBiasRepresentationInfoEXT structure.
    /// </summary>
    public VkBool32 depthBiasControl;

    /// <summary>
    ///     leastRepresentableValueForceUnormRepresentation indicates whether the implementation supports using the
    ///     VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXTdepth bias representation.
    /// </summary>
    public VkBool32 leastRepresentableValueForceUnormRepresentation;

    /// <summary>
    ///     floatRepresentation indicates whether the implementation supports using the
    ///     VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT depth bias representation.
    /// </summary>
    public VkBool32 floatRepresentation;

    /// <summary>
    ///     depthBiasExact indicates whether the implementation supports forcing depth bias to not be scaled to ensure a
    ///     minimum resolvable difference using VkDepthBiasRepresentationInfoEXT::depthBiasExact.
    /// </summary>
    public VkBool32 depthBiasExact;
}