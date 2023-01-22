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
///     VkExportMemoryAllocateInfoNV - Specify memory handle types that may be exported -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMemoryAllocateInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMemoryAllocateInfoNV.html</a>
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
public unsafe struct VkExportMemoryAllocateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     handleTypes is a bitmask of VkExternalMemoryHandleTypeFlagBitsNV specifying one or more memory handle types
    ///     that may be exported. Multiple handle types may be requested for the same allocation as long as they are
    ///     compatible, as reported by vkGetPhysicalDeviceExternalImageFormatPropertiesNV.
    /// </summary>
    public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}