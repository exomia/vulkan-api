#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrLineRasterization;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_line_rasterization - device extension (nr. 535) - author 'KHR' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_line_rasterization.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_line_rasterization.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
public static unsafe class VkKhrLineRasterization
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_LINE_RASTERIZATION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME = "VK_KHR_line_rasterization";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u4c5f\u4e49\u5f45\u4152\u5453\u5245\u5a49\u5441\u4f49\u5f4e\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetLineStippleKHR - Set line stipple dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="lineStippleFactor">lineStippleFactor is the repeat factor used in stippled line rasterization.</param>
    /// <param name="lineStipplePattern">lineStipplePattern is the bit pattern used in stippled line rasterization.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*lineStippleFactor*/,
        ushort /*lineStipplePattern*/,
        void> vkCmdSetLineStippleKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetLineStippleKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, ushort, void>* pvkCmdSetLineStippleKHR = &vkCmdSetLineStippleKHR)
        {
            *pvkCmdSetLineStippleKHR = (delegate*<VkCommandBuffer, uint, ushort, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u694c\u656e\u7453\u7069\u6c70\u4b65\u5248\u0000");
        }
    }
}