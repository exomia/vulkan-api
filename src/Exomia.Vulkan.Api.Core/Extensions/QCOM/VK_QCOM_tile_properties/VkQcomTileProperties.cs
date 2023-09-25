#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkQcomTileProperties;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_QCOM_tile_properties - device extension (nr. 485) - author 'QCOM' [platform '' | contact 'Jeff Leger
///     @jackohound']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_tile_properties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_tile_properties.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
public static unsafe class VkQcomTileProperties
{
    /// <summary> The spec version. </summary>
    public const uint VK_QCOM_TILE_PROPERTIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME = "VK_QCOM_tile_properties";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME_UTF8_NT = "\u4b56\u515f\u4f43\u5f4d\u4954\u454c\u505f\u4f52\u4550\u5452\u4549\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetFramebufferTilePropertiesQCOM - Get tile properties from the attachments in framebuffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFramebufferTilePropertiesQCOM.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetFramebufferTilePropertiesQCOM.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is a logical device associated with the framebuffer.</param>
    /// <param name="framebuffer">framebuffer is a handle of the framebuffer to query.</param>
    /// <param name="pPropertiesCount">
    ///     pPropertiesCount is a pointer to an integer related to the number of tile properties
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkTilePropertiesQCOM structures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkFramebuffer /*framebuffer*/,
        uint* /*pPropertiesCount*/,
        VkTilePropertiesQCOM* /*pProperties*/,
        VkResult> vkGetFramebufferTilePropertiesQCOM = null;

    /// <summary>
    ///     vkGetDynamicRenderingTilePropertiesQCOM - Get the properties when using dynamic rendering -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDynamicRenderingTilePropertiesQCOM.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDynamicRenderingTilePropertiesQCOM.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is a logical device associated with the render pass.</param>
    /// <param name="pRenderingInfo">
    ///     pRenderingInfo is a pointer to the VkRenderingInfo structure specifying details of the
    ///     render pass instance in dynamic rendering.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is a pointer to a VkTilePropertiesQCOM structure in which the properties are
    ///     returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkRenderingInfo* /*pRenderingInfo*/,
        VkTilePropertiesQCOM* /*pProperties*/,
        VkResult> vkGetDynamicRenderingTilePropertiesQCOM = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetFramebufferTilePropertiesQCOM</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDynamicRenderingTilePropertiesQCOM</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult>* pvkGetFramebufferTilePropertiesQCOM = &vkGetFramebufferTilePropertiesQCOM)
        {
            *pvkGetFramebufferTilePropertiesQCOM = (delegate*<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4674\u6172\u656d\u7562\u6666\u7265\u6954\u656c\u7250\u706f\u7265\u6974\u7365\u4351\u4d4f\u0000");
        }

        fixed (delegate*<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>* pvkGetDynamicRenderingTilePropertiesQCOM = &vkGetDynamicRenderingTilePropertiesQCOM)
        {
            *pvkGetDynamicRenderingTilePropertiesQCOM = (delegate*<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u6e79\u6d61\u6369\u6552\u646e\u7265\u6e69\u5467\u6c69\u5065\u6f72\u6570\u7472\u6569\u5173\u4f43\u004d");
        }
    }
}