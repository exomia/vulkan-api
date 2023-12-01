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
///     VkRenderPassStripeBeginInfoARM - Structure specifying striped rendering information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeBeginInfoARM.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeBeginInfoARM.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkRenderingInfo,VkRenderPassBeginInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkRenderingInfo,VkRenderPassBeginInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassStripeBeginInfoARM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stripeInfoCount is the number of stripes in this render pass instance</summary>
    public uint stripeInfoCount;

    /// <summary>
    ///     pStripeInfos is a pointer to an array of stripeInfoCountVkRenderPassStripeInfoARM structures describing the
    ///     stripes used by the render pass instance.
    /// </summary>
    public VkRenderPassStripeInfoARM* pStripeInfos;
}