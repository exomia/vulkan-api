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
///     VkCommandBufferInheritanceInfo - Structure specifying command buffer inheritance information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceInfo.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferInheritanceInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> renderPass is a VkRenderPass object defining which render passes the VkCommandBuffer will be compatible with and can be executed within. </summary>
    public VkRenderPass renderPass;

    /// <summary> subpass is the index of the subpass within the render pass instance that the VkCommandBuffer will be executed within. </summary>
    public uint subpass;

    /// <summary> framebuffer can refer to the VkFramebuffer object that the VkCommandBuffer will be rendering to if it is executed within a render pass instance. It can be VK_NULL_HANDLE if the framebuffer is not known.NoteSpecifying the exact framebuffer that the secondary command buffer will be executed with may result in better performance at command buffer execution time. </summary>
    public VkFramebuffer framebuffer;

    /// <summary> occlusionQueryEnable specifies whether the command buffer can be executed while an occlusion query is active in the primary command buffer. If this is VK_TRUE, then this command buffer can be executed whether the primary command buffer has an occlusion query active or not. If this is VK_FALSE, then the primary command buffer must not have an occlusion query active. </summary>
    public VkBool32 occlusionQueryEnable;

    /// <summary> queryFlags specifies the query flags that can be used by an active occlusion query in the primary command buffer when this secondary command buffer is executed. If this value includes the VK_QUERY_CONTROL_PRECISE_BIT bit, then the active query can return boolean results or actual sample counts. If this bit is not set, then the active query must not use the VK_QUERY_CONTROL_PRECISE_BIT bit. </summary>
    public VkQueryControlFlags queryFlags;

    /// <summary> pipelineStatistics is a bitmask of VkQueryPipelineStatisticFlagBits specifying the set of pipeline statistics that can be counted by an active query in the primary command buffer when this secondary command buffer is executed. If this value includes a given bit, then this command buffer can be executed whether the primary command buffer has a pipeline statistics query active that includes this bit or not. If this value excludes a given bit, then the active pipeline statistics query must not be from a query pool that counts that statistic. </summary>
    public VkQueryPipelineStatisticFlags pipelineStatistics;
}