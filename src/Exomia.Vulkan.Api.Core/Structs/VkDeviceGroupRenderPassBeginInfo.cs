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
///     VkDeviceGroupRenderPassBeginInfo - Set the initial device mask and render areas for a render pass instance -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupRenderPassBeginInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupRenderPassBeginInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderPassBeginInfo,VkRenderingInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderPassBeginInfo,VkRenderingInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>deviceMask is the device mask for the render pass instance.</summary>
    public uint deviceMask;

    /// <summary>deviceRenderAreaCount is the number of elements in the pDeviceRenderAreas array.</summary>
    public uint deviceRenderAreaCount;

    /// <summary>
    ///     pDeviceRenderAreas is a pointer to an array of VkRect2Dstructures defining the render area for each physical
    ///     device.
    /// </summary>
    public VkRect2D* pDeviceRenderAreas;
}