#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Win32.VkKhrExternalMemoryWin32;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_KHR_external_memory_win32 - device extension (nr. 74) - author 'KHR' [platform 'win32' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_win32.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_win32.html</a>
/// </summary>
[VkRequires("VK_KHR_external_memory")]
public static unsafe class VkKhrExternalMemoryWin32
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME = "VK_KHR_external_memory_win32";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u575f\u4e49\u3233\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetMemoryWin32HandleKHR - Get a Windows HANDLE for a memory object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the device memory being exported.</param>
    /// <param name="pGetWin32HandleInfo">
    ///     pGetWin32HandleInfo is a pointer to a VkMemoryGetWin32HandleInfoKHR structure
    ///     containing parameters of the export operation.
    /// </param>
    /// <param name="pHandle">pHandle will return the Windows handle representing the payload of the device memory object.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkMemoryGetWin32HandleInfoKHR* /*pGetWin32HandleInfo*/,
        HANDLE* /*pHandle*/,
        VkResult> vkGetMemoryWin32HandleKHR = null;

    /// <summary>
    ///     vkGetMemoryWin32HandlePropertiesKHR - Get Properties of External Memory Win32 Handles -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandlePropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandlePropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that will be importing handle.</param>
    /// <param name="handleType">
    ///     handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of the handle
    ///     handle.
    /// </param>
    /// <param name="handle">handle is the handle which will be imported.</param>
    /// <param name="pMemoryWin32HandleProperties">
    ///     pMemoryWin32HandleProperties is a pointer to a
    ///     VkMemoryWin32HandlePropertiesKHR structure in which properties of handle are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INVALID_EXTERNAL_HANDLE</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkExternalMemoryHandleTypeFlagBits /*handleType*/,
        HANDLE /*handle*/,
        VkMemoryWin32HandlePropertiesKHR* /*pMemoryWin32HandleProperties*/,
        VkResult> vkGetMemoryWin32HandlePropertiesKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetMemoryWin32HandleKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetMemoryWin32HandlePropertiesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMemoryGetWin32HandleInfoKHR*, HANDLE*, VkResult>* pvkGetMemoryWin32HandleKHR = &vkGetMemoryWin32HandleKHR)
        {
            *pvkGetMemoryWin32HandleKHR = (delegate*<VkDevice, VkMemoryGetWin32HandleInfoKHR*, HANDLE*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u5779\u6e69\u3233\u6148\u646e\u656c\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, HANDLE, VkMemoryWin32HandlePropertiesKHR*, VkResult>* pvkGetMemoryWin32HandlePropertiesKHR =
            &vkGetMemoryWin32HandlePropertiesKHR)
        {
            *pvkGetMemoryWin32HandlePropertiesKHR = (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, HANDLE, VkMemoryWin32HandlePropertiesKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u5779\u6e69\u3233\u6148\u646e\u656c\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }
    }
}