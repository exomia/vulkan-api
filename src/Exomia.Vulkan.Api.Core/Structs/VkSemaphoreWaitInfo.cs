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
///     VkSemaphoreWaitInfo - Structure containing information about the semaphore wait condition -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreWaitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkSemaphoreWaitFlagBits specifying additional parameters for the semaphore wait
    ///     operation.
    /// </summary>
    public VkSemaphoreWaitFlags flags;

    /// <summary>semaphoreCount is the number of semaphores to wait on.</summary>
    public uint semaphoreCount;

    /// <summary>pSemaphores is a pointer to an array of semaphoreCountsemaphore handles to wait on.</summary>
    public VkSemaphore* pSemaphores;

    /// <summary>pValues is a pointer to an array of semaphoreCount timeline semaphore values.</summary>
    public ulong* pValues;
}