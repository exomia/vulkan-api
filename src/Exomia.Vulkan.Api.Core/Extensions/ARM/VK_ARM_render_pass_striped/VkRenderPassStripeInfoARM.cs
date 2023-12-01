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
///     VkRenderPassStripeInfoARM - Structure specifying per rendering stripe information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeInfoARM.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeInfoARM.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassStripeInfoARM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stripeArea is the stripe area, and is described in more detail below.</summary>
    public VkRect2D stripeArea;
}