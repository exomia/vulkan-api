#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDiscardRectangles;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_discard_rectangles - device extension (nr. 100) - author 'NV' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_discard_rectangles.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_discard_rectangles.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkExtDiscardRectangles
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME = "VK_EXT_discard_rectangles";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5349\u4143\u4452\u525f\u4345\u4154\u474e\u454c\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetDiscardRectangleEXT - Set discard rectangles dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstDiscardRectangle">
    ///     firstDiscardRectangle is the index of the first discard rectangle whose state is
    ///     updated by the command.
    /// </param>
    /// <param name="discardRectangleCount">
    ///     discardRectangleCount is the number of discard rectangles whose state are updated
    ///     by the command.
    /// </param>
    /// <param name="pDiscardRectangles">
    ///     pDiscardRectangles is a pointer to an array of VkRect2Dstructures specifying discard
    ///     rectangles.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstDiscardRectangle*/,
        uint /*discardRectangleCount*/,
        VkRect2D* /*pDiscardRectangles*/,
        void> vkCmdSetDiscardRectangleEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetDiscardRectangleEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>* pvkCmdSetDiscardRectangleEXT = &vkCmdSetDiscardRectangleEXT)
        {
            *pvkCmdSetDiscardRectangleEXT = (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6944\u6373\u7261\u5264\u6365\u6174\u676e\u656c\u5845\u0054");
        }
    }
}