﻿#region License

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
///     VkPhysicalDeviceMultiviewProperties - Structure describing multiview limits that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxMultiviewViewCount is one greater than the maximum view index that can be used in a subpass.</summary>
    public uint maxMultiviewViewCount;

    /// <summary>
    ///     maxMultiviewInstanceIndex is the maximum valid value of instance index allowed to be generated by a drawing
    ///     command recorded within a subpass of a multiview render pass instance.
    /// </summary>
    public uint maxMultiviewInstanceIndex;
}