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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkImportSemaphoreZirconHandleInfoFUCHSIA - Structure specifying Zircon event handle to import to a semaphore -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreZirconHandleInfoFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreZirconHandleInfoFUCHSIA.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportSemaphoreZirconHandleInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA;

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

    /// <summary>handleType is a VkExternalSemaphoreHandleTypeFlagBits value specifying the type of zirconHandle.</summary>
    public VkExternalSemaphoreHandleTypeFlagBits handleType;

    /// <summary>zirconHandle is the external handle to import.</summary>
    public zx_handle_t zirconHandle;
}