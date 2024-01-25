#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDeviceDiagnosticCheckpoints;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_device_diagnostic_checkpoints - device extension (nr. 207) - author 'NVIDIA' [platform '' | contact 'Nuno
///     Subtil @nsubtil']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_diagnostic_checkpoints.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_diagnostic_checkpoints.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
public static unsafe class VkNvDeviceDiagnosticCheckpoints
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME = "VK_NV_device_diagnostic_checkpoints";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4956\u4543\u445f\u4149\u4e47\u534f\u4954\u5f43\u4843\u4345\u504b\u494f\u544e\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetCheckpointNV - Insert diagnostic checkpoint in command stream -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCheckpointNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCheckpointNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that will receive the marker</param>
    /// <param name="pCheckpointMarker">
    ///     pCheckpointMarker is an opaque application-provided value that will be associated with
    ///     the checkpoint.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void* /*pCheckpointMarker*/,
        void> vkCmdSetCheckpointNV = null;

    /// <summary>
    ///     vkGetQueueCheckpointDataNV - Retrieve diagnostic checkpoint data -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointDataNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointDataNV.html</a>
    /// </summary>
    /// <param name="queue">queue is the VkQueue object the caller would like to retrieve checkpoint data for</param>
    /// <param name="pCheckpointDataCount">
    ///     pCheckpointDataCount is a pointer to an integer related to the number of checkpoint
    ///     markers available or queried, as described below.
    /// </param>
    /// <param name="pCheckpointData">pCheckpointData is either NULL or a pointer to an array of VkCheckpointDataNV structures.</param>
    public static readonly delegate*<
        VkQueue /*queue*/,
        uint* /*pCheckpointDataCount*/,
        VkCheckpointDataNV* /*pCheckpointData*/,
        void> vkGetQueueCheckpointDataNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetCheckpointNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetQueueCheckpointDataNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, void*, void>* pvkCmdSetCheckpointNV = &vkCmdSetCheckpointNV)
        {
            *pvkCmdSetCheckpointNV = (delegate*<VkCommandBuffer, void*, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6843\u6365\u706b\u696f\u746e\u564e\u0000");
        }

        fixed (delegate*<VkQueue, uint*, VkCheckpointDataNV*, void>* pvkGetQueueCheckpointDataNV = &vkGetQueueCheckpointDataNV)
        {
            *pvkGetQueueCheckpointDataNV = (delegate*<VkQueue, uint*, VkCheckpointDataNV*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5174\u6575\u6575\u6843\u6365\u706b\u696f\u746e\u6144\u6174\u564e\u0000");
        }
    }
}