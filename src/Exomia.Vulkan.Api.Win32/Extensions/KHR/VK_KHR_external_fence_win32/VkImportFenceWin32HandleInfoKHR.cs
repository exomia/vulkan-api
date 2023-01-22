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
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VkImportFenceWin32HandleInfoKHR - (None) -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportFenceWin32HandleInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportFenceWin32HandleInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>fence is the fence into which the state will be imported.</summary>
    public VkFence fence;

    /// <summary>
    ///     flags is a bitmask of VkFenceImportFlagBits specifying additional parameters for the fence payload import
    ///     operation.
    /// </summary>
    public VkFenceImportFlags flags;

    /// <summary>handleType is a VkExternalFenceHandleTypeFlagBits value specifying the type of handle.</summary>
    public VkExternalFenceHandleTypeFlagBits handleType;

    /// <summary>handle is NULL or the external handle to import.</summary>
    public HANDLE handle;

    /// <summary>name is NULL or a null-terminated UTF-16 string naming the underlying synchronization primitive to import.</summary>
    public char* name;
}