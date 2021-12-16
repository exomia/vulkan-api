#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindSparseInfo
{
    public const VkStructureType                    STYPE = VkStructureType.BIND_SPARSE_INFO;
    public       VkStructureType                    sType;
    public       void*                              pNext;
    public       uint                               waitSemaphoreCount;
    public       VkSemaphore*                       pWaitSemaphores;
    public       uint                               bufferBindCount;
    public       VkSparseBufferMemoryBindInfo*      pBufferBinds;
    public       uint                               imageOpaqueBindCount;
    public       VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
    public       uint                               imageBindCount;
    public       VkSparseImageMemoryBindInfo*       pImageBinds;
    public       uint                               signalSemaphoreCount;
    public       VkSemaphore*                       pSignalSemaphores;
}