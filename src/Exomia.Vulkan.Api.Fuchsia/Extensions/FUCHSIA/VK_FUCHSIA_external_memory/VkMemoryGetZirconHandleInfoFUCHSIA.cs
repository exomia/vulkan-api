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
///     VkMemoryGetZirconHandleInfoFUCHSIA - Structure specifying export parameters for Zircon handle to device
///     memory -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetZirconHandleInfoFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryGetZirconHandleInfoFUCHSIA.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetZirconHandleInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>memory the VkDeviceMemory being exported.</summary>
    public VkDeviceMemory memory;

    /// <summary>
    ///     handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of the handle pointed to by
    ///     vkGetMemoryZirconHandleFUCHSIA::pZirconHandle.
    /// </summary>
    public VkExternalMemoryHandleTypeFlagBits handleType;
}