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
///     VkCommandBufferAllocateInfo - Structure specifying the allocation parameters for command buffer object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferAllocateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferAllocateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferAllocateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>commandPool is the command pool from which the command buffers are allocated.</summary>
    public VkCommandPool commandPool;

    /// <summary>level is a VkCommandBufferLevel value specifying the command buffer level.</summary>
    public VkCommandBufferLevel level;

    /// <summary>commandBufferCount is the number of command buffers to allocate from the pool.</summary>
    public uint commandBufferCount;
}