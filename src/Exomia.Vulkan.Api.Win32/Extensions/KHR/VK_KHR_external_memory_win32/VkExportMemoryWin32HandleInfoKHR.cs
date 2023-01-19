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
///     VkExportMemoryWin32HandleInfoKHR - Structure specifying additional attributes of Windows handles exported
///     from a memory -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMemoryWin32HandleInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMemoryWin32HandleInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkMemoryAllocateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkMemoryAllocateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pAttributes is a pointer to a Windows SECURITY_ATTRIBUTESstructure specifying security attributes of the
    ///     handle.
    /// </summary>
    public SECURITY_ATTRIBUTES* pAttributes;

    /// <summary>dwAccess is a DWORD specifying access rights of the handle.</summary>
    public DWORD dwAccess;

    /// <summary>
    ///     name is a null-terminated UTF-16 string to associate with the payload referenced by NT handles exported from
    ///     the created memory.
    /// </summary>
    public char* name;
}