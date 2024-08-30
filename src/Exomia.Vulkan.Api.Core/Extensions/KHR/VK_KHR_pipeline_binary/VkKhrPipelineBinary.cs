#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrPipelineBinary;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_pipeline_binary - device extension (nr. 484) - author 'KHR' [platform '' | contact 'Stu Smith @stu-s']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_pipeline_binary.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_pipeline_binary.html</a>
/// </summary>
[VkDepends("VK_KHR_maintenance5")]
[VkDeviceExt]
public static unsafe class VkKhrPipelineBinary
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PIPELINE_BINARY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PIPELINE_BINARY_EXTENSION_NAME = "VK_KHR_pipeline_binary";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PIPELINE_BINARY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PIPELINE_BINARY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PIPELINE_BINARY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u505f\u5049\u4c45\u4e49\u5f45\u4942\u414e\u5952\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR - Maximum length of binary key -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR.html
    ///     </a>
    /// </summary>
    public const uint VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR = 32;

    /// <summary>
    ///     vkCreatePipelineBinariesKHR - Create pipeline binaries from a pipeline or previously retrieved data -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineBinariesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineBinariesKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the pipeline binary objects.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkPipelineBinaryCreateInfoKHRstructure that contains the data
    ///     to create the pipeline binaries from.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pBinaries">
    ///     pBinaries is a pointer to a VkPipelineBinaryHandlesInfoKHRstructure in which the resulting
    ///     pipeline binaries are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE,VK_PIPELINE_BINARY_MISSING_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineBinaryCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkPipelineBinaryHandlesInfoKHR* /*pBinaries*/,
        VkResult> vkCreatePipelineBinariesKHR = null;

    /// <summary>
    ///     vkDestroyPipelineBinaryKHR - Destroy a pipeline binary -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineBinaryKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineBinaryKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the pipeline binary object.</param>
    /// <param name="pipelineBinary">pipelineBinary is the handle of the pipeline binary object to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineBinaryKHR /*pipelineBinary*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyPipelineBinaryKHR = null;

    /// <summary>
    ///     vkGetPipelineKeyKHR - Generate the pipeline key from pipeline creation info -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineKeyKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineKeyKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the pipeline object.</param>
    /// <param name="pPipelineCreateInfo">pPipelineCreateInfo is NULL or a pointer to a VkPipelineCreateInfoKHR structure.</param>
    /// <param name="pPipelineKey">
    ///     pPipelineKey is a pointer to a VkPipelineBinaryKeyKHRstructure in which the resulting key is
    ///     returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineCreateInfoKHR* /*pPipelineCreateInfo*/,
        VkPipelineBinaryKeyKHR* /*pPipelineKey*/,
        VkResult> vkGetPipelineKeyKHR = null;

    /// <summary>
    ///     vkGetPipelineBinaryDataKHR - Get the data store from a pipeline binary -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineBinaryDataKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineBinaryDataKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the pipeline binary.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkPipelineBinaryDataInfoKHRstructure which describes the pipeline binary to
    ///     get data from.
    /// </param>
    /// <param name="pPipelineBinaryKey">
    ///     pPipelineBinaryKey is a pointer to a VkPipelineBinaryKeyKHRstructure where the key for
    ///     this binary will be written.
    /// </param>
    /// <param name="pPipelineBinaryDataSize">
    ///     pPipelineBinaryDataSize is a pointer to a size_t value related to the amount of
    ///     data in the pipeline binary, as described below.
    /// </param>
    /// <param name="pPipelineBinaryData">pPipelineBinaryData is either NULL or a pointer to a buffer.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_NOT_ENOUGH_SPACE_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineBinaryDataInfoKHR* /*pInfo*/,
        VkPipelineBinaryKeyKHR* /*pPipelineBinaryKey*/,
        nuint* /*pPipelineBinaryDataSize*/,
        void* /*pPipelineBinaryData*/,
        VkResult> vkGetPipelineBinaryDataKHR = null;

    /// <summary>
    ///     vkReleaseCapturedPipelineDataKHR - Release captured pipeline binary data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseCapturedPipelineDataKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseCapturedPipelineDataKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that created the pipeline object.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkReleaseCapturedPipelineDataInfoKHRstructure which describes the pipeline
    ///     to release the data from.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkReleaseCapturedPipelineDataInfoKHR* /*pInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkResult> vkReleaseCapturedPipelineDataKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreatePipelineBinariesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyPipelineBinaryKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPipelineKeyKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPipelineBinaryDataKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkReleaseCapturedPipelineDataKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult>* pvkCreatePipelineBinariesKHR = &vkCreatePipelineBinariesKHR)
        {
            *pvkCreatePipelineBinariesKHR = (delegate*<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6950\u6570\u696c\u656e\u6942\u616e\u6972\u7365\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void>* pvkDestroyPipelineBinaryKHR = &vkDestroyPipelineBinaryKHR)
        {
            *pvkDestroyPipelineBinaryKHR = (delegate*<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u5079\u7069\u6c65\u6e69\u4265\u6e69\u7261\u4b79\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult>* pvkGetPipelineKeyKHR = &vkGetPipelineKeyKHR)
        {
            *pvkGetPipelineKeyKHR =
                (delegate*<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult>)GetVkFunction(device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4b65\u7965\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult>* pvkGetPipelineBinaryDataKHR = &vkGetPipelineBinaryDataKHR)
        {
            *pvkGetPipelineBinaryDataKHR = (delegate*<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4265\u6e69\u7261\u4479\u7461\u4b61\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult>* pvkReleaseCapturedPipelineDataKHR = &vkReleaseCapturedPipelineDataKHR)
        {
            *pvkReleaseCapturedPipelineDataKHR = (delegate*<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult>)GetVkFunction(
                device, "\u6b76\u6552\u656c\u7361\u4365\u7061\u7574\u6572\u5064\u7069\u6c65\u6e69\u4465\u7461\u4b61\u5248\u0000");
        }
    }
}