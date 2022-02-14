#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvxBinaryImport;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NVX_binary_import - device extension (nr. 30) - author 'NVX' [platform '' | contact 'Eric Werness
///     @ewerness-nv,Liam Middlebrook @liam-middlebrook']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_binary_import.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_binary_import.html</a>
/// </summary>
public static unsafe class VkNvxBinaryImport
{
    /// <summary> The spec version. </summary>
    public const uint VK_NVX_BINARY_IMPORT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NVX_BINARY_IMPORT_EXTENSION_NAME = "VK_NVX_binary_import";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NVX_BINARY_IMPORT_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NVX_BINARY_IMPORT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NVX_BINARY_IMPORT_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5856\u425f\u4e49\u5241\u5f59\u4d49\u4f50\u5452\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateCuModuleNVX - Stub description of vkCreateCuModuleNVX -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCuModuleNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCuModuleNVX.html</a>
    /// </summary>
    /// <param name="device"> VUID-vkCreateCuModuleNVX-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="pCreateInfo">
    ///     VUID-vkCreateCuModuleNVX-pCreateInfo-parameter pCreateInfo must be a valid pointer to a
    ///     valid VkCuModuleCreateInfoNVX structure
    /// </param>
    /// <param name="pAllocator">
    ///     VUID-vkCreateCuModuleNVX-pAllocator-parameter If pAllocator is not NULL, pAllocator must be a
    ///     valid pointer to a valid VkAllocationCallbacks structure
    /// </param>
    /// <param name="pModule">
    ///     VUID-vkCreateCuModuleNVX-pModule-parameter pModule must be a valid pointer to a VkCuModuleNVX
    ///     handle
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCuModuleCreateInfoNVX* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkCuModuleNVX* /*pModule*/,
        VkResult> vkCreateCuModuleNVX = null;

    /// <summary>
    ///     vkCreateCuFunctionNVX - Stub description of vkCreateCuFunctionNVX -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCuFunctionNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCuFunctionNVX.html</a>
    /// </summary>
    /// <param name="device"> VUID-vkCreateCuFunctionNVX-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="pCreateInfo">
    ///     VUID-vkCreateCuFunctionNVX-pCreateInfo-parameter pCreateInfo must be a valid pointer to a
    ///     valid VkCuFunctionCreateInfoNVX structure
    /// </param>
    /// <param name="pAllocator">
    ///     VUID-vkCreateCuFunctionNVX-pAllocator-parameter If pAllocator is not NULL, pAllocator must be
    ///     a valid pointer to a valid VkAllocationCallbacks structure
    /// </param>
    /// <param name="pFunction">
    ///     VUID-vkCreateCuFunctionNVX-pFunction-parameter pFunction must be a valid pointer to a
    ///     VkCuFunctionNVX handle
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCuFunctionCreateInfoNVX* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkCuFunctionNVX* /*pFunction*/,
        VkResult> vkCreateCuFunctionNVX = null;

    /// <summary>
    ///     vkDestroyCuModuleNVX - Stub description of vkDestroyCuModuleNVX -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCuModuleNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCuModuleNVX.html</a>
    /// </summary>
    /// <param name="device"> VUID-vkDestroyCuModuleNVX-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="module"> VUID-vkDestroyCuModuleNVX-module-parameter module must be a valid VkCuModuleNVX handle</param>
    /// <param name="pAllocator">
    ///     VUID-vkDestroyCuModuleNVX-pAllocator-parameter If pAllocator is not NULL, pAllocator must be
    ///     a valid pointer to a valid VkAllocationCallbacks structure
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCuModuleNVX /*module*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyCuModuleNVX = null;

    /// <summary>
    ///     vkDestroyCuFunctionNVX - Stub description of vkDestroyCuFunctionNVX -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCuFunctionNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCuFunctionNVX.html</a>
    /// </summary>
    /// <param name="device"> VUID-vkDestroyCuFunctionNVX-device-parameter device must be a valid VkDevice handle</param>
    /// <param name="function"> VUID-vkDestroyCuFunctionNVX-function-parameter function must be a valid VkCuFunctionNVX handle</param>
    /// <param name="pAllocator">
    ///     VUID-vkDestroyCuFunctionNVX-pAllocator-parameter If pAllocator is not NULL, pAllocator must
    ///     be a valid pointer to a valid VkAllocationCallbacks structure
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCuFunctionNVX /*function*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyCuFunctionNVX = null;

    /// <summary>
    ///     vkCmdCuLaunchKernelNVX - Stub description of vkCmdCuLaunchKernelNVX -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCuLaunchKernelNVX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCuLaunchKernelNVX.html</a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     VUID-vkCmdCuLaunchKernelNVX-commandBuffer-parameter commandBuffer must be a valid
    ///     VkCommandBuffer handle
    /// </param>
    /// <param name="pLaunchInfo">
    ///     VUID-vkCmdCuLaunchKernelNVX-pLaunchInfo-parameter pLaunchInfo must be a valid pointer to a
    ///     valid VkCuLaunchInfoNVX structure
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCuLaunchInfoNVX* /*pLaunchInfo*/,
        void> vkCmdCuLaunchKernelNVX = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult>* pvkCreateCuModuleNVX = &vkCreateCuModuleNVX)
        {
            *pvkCreateCuModuleNVX = (delegate*<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7243\u6165\u6574\u7543\u6f4d\u7564\u656c\u564e\u0058");
        }
        fixed (delegate*<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult>* pvkCreateCuFunctionNVX = &vkCreateCuFunctionNVX)
        {
            *pvkCreateCuFunctionNVX = (delegate*<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7243\u6165\u6574\u7543\u7546\u636e\u6974\u6e6f\u564e\u0058");
        }
        fixed (delegate*<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>* pvkDestroyCuModuleNVX = &vkDestroyCuModuleNVX)
        {
            *pvkDestroyCuModuleNVX = (delegate*<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u7473\u6f72\u4379\u4d75\u646f\u6c75\u4e65\u5856\u0000");
        }
        fixed (delegate*<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>* pvkDestroyCuFunctionNVX = &vkDestroyCuFunctionNVX)
        {
            *pvkDestroyCuFunctionNVX = (delegate*<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u7473\u6f72\u4379\u4675\u6e75\u7463\u6f69\u4e6e\u5856\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkCuLaunchInfoNVX*, void>* pvkCmdCuLaunchKernelNVX = &vkCmdCuLaunchKernelNVX)
        {
            *pvkCmdCuLaunchKernelNVX = (delegate*<VkCommandBuffer, VkCuLaunchInfoNVX*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u4364\u4c75\u7561\u636e\u4b68\u7265\u656e\u4e6c\u5856\u0000");
        }
    }
}