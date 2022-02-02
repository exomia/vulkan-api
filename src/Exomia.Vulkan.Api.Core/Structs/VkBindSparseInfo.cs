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
///     VkBindSparseInfo - Structure specifying a sparse binding operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindSparseInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindSparseInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindSparseInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_SPARSE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     waitSemaphoreCount is the number of semaphores upon which to wait before executing the sparse binding
    ///     operations for the batch.
    /// </summary>
    public uint waitSemaphoreCount;

    /// <summary>
    ///     pWaitSemaphores is a pointer to an array of semaphores upon which to wait on before the sparse binding
    ///     operations for this batch begin execution. If semaphores to wait on are provided, they define a semaphore wait
    ///     operation.
    /// </summary>
    public VkSemaphore* pWaitSemaphores;

    /// <summary>bufferBindCount is the number of sparse buffer bindings to perform in the batch.</summary>
    public uint bufferBindCount;

    /// <summary>pBufferBinds is a pointer to an array of VkSparseBufferMemoryBindInfo structures.</summary>
    public VkSparseBufferMemoryBindInfo* pBufferBinds;

    /// <summary>imageOpaqueBindCount is the number of opaque sparse image bindings to perform.</summary>
    public uint imageOpaqueBindCount;

    /// <summary>
    ///     pImageOpaqueBinds is a pointer to an array of VkSparseImageOpaqueMemoryBindInfo structures, indicating opaque
    ///     sparse image bindings to perform.
    /// </summary>
    public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;

    /// <summary>imageBindCount is the number of sparse image bindings to perform.</summary>
    public uint imageBindCount;

    /// <summary>
    ///     pImageBinds is a pointer to an array of VkSparseImageMemoryBindInfo structures, indicating sparse image
    ///     bindings to perform.
    /// </summary>
    public VkSparseImageMemoryBindInfo* pImageBinds;

    /// <summary>
    ///     signalSemaphoreCount is the number of semaphores to be signaled once the sparse binding operations specified
    ///     by the structure have completed execution.
    /// </summary>
    public uint signalSemaphoreCount;

    /// <summary>
    ///     pSignalSemaphores is a pointer to an array of semaphores which will be signaled when the sparse binding
    ///     operations for this batch have completed execution. If semaphores to be signaled are provided, they define a
    ///     semaphore signal operation.
    /// </summary>
    public VkSemaphore* pSignalSemaphores;
}