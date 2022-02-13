#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_validation_cache - device extension (nr. 161) - author 'GOOGLE' [platform '' | contact 'Cort Stratton
///     @cdwfs']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_validation_cache.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_validation_cache.html</a>
/// </summary>
public static unsafe class VkExtValidationCache
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_VALIDATION_CACHE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_VALIDATION_CACHE_EXTENSION_NAME = "VK_EXT_validation_cache";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_VALIDATION_CACHE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_VALIDATION_CACHE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_VALIDATION_CACHE_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u565f\u4c41\u4449\u5441\u4f49\u5f4e\u4143\u4843\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateValidationCacheEXT - Creates a new validation cache -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateValidationCacheEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateValidationCacheEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the validation cache object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkValidationCacheCreateInfoEXTstructure containing the initial
    ///     parameters for the validation cache object.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pValidationCache">
    ///     pValidationCache is a pointer to a VkValidationCacheEXThandle in which the resulting
    ///     validation cache object is returned.
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
        VkValidationCacheCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkValidationCacheEXT* /*pValidationCache*/,
        VkResult> vkCreateValidationCacheEXT = null;

    /// <summary>
    ///     vkDestroyValidationCacheEXT - Destroy a validation cache object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyValidationCacheEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyValidationCacheEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the validation cache object.</param>
    /// <param name="validationCache">validationCache is the handle of the validation cache to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkValidationCacheEXT /*validationCache*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyValidationCacheEXT = null;

    /// <summary>
    ///     vkMergeValidationCachesEXT - Combine the data stores of validation caches -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMergeValidationCachesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkMergeValidationCachesEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the validation cache objects.</param>
    /// <param name="dstCache">dstCache is the handle of the validation cache to merge results into.</param>
    /// <param name="srcCacheCount">srcCacheCount is the length of the pSrcCaches array.</param>
    /// <param name="pSrcCaches">
    ///     pSrcCaches is a pointer to an array of validation cache handles, which will be merged into
    ///     dstCache. The previous contents of dstCache are included after the merge.
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
        VkValidationCacheEXT /*dstCache*/,
        uint /*srcCacheCount*/,
        VkValidationCacheEXT* /*pSrcCaches*/,
        VkResult> vkMergeValidationCachesEXT = null;

    /// <summary>
    ///     vkGetValidationCacheDataEXT - Get the data store from a validation cache -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetValidationCacheDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetValidationCacheDataEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the validation cache.</param>
    /// <param name="validationCache">validationCache is the validation cache to retrieve data from.</param>
    /// <param name="pDataSize">
    ///     pDataSize is a pointer to a value related to the amount of data in the validation cache, as
    ///     described below.
    /// </param>
    /// <param name="pData">pData is either NULL or a pointer to a buffer.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkValidationCacheEXT /*validationCache*/,
        nuint* /*pDataSize*/,
        void* /*pData*/,
        VkResult> vkGetValidationCacheDataEXT = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult>* pvkCreateValidationCacheEXT = &vkCreateValidationCacheEXT)
        {
            *pvkCreateValidationCacheEXT = (delegate*<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6156\u696c\u6164\u6974\u6e6f\u6143\u6863\u4565\u5458\u0000");
        }
        fixed (delegate*<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>* pvkDestroyValidationCacheEXT = &vkDestroyValidationCacheEXT)
        {
            *pvkDestroyValidationCacheEXT = (delegate*<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u5679\u6c61\u6469\u7461\u6f69\u436e\u6361\u6568\u5845\u0054");
        }
        fixed (delegate*<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult>* pvkMergeValidationCachesEXT = &vkMergeValidationCachesEXT)
        {
            *pvkMergeValidationCachesEXT = (delegate*<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u654d\u6772\u5665\u6c61\u6469\u7461\u6f69\u436e\u6361\u6568\u4573\u5458\u0000");
        }
        fixed (delegate*<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult>* pvkGetValidationCacheDataEXT = &vkGetValidationCacheDataEXT)
        {
            *pvkGetValidationCacheDataEXT = (delegate*<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5674\u6c61\u6469\u7461\u6f69\u436e\u6361\u6568\u6144\u6174\u5845\u0054");
        }
    }
}