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
///     VkExportMetalSharedEventInfoEXT - Structure that identifies a VkSemaphore or VkEvent object and corresponding Metal MTLSharedEvent object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalSharedEventInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalSharedEventInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkExportMetalObjectsInfoEXT </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkExportMetalObjectsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalSharedEventInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> semaphore is VK_NULL_HANDLE or a VkSemaphore. </summary>
    public VkSemaphore semaphore;

    /// <summary> event is VK_NULL_HANDLE or a VkEvent. </summary>
    public VkEvent @event;

    /// <summary> mtlSharedEvent is the Metal id&lt;MTLSharedEvent&gt; object underlying the VkSemaphore or VkEvent object in semaphore or event, respectively. The implementation will return the MTLSharedEvent in this member, or it will return NULL if no MTLSharedEvent could be found underlying the VkSemaphore or VkEvent object. </summary>
    public MTLSharedEvent_id mtlSharedEvent;
}