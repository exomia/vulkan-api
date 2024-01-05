#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDeviceFault;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_device_fault - device extension (nr. 342) - author 'EXT' [platform '' | contact 'Ralph Potter
///     gitlab:@r_potter']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_fault.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_fault.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
public static unsafe class VkExtDeviceFault
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEVICE_FAULT_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEVICE_FAULT_EXTENSION_NAME = "VK_EXT_device_fault";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEVICE_FAULT_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEVICE_FAULT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEVICE_FAULT_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u5645\u4349\u5f45\u4146\u4c55\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetDeviceFaultInfoEXT - Reports diagnostic fault information on the specified logical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceFaultInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceFaultInfoEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device from which to query the diagnostic fault information.</param>
    /// <param name="pFaultCounts">
    ///     pFaultCounts is a pointer to a VkDeviceFaultCountsEXTstructure in which counts for
    ///     structures describing additional fault information are returned.
    /// </param>
    /// <param name="pFaultInfo">
    ///     pFaultInfo is NULL or a pointer to a VkDeviceFaultInfoEXTstructure in which fault information
    ///     is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceFaultCountsEXT* /*pFaultCounts*/,
        VkDeviceFaultInfoEXT* /*pFaultInfo*/,
        VkResult> vkGetDeviceFaultInfoEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetDeviceFaultInfoEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>* pvkGetDeviceFaultInfoEXT = &vkGetDeviceFaultInfoEXT)
        {
            *pvkGetDeviceFaultInfoEXT = (delegate*<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4665\u7561\u746c\u6e49\u6f66\u5845\u0054");
        }
    }
}