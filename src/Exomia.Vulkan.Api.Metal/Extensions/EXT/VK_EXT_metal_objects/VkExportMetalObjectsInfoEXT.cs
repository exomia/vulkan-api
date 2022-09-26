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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalObjectsInfoEXT - Structure whose pNext chain identifies Vulkan objects and corresponding Metal objects -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectsInfoEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectsInfoEXT.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectsInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;
}