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
///     VkSubmitInfo2 - Structure specifying a queue submit operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo2.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubmitInfo2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBMIT_INFO_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkSubmitFlagBits.</summary>
    public VkSubmitFlags flags;

    /// <summary>waitSemaphoreInfoCount is the number of elements in pWaitSemaphoreInfos.</summary>
    public uint waitSemaphoreInfoCount;

    /// <summary>
    ///     pWaitSemaphoreInfos is a pointer to an array of VkSemaphoreSubmitInfo structures defining semaphore wait
    ///     operations.
    /// </summary>
    public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;

    /// <summary>
    ///     commandBufferInfoCount is the number of elements in pCommandBufferInfos and the number of command buffers to
    ///     execute in the batch.
    /// </summary>
    public uint commandBufferInfoCount;

    /// <summary>
    ///     pCommandBufferInfos is a pointer to an array of VkCommandBufferSubmitInfo structures describing command
    ///     buffers to execute in the batch.
    /// </summary>
    public VkCommandBufferSubmitInfo* pCommandBufferInfos;

    /// <summary>signalSemaphoreInfoCount is the number of elements in pSignalSemaphoreInfos.</summary>
    public uint signalSemaphoreInfoCount;

    /// <summary>
    ///     pSignalSemaphoreInfos is a pointer to an array of VkSemaphoreSubmitInfo describing semaphore signal
    ///     operations.
    /// </summary>
    public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}