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
///     VkImportFenceFdInfoKHR - (None) -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportFenceFdInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportFenceFdInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceFdInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>fence is the fence into which the payload will be imported.</summary>
    public VkFence fence;

    /// <summary>
    ///     flags is a bitmask of VkFenceImportFlagBits specifying additional parameters for the fence payload import
    ///     operation.
    /// </summary>
    public VkFenceImportFlags flags;

    /// <summary>handleType is a VkExternalFenceHandleTypeFlagBits value specifying the type of fd.</summary>
    public VkExternalFenceHandleTypeFlagBits handleType;

    /// <summary>fd is the external handle to import.</summary>
    public int fd;
}