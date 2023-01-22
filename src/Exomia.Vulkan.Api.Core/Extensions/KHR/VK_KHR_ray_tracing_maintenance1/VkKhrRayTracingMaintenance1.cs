#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrRayTracingMaintenance1;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_ray_tracing_maintenance1 - device extension (nr. 387) - author 'KHR' [platform '' | contact 'Daniel Koch
///     @dgkoch']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_maintenance1.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_maintenance1.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_acceleration_structure")]
public static unsafe class VkKhrRayTracingMaintenance1
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_RAY_TRACING_MAINTENANCE_1_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME = "VK_KHR_ray_tracing_maintenance1";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u525f\u5941\u545f\u4152\u4943\u474e\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u315f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdTraceRaysIndirect2KHR - Initialize an indirect ray tracing dispatch with indirect shader binding tables
    ///     -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirect2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirect2KHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="indirectDeviceAddress">
    ///     indirectDeviceAddress is a buffer device address which is a pointer to a
    ///     VkTraceRaysIndirectCommand2KHR structure containing the trace ray parameters.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*indirectDeviceAddress*/,
        void> vkCmdTraceRaysIndirect2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdTraceRaysIndirect2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, void>* pvkCmdTraceRaysIndirect2KHR = &vkCmdTraceRaysIndirect2KHR)
        {
            *pvkCmdTraceRaysIndirect2KHR = (delegate*<VkCommandBuffer, VkDeviceAddress, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5464\u6172\u6563\u6152\u7379\u6e49\u6964\u6572\u7463\u4b32\u5248\u0000");
        }
    }
}