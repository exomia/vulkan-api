#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrPerformanceQuery;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_performance_query - device extension (nr. 117) - author 'KHR' [platform '' | contact 'Alon Or-bach
///     @alonorbach']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_performance_query.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_performance_query.html</a>
/// </summary>
/// <remarks>
///     specialuse: devtools
/// </remarks>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[VkSpecialuse("devtools")]
public static unsafe class VkKhrPerformanceQuery
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME = "VK_KHR_performance_query";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u505f\u5245\u4f46\u4d52\u4e41\u4543\u515f\u4555\u5952\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR - Reports properties of the performance query
    ///     counters available on a queue family of a device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the handle to the physical device whose queue family performance query
    ///     counter properties will be queried.
    /// </param>
    /// <param name="queueFamilyIndex">
    ///     queueFamilyIndex is the index into the queue family of the physical device we want to
    ///     get properties for.
    /// </param>
    /// <param name="pCounterCount">
    ///     pCounterCount is a pointer to an integer related to the number of counters available or
    ///     queried, as described below.
    /// </param>
    /// <param name="pCounters">pCounters is either NULL or a pointer to an array of VkPerformanceCounterKHR structures.</param>
    /// <param name="pCounterDescriptions">
    ///     pCounterDescriptions is either NULL or a pointer to an array of
    ///     VkPerformanceCounterDescriptionKHR structures.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint /*queueFamilyIndex*/,
        uint* /*pCounterCount*/,
        VkPerformanceCounterKHR* /*pCounters*/,
        VkPerformanceCounterDescriptionKHR* /*pCounterDescriptions*/,
        VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR - Reports the number of passes require for a performance
    ///     query pool type -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the handle to the physical device whose queue family performance query
    ///     counter properties will be queried.
    /// </param>
    /// <param name="pPerformanceQueryCreateInfo">
    ///     pPerformanceQueryCreateInfo is a pointer to a
    ///     VkQueryPoolPerformanceCreateInfoKHR of the performance query that is to be created.
    /// </param>
    /// <param name="pNumPasses">
    ///     pNumPasses is a pointer to an integer related to the number of passes required to query the
    ///     performance query pool, as described below.
    /// </param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkQueryPoolPerformanceCreateInfoKHR* /*pPerformanceQueryCreateInfo*/,
        uint* /*pNumPasses*/,
        void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = null;

    /// <summary>
    ///     vkAcquireProfilingLockKHR - Acquires the profiling lock -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireProfilingLockKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireProfilingLockKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device to profile.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkAcquireProfilingLockInfoKHRstructure containing information about how the
    ///     profiling is to be acquired.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_TIMEOUT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAcquireProfilingLockInfoKHR* /*pInfo*/,
        VkResult> vkAcquireProfilingLockKHR = null;

    /// <summary>
    ///     vkReleaseProfilingLockKHR - Releases the profiling lock -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseProfilingLockKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseProfilingLockKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device to cease profiling on.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        void> vkReleaseProfilingLockKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult>* pvkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR =
                   &vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR)
        {
            *pvkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR =
                (delegate*<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult>)Core.Vk.GetVkFunction(
                    instance,
                    "\u6b76\u6e45\u6d75\u7265\u7461\u5065\u7968\u6973\u6163\u446c\u7665\u6369\u5165\u6575\u6575\u6146\u696d\u796c\u6550\u6672\u726f\u616d\u636e\u5165\u6575\u7972\u6f43\u6e75\u6574\u7372\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void>* pvkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR =
                   &vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR)
        {
            *pvkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = (delegate*<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5165\u6575\u6575\u6146\u696d\u796c\u6550\u6672\u726f\u616d\u636e\u5165\u6575\u7972\u6150\u7373\u7365\u484b\u0052");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkAcquireProfilingLockKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkReleaseProfilingLockKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>* pvkAcquireProfilingLockKHR = &vkAcquireProfilingLockKHR)
        {
            *pvkAcquireProfilingLockKHR = (delegate*<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u5065\u6f72\u6966\u696c\u676e\u6f4c\u6b63\u484b\u0052");
        }

        fixed (delegate*<VkDevice, void>* pvkReleaseProfilingLockKHR = &vkReleaseProfilingLockKHR)
        {
            *pvkReleaseProfilingLockKHR = (delegate*<VkDevice, void>)Core.Vk.GetVkFunction(device, "\u6b76\u6552\u656c\u7361\u5065\u6f72\u6966\u696c\u676e\u6f4c\u6b63\u484b\u0052");
        }
    }
}