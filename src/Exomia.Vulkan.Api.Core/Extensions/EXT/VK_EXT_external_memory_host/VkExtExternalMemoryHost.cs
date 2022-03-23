#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtExternalMemoryHost;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_external_memory_host - device extension (nr. 179) - author 'EXT' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_external_memory_host.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_external_memory_host.html</a>
/// </summary>
[VkRequires("VK_KHR_external_memory")]
public static unsafe class VkExtExternalMemoryHost
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME = "VK_EXT_external_memory_host";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u485f\u534f\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetMemoryHostPointerPropertiesEXT - Get properties of external memory host pointer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryHostPointerPropertiesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryHostPointerPropertiesEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that will be importing pHostPointer.</param>
    /// <param name="handleType">
    ///     handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of the handle
    ///     pHostPointer.
    /// </param>
    /// <param name="pHostPointer">pHostPointer is the host pointer to import from.</param>
    /// <param name="pMemoryHostPointerProperties">
    ///     pMemoryHostPointerProperties is a pointer to a
    ///     VkMemoryHostPointerPropertiesEXT structure in which the host pointer properties are returned.
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
        void* /*pHostPointer*/,
        VkMemoryHostPointerPropertiesEXT* /*pMemoryHostPointerProperties*/,
        VkResult> vkGetMemoryHostPointerPropertiesEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetMemoryHostPointerPropertiesEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult>* pvkGetMemoryHostPointerPropertiesEXT = &vkGetMemoryHostPointerPropertiesEXT)
        {
            *pvkGetMemoryHostPointerPropertiesEXT = (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u4879\u736f\u5074\u696f\u746e\u7265\u7250\u706f\u7265\u6974\u7365\u5845\u0054");
        }
    }
}