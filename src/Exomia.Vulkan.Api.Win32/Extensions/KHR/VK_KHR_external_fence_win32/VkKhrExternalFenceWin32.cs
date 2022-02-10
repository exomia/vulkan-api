#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Win32.VkKhrExternalFenceWin32;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_KHR_external_fence_win32 - device extension (nr. 115) - author 'KHR' [platform 'win32' | contact 'Jesse Hall
///     @critsec']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_fence_win32.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_fence_win32.html</a>
/// </summary>
[VkRequires("VK_KHR_external_fence")]
public static unsafe class VkKhrExternalFenceWin32
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME = "VK_KHR_external_fence_win32";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u4546\u434e\u5f45\u4957\u334e\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkImportFenceWin32HandleKHR - Import a fence from a Windows HANDLE -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportFenceWin32HandleKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportFenceWin32HandleKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the fence.</param>
    /// <param name="pImportFenceWin32HandleInfo">
    ///     pImportFenceWin32HandleInfo is a pointer to a VkImportFenceWin32HandleInfoKHR
    ///     structure specifying the fence and import parameters.
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
        VkImportFenceWin32HandleInfoKHR* /*pImportFenceWin32HandleInfo*/,
        VkResult> vkImportFenceWin32HandleKHR = null;

    /// <summary>
    ///     vkGetFenceWin32HandleKHR - Get a Windows HANDLE for a fence -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceWin32HandleKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceWin32HandleKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the fence being exported.</param>
    /// <param name="pGetWin32HandleInfo">
    ///     pGetWin32HandleInfo is a pointer to a VkFenceGetWin32HandleInfoKHR structure
    ///     containing parameters of the export operation.
    /// </param>
    /// <param name="pHandle">pHandle will return the Windows handle representing the fence state.</param>
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
        VkFenceGetWin32HandleInfoKHR* /*pGetWin32HandleInfo*/,
        HANDLE* /*pHandle*/,
        VkResult> vkGetFenceWin32HandleKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult>* pvkImportFenceWin32HandleKHR = &vkImportFenceWin32HandleKHR)
        {
            *pvkImportFenceWin32HandleKHR = (delegate*<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d49\u6f70\u7472\u6546\u636e\u5765\u6e69\u3233\u6148\u646e\u656c\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkFenceGetWin32HandleInfoKHR*, HANDLE*, VkResult>* pvkGetFenceWin32HandleKHR = &vkGetFenceWin32HandleKHR)
        {
            *pvkGetFenceWin32HandleKHR = (delegate*<VkDevice, VkFenceGetWin32HandleInfoKHR*, HANDLE*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4674\u6e65\u6563\u6957\u336e\u4832\u6e61\u6c64\u4b65\u5248\u0000");
        }
    }
}