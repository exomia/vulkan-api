#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrTimelineSemaphore;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_timeline_semaphore - device extension (nr. 208) - author 'KHR' [platform '' | contact 'Faith Ekstrand
///     @gfxstrand']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_timeline_semaphore.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_timeline_semaphore.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_timeline_semaphore.html#_deprecation_state")]
public static unsafe class VkKhrTimelineSemaphore
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME = "VK_KHR_timeline_semaphore";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u545f\u4d49\u4c45\u4e49\u5f45\u4553\u414d\u4850\u524f\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkGetSemaphoreCounterValueKHR alias for vkGetSemaphoreCounterValue
    /// <summary>
    ///     vkGetSemaphoreCounterValue - Query the current state of a timeline semaphore -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValueKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValueKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSemaphore /*semaphore*/,
        ulong* /*pValue*/,
        VkResult> vkGetSemaphoreCounterValueKHR = null;

    /// vkWaitSemaphoresKHR alias for vkWaitSemaphores
    /// <summary>
    ///     vkWaitSemaphores - Wait for timeline semaphores on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphoresKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphoresKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSemaphoreWaitInfo* /*pWaitInfo*/,
        ulong /*timeout*/,
        VkResult> vkWaitSemaphoresKHR = null;

    /// vkSignalSemaphoreKHR alias for vkSignalSemaphore
    /// <summary>
    ///     vkSignalSemaphore - Signal a timeline semaphore on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphoreKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphoreKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSemaphoreSignalInfo* /*pSignalInfo*/,
        VkResult> vkSignalSemaphoreKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetSemaphoreCounterValueKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkWaitSemaphoresKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkSignalSemaphoreKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSemaphore, ulong*, VkResult>* pvkGetSemaphoreCounterValueKHR = &vkGetSemaphoreCounterValueKHR)
        {
            *pvkGetSemaphoreCounterValueKHR = (delegate*<VkDevice, VkSemaphore, ulong*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6d65\u7061\u6f68\u6572\u6f43\u6e75\u6574\u5672\u6c61\u6575\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>* pvkWaitSemaphoresKHR = &vkWaitSemaphoresKHR)
        {
            *pvkWaitSemaphoresKHR = (delegate*<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>)GetVkFunction(device, "\u6b76\u6157\u7469\u6553\u616d\u6870\u726f\u7365\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSemaphoreSignalInfo*, VkResult>* pvkSignalSemaphoreKHR = &vkSignalSemaphoreKHR)
        {
            *pvkSignalSemaphoreKHR = (delegate*<VkDevice, VkSemaphoreSignalInfo*, VkResult>)GetVkFunction(device, "\u6b76\u6953\u6e67\u6c61\u6553\u616d\u6870\u726f\u4b65\u5248\u0000");
        }
    }
}