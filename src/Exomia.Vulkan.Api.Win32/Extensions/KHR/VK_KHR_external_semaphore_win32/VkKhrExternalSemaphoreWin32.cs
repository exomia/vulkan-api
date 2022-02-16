#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Win32.VkKhrExternalSemaphoreWin32;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_KHR_external_semaphore_win32 - device extension (nr. 79) - author 'KHR' [platform 'win32' | contact 'James Jones
///     @cubanismo']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_win32.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_win32.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_external_semaphore")]
public static unsafe class VkKhrExternalSemaphoreWin32
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME = "VK_KHR_external_semaphore_win32";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u4553\u414d\u4850\u524f\u5f45\u4957\u334e\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkImportSemaphoreWin32HandleKHR - Import a semaphore from a Windows HANDLE -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreWin32HandleKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreWin32HandleKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore.</param>
    /// <param name="pImportSemaphoreWin32HandleInfo">
    ///     pImportSemaphoreWin32HandleInfo is a pointer to a
    ///     VkImportSemaphoreWin32HandleInfoKHR structure specifying the semaphore and import parameters.
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
        VkImportSemaphoreWin32HandleInfoKHR* /*pImportSemaphoreWin32HandleInfo*/,
        VkResult> vkImportSemaphoreWin32HandleKHR = null;

    /// <summary>
    ///     vkGetSemaphoreWin32HandleKHR - Get a Windows HANDLE for a semaphore -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreWin32HandleKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreWin32HandleKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore being exported.</param>
    /// <param name="pGetWin32HandleInfo">
    ///     pGetWin32HandleInfo is a pointer to a VkSemaphoreGetWin32HandleInfoKHR structure
    ///     containing parameters of the export operation.
    /// </param>
    /// <param name="pHandle">pHandle will return the Windows handle representing the semaphore state.</param>
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
        VkSemaphoreGetWin32HandleInfoKHR* /*pGetWin32HandleInfo*/,
        HANDLE* /*pHandle*/,
        VkResult> vkGetSemaphoreWin32HandleKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkImportSemaphoreWin32HandleKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetSemaphoreWin32HandleKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult>* pvkImportSemaphoreWin32HandleKHR = &vkImportSemaphoreWin32HandleKHR)
        {
            *pvkImportSemaphoreWin32HandleKHR = (delegate*<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d49\u6f70\u7472\u6553\u616d\u6870\u726f\u5765\u6e69\u3233\u6148\u646e\u656c\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, HANDLE*, VkResult>* pvkGetSemaphoreWin32HandleKHR = &vkGetSemaphoreWin32HandleKHR)
        {
            *pvkGetSemaphoreWin32HandleKHR = (delegate*<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, HANDLE*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5374\u6d65\u7061\u6f68\u6572\u6957\u336e\u4832\u6e61\u6c64\u4b65\u5248\u0000");
        }
    }
}