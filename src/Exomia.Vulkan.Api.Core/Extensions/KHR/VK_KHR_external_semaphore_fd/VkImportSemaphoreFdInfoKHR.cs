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
///     VkImportSemaphoreFdInfoKHR - Structure specifying POSIX file descriptor to import to a semaphore -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreFdInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreFdInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreFdInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>semaphore is the semaphore into which the payload will be imported.</summary>
    public VkSemaphore semaphore;

    /// <summary>
    ///     flags is a bitmask of VkSemaphoreImportFlagBits specifying additional parameters for the semaphore payload
    ///     import operation.
    /// </summary>
    public VkSemaphoreImportFlags flags;

    /// <summary>handleType is a VkExternalSemaphoreHandleTypeFlagBits value specifying the type of fd.</summary>
    public VkExternalSemaphoreHandleTypeFlagBits handleType;

    /// <summary>fd is the external handle to import.</summary>
    public int fd;
}