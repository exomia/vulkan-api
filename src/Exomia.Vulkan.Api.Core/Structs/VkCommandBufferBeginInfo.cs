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
///     VkCommandBufferBeginInfo - Structure specifying a command buffer begin operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferBeginInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferBeginInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferBeginInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkCommandBufferUsageFlagBitsspecifying usage behavior for the command buffer.</summary>
    public VkCommandBufferUsageFlags flags;

    /// <summary>
    ///     pInheritanceInfo is a pointer to a VkCommandBufferInheritanceInfo structure, used if commandBuffer is a
    ///     secondary command buffer. If this is a primary command buffer, then this value is ignored.
    /// </summary>
    public VkCommandBufferInheritanceInfo* pInheritanceInfo;
}