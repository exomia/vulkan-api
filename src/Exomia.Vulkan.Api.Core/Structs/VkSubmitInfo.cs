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
///     VkSubmitInfo - Structure specifying a queue submit operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBMIT_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     waitSemaphoreCount is the number of semaphores upon which to wait before executing the command buffers for the
    ///     batch.
    /// </summary>
    public uint waitSemaphoreCount;

    /// <summary>
    ///     pWaitSemaphores is a pointer to an array of VkSemaphorehandles upon which to wait before the command buffers
    ///     for this batch begin execution. If semaphores to wait on are provided, they define a semaphore wait operation.
    /// </summary>
    public VkSemaphore* pWaitSemaphores;

    /// <summary>
    ///     pWaitDstStageMask is a pointer to an array of pipeline stages at which each corresponding semaphore wait will
    ///     occur.
    /// </summary>
    public VkPipelineStageFlags* pWaitDstStageMask;

    /// <summary>commandBufferCount is the number of command buffers to execute in the batch.</summary>
    public uint commandBufferCount;

    /// <summary>pCommandBuffers is a pointer to an array of VkCommandBufferhandles to execute in the batch.</summary>
    public VkCommandBuffer* pCommandBuffers;

    /// <summary>
    ///     signalSemaphoreCount is the number of semaphores to be signaled once the commands specified in pCommandBuffers
    ///     have completed execution.
    /// </summary>
    public uint signalSemaphoreCount;

    /// <summary>
    ///     pSignalSemaphores is a pointer to an array of VkSemaphorehandles which will be signaled when the command
    ///     buffers for this batch have completed execution. If semaphores to be signaled are provided, they define a semaphore
    ///     signal operation.
    /// </summary>
    public VkSemaphore* pSignalSemaphores;
}