#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalMemoryFd;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_memory_fd - device extension (nr. 75) - author 'KHR' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_fd.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_fd.html</a>
/// </summary>
[VkDepends("VK_KHR_external_memory,VK_VERSION_1_1")]
public static unsafe class VkKhrExternalMemoryFd
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME = "VK_KHR_external_memory_fd";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u465f\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetMemoryFdKHR - Get a POSIX file descriptor for a memory object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the device memory being exported.</param>
    /// <param name="pGetFdInfo">
    ///     pGetFdInfo is a pointer to a VkMemoryGetFdInfoKHR structure containing parameters of the
    ///     export operation.
    /// </param>
    /// <param name="pFd">pFd will return a file descriptor referencing the payload of the device memory object.</param>
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
        VkMemoryGetFdInfoKHR* /*pGetFdInfo*/,
        int* /*pFd*/,
        VkResult> vkGetMemoryFdKHR = null;

    /// <summary>
    ///     vkGetMemoryFdPropertiesKHR - Get Properties of External Memory File Descriptors -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdPropertiesKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that will be importing fd.</param>
    /// <param name="handleType">handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of the handle fd.</param>
    /// <param name="fd">fd is the handle which will be imported.</param>
    /// <param name="pMemoryFdProperties">
    ///     pMemoryFdProperties is a pointer to a VkMemoryFdPropertiesKHR structure in which the
    ///     properties of the handle fd are returned.
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
        int /*fd*/,
        VkMemoryFdPropertiesKHR* /*pMemoryFdProperties*/,
        VkResult> vkGetMemoryFdPropertiesKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetMemoryFdKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetMemoryFdPropertiesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult>* pvkGetMemoryFdKHR = &vkGetMemoryFdKHR)
        {
            *pvkGetMemoryFdKHR = (delegate*<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult>)GetVkFunction(device, "\u6b76\u6547\u4d74\u6d65\u726f\u4679\u4b64\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult>* pvkGetMemoryFdPropertiesKHR = &vkGetMemoryFdPropertiesKHR)
        {
            *pvkGetMemoryFdPropertiesKHR = (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u4679\u5064\u6f72\u6570\u7472\u6569\u4b73\u5248\u0000");
        }
    }
}