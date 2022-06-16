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
///     VkImportMetalSharedEventInfoEXT - Structure that identifies a VkSemaphore or VkEvent object and corresponding
///     Metal Shared Event object to use. -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMetalSharedEventInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImportMetalSharedEventInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSemaphoreCreateInfo,VkEventCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSemaphoreCreateInfo,VkEventCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalSharedEventInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>mtlSharedEvent is the Metal id&lt;MTLSharedEvent&gt; object that is to underlie the VkSemaphore or VkEvent.</summary>
    public MTLSharedEvent_id mtlSharedEvent;
}