#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvExternalMemoryRdma;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_external_memory_rdma - device extension (nr. 372) - author 'NV' [platform '' | contact 'Carsten Rohde
///     @crohde']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_rdma.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_rdma.html</a>
/// </summary>
[VkRequires("VK_KHR_external_memory")]
public static unsafe class VkNvExternalMemoryRdma
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME = "VK_NV_external_memory_rdma";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u5845\u4554\u4e52\u4c41\u4d5f\u4d45\u524f\u5f59\u4452\u414d\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetMemoryRemoteAddressNV - Get an address for a memory object accessible by remote devices -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryRemoteAddressNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryRemoteAddressNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the device memory being exported.</param>
    /// <param name="pMemoryGetRemoteAddressInfo">
    ///     pMemoryGetRemoteAddressInfo is a pointer to a VkMemoryGetRemoteAddressInfoNV
    ///     structure containing parameters of the export operation.
    /// </param>
    /// <param name="pAddress">pAddress will return the address representing the payload of the device memory object.</param>
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
        VkMemoryGetRemoteAddressInfoNV* /*pMemoryGetRemoteAddressInfo*/,
        VkRemoteAddressNV* /*pAddress*/,
        VkResult> vkGetMemoryRemoteAddressNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetMemoryRemoteAddressNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult>* pvkGetMemoryRemoteAddressNV = &vkGetMemoryRemoteAddressNV)
        {
            *pvkGetMemoryRemoteAddressNV = (delegate*<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4d74\u6d65\u726f\u5279\u6d65\u746f\u4165\u6464\u6572\u7373\u564e\u0000");
        }
    }
}