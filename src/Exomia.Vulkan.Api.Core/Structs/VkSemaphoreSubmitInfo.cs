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
///     VkSemaphoreSubmitInfo - Structure specifying a semaphore signal or wait operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreSubmitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSemaphoreSubmitInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>semaphore is a VkSemaphore affected by this operation.</summary>
    public VkSemaphore semaphore;

    /// <summary>
    ///     value is either the value used to signal semaphore or the value waited on by semaphore, if semaphore is a
    ///     timeline semaphore. Otherwise it is ignored.
    /// </summary>
    public ulong value;

    /// <summary>
    ///     stageMask is a VkPipelineStageFlags2 mask of pipeline stages which limit the first synchronization scope of a
    ///     semaphore signal operation, or second synchronization scope of a semaphore wait operation as described in the
    ///     semaphore wait operation and semaphore signal operation sections of the synchronization chapter.
    /// </summary>
    public VkPipelineStageFlags2 stageMask;

    /// <summary>
    ///     deviceIndex is the index of the device within a device group that executes the semaphore wait or signal
    ///     operation.
    /// </summary>
    public uint deviceIndex;
}