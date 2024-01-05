#region License

// Copyright (c) 2018-2024, exomia
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
///     VkRenderPassBeginInfo - Structure specifying render pass begin information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassBeginInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassBeginInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassBeginInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>renderPass is the render pass to begin an instance of.</summary>
    public VkRenderPass renderPass;

    /// <summary>framebuffer is the framebuffer containing the attachments that are used with the render pass.</summary>
    public VkFramebuffer framebuffer;

    /// <summary>
    ///     renderArea is the render area that is affected by the render pass instance, and is described in more detail
    ///     below.
    /// </summary>
    public VkRect2D renderArea;

    /// <summary>clearValueCount is the number of elements in pClearValues.</summary>
    public uint clearValueCount;

    /// <summary>
    ///     pClearValues is a pointer to an array of clearValueCountVkClearValue structures containing clear values for
    ///     each attachment, if the attachment uses a loadOp value of VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a
    ///     depth/stencil format and uses a stencilLoadOp value of VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by
    ///     attachment number. Only elements corresponding to cleared attachments are used. Other elements of pClearValues are
    ///     ignored.
    /// </summary>
    public VkClearValue* pClearValues;
}