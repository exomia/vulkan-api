#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvCudaKernelLaunch;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_cuda_kernel_launch - device extension (nr. 308) - author 'NV' [platform '' | contact 'Tristan Lorach
///     @tlorach']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_cuda_kernel_launch.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_cuda_kernel_launch.html</a>
/// </summary>
/// <remarks>
///     provisional: true
/// </remarks>
[VkProvisional("true")]
[VkDeviceExt]
public static unsafe class VkNvCudaKernelLaunch
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_CUDA_KERNEL_LAUNCH_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME = "VK_NV_cuda_kernel_launch";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u5543\u4144\u4b5f\u5245\u454e\u5f4c\u414c\u4e55\u4843\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateCudaModuleNV - Creates a new CUDA module object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCudaModuleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCudaModuleNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the shader module.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkCudaModuleCreateInfoNVstructure.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pModule">
    ///     pModule is a pointer to a VkCudaModuleNV handle in which the resulting CUDA module object is
    ///     returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCudaModuleCreateInfoNV* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkCudaModuleNV* /*pModule*/,
        VkResult> vkCreateCudaModuleNV = null;

    /// <summary>
    ///     vkGetCudaModuleCacheNV - Get CUDA module cache -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetCudaModuleCacheNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetCudaModuleCacheNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the Function.</param>
    /// <param name="module">module is the CUDA module.</param>
    /// <param name="pCacheSize">pCacheSize is a pointer containing the amount of bytes to be copied in pCacheData</param>
    /// <param name="pCacheData">pCacheData is a pointer to a buffer in which to copy the binary cache</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCudaModuleNV /*module*/,
        nuint* /*pCacheSize*/,
        void* /*pCacheData*/,
        VkResult> vkGetCudaModuleCacheNV = null;

    /// <summary>
    ///     vkCreateCudaFunctionNV - Creates a new CUDA function object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCudaFunctionNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateCudaFunctionNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the shader module.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkCudaFunctionCreateInfoNVstructure.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pFunction">
    ///     pFunction is a pointer to a VkCudaFunctionNV handle in which the resulting CUDA function object
    ///     is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCudaFunctionCreateInfoNV* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkCudaFunctionNV* /*pFunction*/,
        VkResult> vkCreateCudaFunctionNV = null;

    /// <summary>
    ///     vkDestroyCudaModuleNV - Destroy a CUDA module -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaModuleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaModuleNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the shader module.</param>
    /// <param name="module">module is the handle of the CUDA module to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCudaModuleNV /*module*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyCudaModuleNV = null;

    /// <summary>
    ///     vkDestroyCudaFunctionNV - Destroy a CUDA function -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaFunctionNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaFunctionNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the Function.</param>
    /// <param name="function">function is the handle of the CUDA function to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkCudaFunctionNV /*function*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyCudaFunctionNV = null;

    /// <summary>
    ///     vkCmdCudaLaunchKernelNV - Dispatch compute work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCudaLaunchKernelNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCudaLaunchKernelNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pLaunchInfo">
    ///     pLaunchInfo is a pointer to a VkCudaLaunchInfoNV structure in which the grid (similar to
    ///     workgroup) dimension, function handle and related arguments are defined.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCudaLaunchInfoNV* /*pLaunchInfo*/,
        void> vkCmdCudaLaunchKernelNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateCudaModuleNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetCudaModuleCacheNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateCudaFunctionNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyCudaModuleNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyCudaFunctionNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCudaLaunchKernelNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult>* pvkCreateCudaModuleNV = &vkCreateCudaModuleNV)
        {
            *pvkCreateCudaModuleNV = (delegate*<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7543\u6164\u6f4d\u7564\u656c\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult>* pvkGetCudaModuleCacheNV = &vkGetCudaModuleCacheNV)
        {
            *pvkGetCudaModuleCacheNV = (delegate*<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult>)GetVkFunction(device, "\u6b76\u6547\u4374\u6475\u4d61\u646f\u6c75\u4365\u6361\u6568\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult>* pvkCreateCudaFunctionNV = &vkCreateCudaFunctionNV)
        {
            *pvkCreateCudaFunctionNV = (delegate*<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7543\u6164\u7546\u636e\u6974\u6e6f\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void>* pvkDestroyCudaModuleNV = &vkDestroyCudaModuleNV)
        {
            *pvkDestroyCudaModuleNV = (delegate*<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void>)GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u4379\u6475\u4d61\u646f\u6c75\u4e65\u0056");
        }

        fixed (delegate*<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void>* pvkDestroyCudaFunctionNV = &vkDestroyCudaFunctionNV)
        {
            *pvkDestroyCudaFunctionNV = (delegate*<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4379\u6475\u4661\u6e75\u7463\u6f69\u4e6e\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkCudaLaunchInfoNV*, void>* pvkCmdCudaLaunchKernelNV = &vkCmdCudaLaunchKernelNV)
        {
            *pvkCmdCudaLaunchKernelNV = (delegate*<VkCommandBuffer, VkCudaLaunchInfoNV*, void>)GetVkFunction(device, "\u6b76\u6d43\u4364\u6475\u4c61\u7561\u636e\u4b68\u7265\u656e\u4e6c\u0056");
        }
    }
}