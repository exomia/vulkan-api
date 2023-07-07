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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalObjectCreateInfoEXT - Structure that identifies the Metal objects that can be exported from
///     Vulkan objects -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkInstanceCreateInfo,VkMemoryAllocateInfo,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferViewCreateInfo,VkSemaphoreCreateInfo,VkEventCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkInstanceCreateInfo,VkMemoryAllocateInfo,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferViewCreateInfo,VkSemaphoreCreateInfo,VkEventCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     exportObjectType is a VkExportMetalObjectTypeFlagBitsEXTindicating the type of Metal object that the
    ///     application may request to be exported from the Vulkan object.
    /// </summary>
    public VkExportMetalObjectTypeFlagBitsEXT exportObjectType;
}