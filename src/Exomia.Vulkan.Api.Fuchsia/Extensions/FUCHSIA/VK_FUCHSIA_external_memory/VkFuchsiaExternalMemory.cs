#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Fuchsia.VkFuchsiaExternalMemory;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VK_FUCHSIA_external_memory - device extension (nr. 365) - author 'FUCHSIA' [platform 'fuchsia' | contact 'John
///     Rosasco @rosasco']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_external_memory.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_external_memory.html</a>
/// </summary>
[VkDepends("VK_KHR_external_memory_capabilities+VK_KHR_external_memory")]
public static unsafe class VkFuchsiaExternalMemory
{
    /// <summary> The spec version. </summary>
    public const uint VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME = "VK_FUCHSIA_external_memory";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u465f\u4355\u5348\u4149\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetMemoryZirconHandleFUCHSIA - Get a Zircon handle for an external memory object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandleFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandleFUCHSIA.html</a>
    /// </summary>
    /// <param name="device">device is the VkDevice.</param>
    /// <param name="pGetZirconHandleInfo">pGetZirconHandleInfo is a pointer to a VkMemoryGetZirconHandleInfoFUCHSIA structure.</param>
    /// <param name="pZirconHandle">pZirconHandle is a pointer to a zx_handle_t which holds the resulting Zircon handle.</param>
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
        VkMemoryGetZirconHandleInfoFUCHSIA* /*pGetZirconHandleInfo*/,
        zx_handle_t* /*pZirconHandle*/,
        VkResult> vkGetMemoryZirconHandleFUCHSIA = null;

    /// <summary>
    ///     vkGetMemoryZirconHandlePropertiesFUCHSIA - Get a Zircon handle properties for an external memory object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandlePropertiesFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandlePropertiesFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the VkDevice.</param>
    /// <param name="handleType">handleType is a VkExternalMemoryHandleTypeFlagBits value specifying the type of zirconHandle</param>
    /// <param name="zirconHandle">zirconHandle is a zx_handle_t (Zircon) handle to the external resource.</param>
    /// <param name="pMemoryZirconHandleProperties">
    ///     pMemoryZirconHandleProperties is a pointer to a
    ///     VkMemoryZirconHandlePropertiesFUCHSIA structure in which the result will be stored.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_INVALID_EXTERNAL_HANDLE</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkExternalMemoryHandleTypeFlagBits /*handleType*/,
        zx_handle_t /*zirconHandle*/,
        VkMemoryZirconHandlePropertiesFUCHSIA* /*pMemoryZirconHandleProperties*/,
        VkResult> vkGetMemoryZirconHandlePropertiesFUCHSIA = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetMemoryZirconHandleFUCHSIA</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetMemoryZirconHandlePropertiesFUCHSIA</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, zx_handle_t*, VkResult>* pvkGetMemoryZirconHandleFUCHSIA = &vkGetMemoryZirconHandleFUCHSIA)
        {
            *pvkGetMemoryZirconHandleFUCHSIA = (delegate*<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, zx_handle_t*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u5a79\u7269\u6f63\u486e\u6e61\u6c64\u4665\u4355\u5348\u4149\u0000");
        }

        fixed (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, zx_handle_t, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult>* pvkGetMemoryZirconHandlePropertiesFUCHSIA =
            &vkGetMemoryZirconHandlePropertiesFUCHSIA)
        {
            *pvkGetMemoryZirconHandlePropertiesFUCHSIA = (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, zx_handle_t, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u5a79\u7269\u6f63\u486e\u6e61\u6c64\u5065\u6f72\u6570\u7472\u6569\u4673\u4355\u5348\u4149\u0000");
        }
    }
}