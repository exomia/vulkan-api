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
///     VkRenderPassStripeSubmitInfoARM - Structure specifying striped rendering submit information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeSubmitInfoARM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeSubmitInfoARM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkCommandBufferSubmitInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferSubmitInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassStripeSubmitInfoARM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stripeSemaphoreInfoCount is the number of semaphores used to signal stripe completion in the render pass
    ///     instances in the submitted command buffer.
    /// </summary>
    public uint stripeSemaphoreInfoCount;

    /// <summary>
    ///     pStripeSemaphoreInfos is a pointer to an array of stripeSemaphoreInfoCount VkSemaphoreSubmitInfo structures
    ///     describing the semaphores used to signal stripe completion.
    /// </summary>
    public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
}