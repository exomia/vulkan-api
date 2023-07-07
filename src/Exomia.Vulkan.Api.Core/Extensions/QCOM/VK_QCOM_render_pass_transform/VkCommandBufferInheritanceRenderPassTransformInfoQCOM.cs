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
///     VkCommandBufferInheritanceRenderPassTransformInfoQCOM - Structure describing transformed render pass parameters
///     command buffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderPassTransformInfoQCOM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderPassTransformInfoQCOM.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkCommandBufferInheritanceInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferInheritanceInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>transform is a VkSurfaceTransformFlagBitsKHR value describing the transform to be applied to the render pass.</summary>
    public VkSurfaceTransformFlagBitsKHR transform;

    /// <summary>renderArea is the render area that is affected by the command buffer.</summary>
    public VkRect2D renderArea;
}