#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtCalibratedTimestamps;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_calibrated_timestamps - device extension (nr. 185) - author 'EXT' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_calibrated_timestamps.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_calibrated_timestamps.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
public static unsafe class VkExtCalibratedTimestamps
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME = "VK_EXT_calibrated_timestamps";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u435f\u4c41\u4249\u4152\u4554\u5f44\u4954\u454d\u5453\u4d41\u5350\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceCalibrateableTimeDomainsEXT - Query calibrateable time domains -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsEXT.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device from which to query the set of calibrateable time
    ///     domains.
    /// </param>
    /// <param name="pTimeDomainCount">
    ///     pTimeDomainCount is a pointer to an integer related to the number of calibrateable time
    ///     domains available or queried, as described below.
    /// </param>
    /// <param name="pTimeDomains">
    ///     pTimeDomains is either NULL or a pointer to an array of VkTimeDomainEXT values, indicating
    ///     the supported calibrateable time domains.
    /// </param>
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
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pTimeDomainCount*/,
        VkTimeDomainEXT* /*pTimeDomains*/,
        VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT = null;

    /// <summary>
    ///     vkGetCalibratedTimestampsEXT - Query calibrated timestamps -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device used to perform the query.</param>
    /// <param name="timestampCount">timestampCount is the number of timestamps to query.</param>
    /// <param name="pTimestampInfos">
    ///     pTimestampInfos is a pointer to an array of timestampCountVkCalibratedTimestampInfoEXT
    ///     structures, describing the time domains the calibrated timestamps should be captured from.
    /// </param>
    /// <param name="pTimestamps">
    ///     pTimestamps is a pointer to an array of timestampCount64-bit unsigned integer values in which
    ///     the requested calibrated timestamp values are returned.
    /// </param>
    /// <param name="pMaxDeviation">
    ///     pMaxDeviation is a pointer to a 64-bit unsigned integer value in which the strictly
    ///     positive maximum deviation, in nanoseconds, of the calibrated timestamp values is returned.
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
        uint /*timestampCount*/,
        VkCalibratedTimestampInfoEXT* /*pTimestampInfos*/,
        ulong* /*pTimestamps*/,
        ulong* /*pMaxDeviation*/,
        VkResult> vkGetCalibratedTimestampsEXT = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceCalibrateableTimeDomainsEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult>* pvkGetPhysicalDeviceCalibrateableTimeDomainsEXT = &vkGetPhysicalDeviceCalibrateableTimeDomainsEXT)
        {
            *pvkGetPhysicalDeviceCalibrateableTimeDomainsEXT = (delegate*<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4365\u6c61\u6269\u6172\u6574\u6261\u656c\u6954\u656d\u6f44\u616d\u6e69\u4573\u5458\u0000");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetCalibratedTimestampsEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult>* pvkGetCalibratedTimestampsEXT = &vkGetCalibratedTimestampsEXT)
        {
            *pvkGetCalibratedTimestampsEXT = (delegate*<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4374\u6c61\u6269\u6172\u6574\u5464\u6d69\u7365\u6174\u706d\u4573\u5458\u0000");
        }
    }
}