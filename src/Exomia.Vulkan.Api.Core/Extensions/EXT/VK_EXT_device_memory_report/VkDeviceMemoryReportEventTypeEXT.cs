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
///     VkDeviceMemoryReportEventTypeEXT - Events that can occur on a device memory object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportEventTypeEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportEventTypeEXT.html
///     </a>
/// </summary>
public enum VkDeviceMemoryReportEventTypeEXT
{
    /// <summary>
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT specifies this event corresponds to the allocation of an
    ///     internal device memory object or a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemory.html">VkDeviceMemory</a>
    ///     .
    /// </summary>
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = 0,

    /// <summary>
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT specifies this event corresponds to the deallocation of an
    ///     internally-allocated device memory object or a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemory.html">VkDeviceMemory</a>
    ///     .
    /// </summary>
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = 1,

    /// <summary>
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT specifies this event corresponds to the import of an external
    ///     memory object.
    /// </summary>
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = 2,

    /// <summary>
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT specifies this event is the release of an imported external
    ///     memory object.
    /// </summary>
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = 3,

    /// <summary>
    ///     VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT specifies this event corresponds to the failed
    ///     allocation of an internal device memory object or a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceMemory.html">VkDeviceMemory</a>
    ///     .
    /// </summary>
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = 4
}