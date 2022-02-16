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
///     VkPhysicalDeviceExtendedDynamicState2FeaturesEXT - Structure describing what extended dynamic state can be used -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState2FeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState2FeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     extendedDynamicState2 indicates that the implementation supports the following dynamic
    ///     states:VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLEVK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLEVK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE
    /// </summary>
    public VkBool32 extendedDynamicState2;

    /// <summary>
    ///     extendedDynamicState2LogicOp indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_LOGIC_OP_EXT
    /// </summary>
    public VkBool32 extendedDynamicState2LogicOp;

    /// <summary>
    ///     extendedDynamicState2PatchControlPoints indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT
    /// </summary>
    public VkBool32 extendedDynamicState2PatchControlPoints;
}