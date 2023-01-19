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
///     VkDeviceMemoryReportCallbackDataEXT - Structure specifying parameters returned to the callback -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportCallbackDataEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportCallbackDataEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is 0 and reserved for future use.</summary>
    public VkDeviceMemoryReportFlagsEXT flags;

    /// <summary>
    ///     type is a VkDeviceMemoryReportEventTypeEXT type specifying the type of event reported in this
    ///     VkDeviceMemoryReportCallbackDataEXT structure.
    /// </summary>
    public VkDeviceMemoryReportEventTypeEXT type;

    /// <summary>memoryObjectId is the unique id for the underlying memory object as described below.</summary>
    public ulong memoryObjectId;

    /// <summary>
    ///     size is the size of the memory object in bytes. If type is VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT,
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT or VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT, size is
    ///     a valid VkDeviceSize value. Otherwise, size is undefined.
    /// </summary>
    public VkDeviceSize size;

    /// <summary>
    ///     objectType is a VkObjectType value specifying the type of the object associated with this device memory report
    ///     event. If type is VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT, VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT,
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT, VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT or
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT, objectType is a valid VkObjectType enum. Otherwise,
    ///     objectType is undefined.
    /// </summary>
    public VkObjectType objectType;

    /// <summary>
    ///     objectHandle is the object this device memory report event is attributed to. If type is
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT, VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT,
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT or VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT, objectHandle is a
    ///     valid Vulkan handle of the type associated with objectType as defined in the VkObjectType and Vulkan Handle
    ///     Relationship table. Otherwise, objectHandle is undefined.
    /// </summary>
    public ulong objectHandle;

    /// <summary>
    ///     heapIndex describes which memory heap this device memory allocation is made from. If type is
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXTor VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT,
    ///     heapIndex corresponds to one of the valid heaps from the VkPhysicalDeviceMemoryProperties structure. Otherwise,
    ///     heapIndex is undefined.
    /// </summary>
    public uint heapIndex;
}