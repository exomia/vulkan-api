#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDeferredHostOperations;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_deferred_host_operations - device extension (nr. 269) - author 'KHR' [platform '' | contact 'Josh Barczak
///     @jbarczak']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_deferred_host_operations.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_deferred_host_operations.html
///     </a>
/// </summary>
public static unsafe class VkKhrDeferredHostOperations
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 4;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME = "VK_KHR_deferred_host_operations";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u4645\u5245\u4552\u5f44\u4f48\u5453\u4f5f\u4550\u4152\u4954\u4e4f\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateDeferredOperationKHR - Create a deferred operation handle -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDeferredOperationKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDeferredOperationKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns operation.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pDeferredOperation">
    ///     pDeferredOperation is a pointer to a handle in which the created
    ///     VkDeferredOperationKHR is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkDeferredOperationKHR* /*pDeferredOperation*/,
        VkResult> vkCreateDeferredOperationKHR = null;

    /// <summary>
    ///     vkDestroyDeferredOperationKHR - Destroy a deferred operation handle -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDeferredOperationKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDeferredOperationKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns operation.</param>
    /// <param name="operation">operation is the completed operation to be destroyed.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*operation*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyDeferredOperationKHR = null;

    /// <summary>
    ///     vkGetDeferredOperationMaxConcurrencyKHR - Query the maximum concurrency on a deferred operation -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationMaxConcurrencyKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationMaxConcurrencyKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns operation.</param>
    /// <param name="operation">operation is the deferred operation to be queried.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*operation*/,
        uint> vkGetDeferredOperationMaxConcurrencyKHR = null;

    /// <summary>
    ///     vkGetDeferredOperationResultKHR - Query the result of a deferred operation -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationResultKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationResultKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns operation.</param>
    /// <param name="operation">operation is the operation whose deferred result is being queried.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_NOT_READY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*operation*/,
        VkResult> vkGetDeferredOperationResultKHR = null;

    /// <summary>
    ///     vkDeferredOperationJoinKHR - Assign a thread to a deferred operation -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDeferredOperationJoinKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDeferredOperationJoinKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device which owns operation.</param>
    /// <param name="operation">operation is the deferred operation that the calling thread should work on.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_THREAD_DONE_KHR,VK_THREAD_IDLE_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*operation*/,
        VkResult> vkDeferredOperationJoinKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>* pvkCreateDeferredOperationKHR = &vkCreateDeferredOperationKHR)
        {
            *pvkCreateDeferredOperationKHR = (delegate*<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7243\u6165\u6574\u6544\u6566\u7272\u6465\u704f\u7265\u7461\u6f69\u4b6e\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>* pvkDestroyDeferredOperationKHR = &vkDestroyDeferredOperationKHR)
        {
            *pvkDestroyDeferredOperationKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u7473\u6f72\u4479\u6665\u7265\u6572\u4f64\u6570\u6172\u6974\u6e6f\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, uint>* pvkGetDeferredOperationMaxConcurrencyKHR = &vkGetDeferredOperationMaxConcurrencyKHR)
        {
            *pvkGetDeferredOperationMaxConcurrencyKHR = (delegate*<VkDevice, VkDeferredOperationKHR, uint>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6547\u4474\u6665\u7265\u6572\u4f64\u6570\u6172\u6974\u6e6f\u614d\u4378\u6e6f\u7563\u7272\u6e65\u7963\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkResult>* pvkGetDeferredOperationResultKHR = &vkGetDeferredOperationResultKHR)
        {
            *pvkGetDeferredOperationResultKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6547\u4474\u6665\u7265\u6572\u4f64\u6570\u6172\u6974\u6e6f\u6552\u7573\u746c\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkResult>* pvkDeferredOperationJoinKHR = &vkDeferredOperationJoinKHR)
        {
            *pvkDeferredOperationJoinKHR = (delegate*<VkDevice, VkDeferredOperationKHR, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u6566\u7272\u6465\u704f\u7265\u7461\u6f69\u4a6e\u696f\u4b6e\u5248\u0000");
        }
    }
}