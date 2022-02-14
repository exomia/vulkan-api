#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPageableDeviceLocalMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_pageable_device_local_memory - device extension (nr. 413) - author 'EXT' [platform '' | contact 'Piers
///     Daniell @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pageable_device_local_memory.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pageable_device_local_memory.html
///     </a>
/// </summary>
[VkRequires("VK_EXT_memory_priority")]
public static unsafe class VkExtPageableDeviceLocalMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME = "VK_EXT_pageable_device_local_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u505f\u4741\u4145\u4c42\u5f45\u4544\u4956\u4543\u4c5f\u434f\u4c41\u4d5f\u4d45\u524f\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkSetDeviceMemoryPriorityEXT - Change a memory allocation priority -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDeviceMemoryPriorityEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetDeviceMemoryPriorityEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="memory">memory is the VkDeviceMemory object to which the new priority will be applied.</param>
    /// <param name="priority">
    ///     priority is a floating-point value between 0 and 1, indicating the priority of the allocation
    ///     relative to other memory allocations. Larger values are higher priority. The granularity of the priorities is
    ///     implementation-dependent.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceMemory /*memory*/,
        float /*priority*/,
        void> vkSetDeviceMemoryPriorityEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDeviceMemory, float, void>* pvkSetDeviceMemoryPriorityEXT = &vkSetDeviceMemoryPriorityEXT)
        {
            *pvkSetDeviceMemoryPriorityEXT = (delegate*<VkDevice, VkDeviceMemory, float, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6553\u4474\u7665\u6369\u4d65\u6d65\u726f\u5079\u6972\u726f\u7469\u4579\u5458\u0000");
        }
    }
}