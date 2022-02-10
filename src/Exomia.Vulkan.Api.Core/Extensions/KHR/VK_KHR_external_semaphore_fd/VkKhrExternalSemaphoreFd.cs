#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalSemaphoreFd;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_semaphore_fd - device extension (nr. 80) - author 'KHR' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_fd.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_fd.html</a>
/// </summary>
[VkRequires("VK_KHR_external_semaphore")]
public static unsafe class VkKhrExternalSemaphoreFd
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME = "VK_KHR_external_semaphore_fd";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u4553\u414d\u4850\u524f\u5f45\u4446\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkImportSemaphoreFdKHR - Import a semaphore from a POSIX file descriptor -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreFdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreFdKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore.</param>
    /// <param name="pImportSemaphoreFdInfo">
    ///     pImportSemaphoreFdInfo is a pointer to a VkImportSemaphoreFdInfoKHR structure
    ///     specifying the semaphore and import parameters.
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
        VkImportSemaphoreFdInfoKHR* /*pImportSemaphoreFdInfo*/,
        VkResult> vkImportSemaphoreFdKHR = null;

    /// <summary>
    ///     vkGetSemaphoreFdKHR - Get a POSIX file descriptor handle for a semaphore -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreFdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreFdKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore being exported.</param>
    /// <param name="pGetFdInfo">
    ///     pGetFdInfo is a pointer to a VkSemaphoreGetFdInfoKHRstructure containing parameters of the
    ///     export operation.
    /// </param>
    /// <param name="pFd">pFd will return the file descriptor representing the semaphore payload.</param>
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
        VkSemaphoreGetFdInfoKHR* /*pGetFdInfo*/,
        int* /*pFd*/,
        VkResult> vkGetSemaphoreFdKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult>* pvkImportSemaphoreFdKHR = &vkImportSemaphoreFdKHR)
        {
            *pvkImportSemaphoreFdKHR = (delegate*<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d49\u6f70\u7472\u6553\u616d\u6870\u726f\u4665\u4b64\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult>* pvkGetSemaphoreFdKHR = &vkGetSemaphoreFdKHR)
        {
            *pvkGetSemaphoreFdKHR = (delegate*<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult>)Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5374\u6d65\u7061\u6f68\u6572\u6446\u484b\u0052");
        }
    }
}