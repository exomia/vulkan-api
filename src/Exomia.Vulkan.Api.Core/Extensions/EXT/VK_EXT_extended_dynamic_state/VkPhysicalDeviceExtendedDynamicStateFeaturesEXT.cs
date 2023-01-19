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
///     VkPhysicalDeviceExtendedDynamicStateFeaturesEXT - Structure describing what extended dynamic state can be used -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicStateFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicStateFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     extendedDynamicState indicates that the implementation supports the following dynamic
    ///     states:VK_DYNAMIC_STATE_CULL_MODEVK_DYNAMIC_STATE_FRONT_FACEVK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGYVK_DYNAMIC_STATE_VIEWPORT_WITH_COUNTVK_DYNAMIC_STATE_SCISSOR_WITH_COUNTVK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDEVK_DYNAMIC_STATE_DEPTH_TEST_ENABLEVK_DYNAMIC_STATE_DEPTH_WRITE_ENABLEVK_DYNAMIC_STATE_DEPTH_COMPARE_OPVK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLEVK_DYNAMIC_STATE_STENCIL_TEST_ENABLEVK_DYNAMIC_STATE_STENCIL_OP
    /// </summary>
    public VkBool32 extendedDynamicState;
}