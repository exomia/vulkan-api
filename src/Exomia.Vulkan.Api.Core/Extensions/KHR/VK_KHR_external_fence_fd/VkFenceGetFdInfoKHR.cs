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
///     VkFenceGetFdInfoKHR - Structure describing a POSIX FD fence export operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceGetFdInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceGetFdInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetFdInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>fence is the fence from which state will be exported.</summary>
    public VkFence fence;

    /// <summary>handleType is a VkExternalFenceHandleTypeFlagBits value specifying the type of handle requested.</summary>
    public VkExternalFenceHandleTypeFlagBits handleType;
}