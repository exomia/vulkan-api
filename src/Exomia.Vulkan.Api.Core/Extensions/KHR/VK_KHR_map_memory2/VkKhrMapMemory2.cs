#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrMapMemory2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_map_memory2 - device extension (nr. 272) - author 'KHR' [platform '' | contact 'Faith Ekstrand @gfxstrand']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_map_memory2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_map_memory2.html</a>
/// </summary>
[VkDeviceExt]
public static unsafe class VkKhrMapMemory2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAP_MEMORY_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAP_MEMORY_2_EXTENSION_NAME = "VK_KHR_map_memory2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAP_MEMORY_2_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAP_MEMORY_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAP_MEMORY_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u5041\u4d5f\u4d45\u524f\u5f59\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkMapMemory2KHR - Map a memory object into application address space -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="pMemoryMapInfo">
    ///     pMemoryMapInfo is a pointer to a VkMemoryMapInfoKHRstructure describing parameters of the
    ///     map.
    /// </param>
    /// <param name="ppData">
    ///     ppData is a pointer to a void * variable in which is returned a host-accessible pointer to the
    ///     beginning of the mapped range. This pointer minus VkMemoryMapInfoKHR::offset must be aligned to at least
    ///     VkPhysicalDeviceLimits::minMemoryMapAlignment.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_MEMORY_MAP_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMemoryMapInfoKHR* /*pMemoryMapInfo*/,
        void** /*ppData*/,
        VkResult> vkMapMemory2KHR = null;

    /// <summary>
    ///     vkUnmapMemory2KHR - Unmap a previously mapped memory object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="pMemoryUnmapInfo">
    ///     pMemoryUnmapInfo is a pointer to a VkMemoryUnmapInfoKHRstructure describing parameters
    ///     of the unmap.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMemoryUnmapInfoKHR* /*pMemoryUnmapInfo*/,
        VkResult> vkUnmapMemory2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkMapMemory2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkUnmapMemory2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult>* pvkMapMemory2KHR = &vkMapMemory2KHR)
        {
            *pvkMapMemory2KHR = (delegate*<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult>)GetVkFunction(device, "\u6b76\u614d\u4d70\u6d65\u726f\u3279\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkMemoryUnmapInfoKHR*, VkResult>* pvkUnmapMemory2KHR = &vkUnmapMemory2KHR)
        {
            *pvkUnmapMemory2KHR = (delegate*<VkDevice, VkMemoryUnmapInfoKHR*, VkResult>)GetVkFunction(device, "\u6b76\u6e55\u616d\u4d70\u6d65\u726f\u3279\u484b\u0052");
        }
    }
}