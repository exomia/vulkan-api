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
///     VkPhysicalDeviceInheritedViewportScissorFeaturesNV - Structure describing the viewport scissor inheritance behavior
///     for an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInheritedViewportScissorFeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceInheritedViewportScissorFeaturesNV.html
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
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     inheritedViewportScissor2Dindicates whether secondary command buffers can inherit most of the dynamic state
    ///     affected by VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT, VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT,
    ///     VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT, VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT,
    ///     VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT, VK_DYNAMIC_STATE_VIEWPORT or VK_DYNAMIC_STATE_SCISSOR, from a primary
    ///     command buffer.
    /// </summary>
    public VkBool32 inheritedViewportScissor2D;
}