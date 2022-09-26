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
///     VkCommandBufferSubmitInfo - Structure specifying a command buffer submission -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferSubmitInfo.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferSubmitInfo.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandBufferSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> commandBuffer is a VkCommandBuffer to be submitted for execution. </summary>
    public VkCommandBuffer commandBuffer;

    /// <summary> deviceMask is a bitmask indicating which devices in a device group execute the command buffer. A deviceMask of 0 is equivalent to setting all bits corresponding to valid devices in the group to 1. </summary>
    public uint deviceMask;
}