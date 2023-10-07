#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalFenceFd;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_fence_fd - device extension (nr. 116) - author 'KHR' [platform '' | contact 'Jesse Hall @critsec']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_fence_fd.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_fence_fd.html</a>
/// </summary>
[VkDepends("VK_KHR_external_fence,VK_VERSION_1_1")]
[VkDeviceExt]
public static unsafe class VkKhrExternalFenceFd
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME = "VK_KHR_external_fence_fd";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u4546\u434e\u5f45\u4446\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkImportFenceFdKHR - Import a fence from a POSIX file descriptor -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportFenceFdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportFenceFdKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the fence.</param>
    /// <param name="pImportFenceFdInfo">
    ///     pImportFenceFdInfo is a pointer to a VkImportFenceFdInfoKHRstructure specifying the
    ///     fence and import parameters.
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
        VkImportFenceFdInfoKHR* /*pImportFenceFdInfo*/,
        VkResult> vkImportFenceFdKHR = null;

    /// <summary>
    ///     vkGetFenceFdKHR - Get a POSIX file descriptor handle for a fence -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceFdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFenceFdKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the fence being exported.</param>
    /// <param name="pGetFdInfo">
    ///     pGetFdInfo is a pointer to a VkFenceGetFdInfoKHR structure containing parameters of the export
    ///     operation.
    /// </param>
    /// <param name="pFd">pFd will return the file descriptor representing the fence payload.</param>
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
        VkFenceGetFdInfoKHR* /*pGetFdInfo*/,
        int* /*pFd*/,
        VkResult> vkGetFenceFdKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkImportFenceFdKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetFenceFdKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImportFenceFdInfoKHR*, VkResult>* pvkImportFenceFdKHR = &vkImportFenceFdKHR)
        {
            *pvkImportFenceFdKHR = (delegate*<VkDevice, VkImportFenceFdInfoKHR*, VkResult>)GetVkFunction(device, "\u6b76\u6d49\u6f70\u7472\u6546\u636e\u4665\u4b64\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult>* pvkGetFenceFdKHR = &vkGetFenceFdKHR)
        {
            *pvkGetFenceFdKHR = (delegate*<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult>)GetVkFunction(device, "\u6b76\u6547\u4674\u6e65\u6563\u6446\u484b\u0052");
        }
    }
}