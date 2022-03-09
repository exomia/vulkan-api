#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Fuchsia.VkFuchsiaExternalSemaphore;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VK_FUCHSIA_external_semaphore - device extension (nr. 366) - author 'FUCHSIA' [platform 'fuchsia' | contact 'John
///     Rosasco @rosasco']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_external_semaphore.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_external_semaphore.html</a>
/// </summary>
[VkRequires("VK_KHR_external_semaphore_capabilities,VK_KHR_external_semaphore")]
public static unsafe class VkFuchsiaExternalSemaphore
{
    /// <summary> The spec version. </summary>
    public const uint VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME = "VK_FUCHSIA_external_semaphore";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u465f\u4355\u5348\u4149\u455f\u5458\u5245\u414e\u5f4c\u4553\u414d\u4850\u524f\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkImportSemaphoreZirconHandleFUCHSIA - Import a semaphore from a Zircon event handle -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreZirconHandleFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreZirconHandleFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore.</param>
    /// <param name="pImportSemaphoreZirconHandleInfo">
    ///     pImportSemaphoreZirconHandleInfo is a pointer to a
    ///     VkImportSemaphoreZirconHandleInfoFUCHSIA structure specifying the semaphore and import parameters.
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
        VkImportSemaphoreZirconHandleInfoFUCHSIA* /*pImportSemaphoreZirconHandleInfo*/,
        VkResult> vkImportSemaphoreZirconHandleFUCHSIA = null;

    /// <summary>
    ///     vkGetSemaphoreZirconHandleFUCHSIA - Get a Zircon event handle for a semaphore -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreZirconHandleFUCHSIA.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreZirconHandleFUCHSIA.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that created the semaphore being exported.</param>
    /// <param name="pGetZirconHandleInfo">
    ///     pGetZirconHandleInfo is a pointer to a VkSemaphoreGetZirconHandleInfoFUCHSIA
    ///     structure containing parameters of the export operation.
    /// </param>
    /// <param name="pZirconHandle">pZirconHandle will return the Zircon event handle representing the semaphore payload.</param>
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
        VkSemaphoreGetZirconHandleInfoFUCHSIA* /*pGetZirconHandleInfo*/,
        zx_handle_t* /*pZirconHandle*/,
        VkResult> vkGetSemaphoreZirconHandleFUCHSIA = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkImportSemaphoreZirconHandleFUCHSIA</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetSemaphoreZirconHandleFUCHSIA</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult>* pvkImportSemaphoreZirconHandleFUCHSIA = &vkImportSemaphoreZirconHandleFUCHSIA)
        {
            *pvkImportSemaphoreZirconHandleFUCHSIA = (delegate*<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d49\u6f70\u7472\u6553\u616d\u6870\u726f\u5a65\u7269\u6f63\u486e\u6e61\u6c64\u4665\u4355\u5348\u4149\u0000");
        }

        fixed (delegate*<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, zx_handle_t*, VkResult>* pvkGetSemaphoreZirconHandleFUCHSIA = &vkGetSemaphoreZirconHandleFUCHSIA)
        {
            *pvkGetSemaphoreZirconHandleFUCHSIA = (delegate*<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, zx_handle_t*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5374\u6d65\u7061\u6f68\u6572\u695a\u6372\u6e6f\u6148\u646e\u656c\u5546\u4843\u4953\u0041");
        }
    }
}