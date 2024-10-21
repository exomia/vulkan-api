#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSynchronization2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_synchronization2 - device extension (nr. 315) - author 'KHR' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_synchronization2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_synchronization2.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_synchronization2.html#_deprecation_state")]
public static unsafe class VkKhrSynchronization2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME = "VK_KHR_synchronization2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u535f\u4e59\u4843\u4f52\u494e\u415a\u4954\u4e4f\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkCmdSetEvent2KHR alias for vkCmdSetEvent2
    /// <summary>
    ///     vkCmdSetEvent2 - Set an event object to signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkEvent /*event*/,
        VkDependencyInfo* /*pDependencyInfo*/,
        void> vkCmdSetEvent2KHR = null;

    /// vkCmdResetEvent2KHR alias for vkCmdResetEvent2
    /// <summary>
    ///     vkCmdResetEvent2 - Reset an event object to non-signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkEvent /*event*/,
        VkPipelineStageFlags2 /*stageMask*/,
        void> vkCmdResetEvent2KHR = null;

    /// vkCmdWaitEvents2KHR alias for vkCmdWaitEvents2
    /// <summary>
    ///     vkCmdWaitEvents2 - Wait for one or more events -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*eventCount*/,
        VkEvent* /*pEvents*/,
        VkDependencyInfo* /*pDependencyInfos*/,
        void> vkCmdWaitEvents2KHR = null;

    /// vkCmdPipelineBarrier2KHR alias for vkCmdPipelineBarrier2
    /// <summary>
    ///     vkCmdPipelineBarrier2 - Insert a memory dependency -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDependencyInfo* /*pDependencyInfo*/,
        void> vkCmdPipelineBarrier2KHR = null;

    /// vkCmdWriteTimestamp2KHR alias for vkCmdWriteTimestamp2
    /// <summary>
    ///     vkCmdWriteTimestamp2 - Write a device timestamp into a query object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineStageFlags2 /*stage*/,
        VkQueryPool /*queryPool*/,
        uint /*query*/,
        void> vkCmdWriteTimestamp2KHR = null;

    /// vkQueueSubmit2KHR alias for vkQueueSubmit2
    /// <summary>
    ///     vkQueueSubmit2 - Submits command buffers to a queue -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2KHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkQueue /*queue*/,
        uint /*submitCount*/,
        VkSubmitInfo2* /*pSubmits*/,
        VkFence /*fence*/,
        VkResult> vkQueueSubmit2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetEvent2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdResetEvent2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdWaitEvents2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPipelineBarrier2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdWriteTimestamp2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkQueueSubmit2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>* pvkCmdSetEvent2KHR = &vkCmdSetEvent2KHR)
        {
            *pvkCmdSetEvent2KHR = (delegate*<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u7645\u6e65\u3274\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void>* pvkCmdResetEvent2KHR = &vkCmdResetEvent2KHR)
        {
            *pvkCmdResetEvent2KHR = (delegate*<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void>)GetVkFunction(device, "\u6b76\u6d43\u5264\u7365\u7465\u7645\u6e65\u3274\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>* pvkCmdWaitEvents2KHR = &vkCmdWaitEvents2KHR)
        {
            *pvkCmdWaitEvents2KHR = (delegate*<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>)GetVkFunction(device, "\u6b76\u6d43\u5764\u6961\u4574\u6576\u746e\u3273\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkDependencyInfo*, void>* pvkCmdPipelineBarrier2KHR = &vkCmdPipelineBarrier2KHR)
        {
            *pvkCmdPipelineBarrier2KHR = (delegate*<VkCommandBuffer, VkDependencyInfo*, void>)GetVkFunction(device, "\u6b76\u6d43\u5064\u7069\u6c65\u6e69\u4265\u7261\u6972\u7265\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void>* pvkCmdWriteTimestamp2KHR = &vkCmdWriteTimestamp2KHR)
        {
            *pvkCmdWriteTimestamp2KHR = (delegate*<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5764\u6972\u6574\u6954\u656d\u7473\u6d61\u3270\u484b\u0052");
        }

        fixed (delegate*<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>* pvkQueueSubmit2KHR = &vkQueueSubmit2KHR)
        {
            *pvkQueueSubmit2KHR = (delegate*<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)GetVkFunction(device, "\u6b76\u7551\u7565\u5365\u6275\u696d\u3274\u484b\u0052");
        }
    }
}