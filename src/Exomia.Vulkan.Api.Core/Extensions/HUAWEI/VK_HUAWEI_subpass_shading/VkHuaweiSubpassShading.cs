#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkHuaweiSubpassShading;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_HUAWEI_subpass_shading - device extension (nr. 370) - author 'HUAWEI' [platform '' | contact 'Hueilong Wang
///     @wyvernathuawei']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_subpass_shading.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_subpass_shading.html</a>
/// </summary>
[VkRequires("VK_KHR_create_renderpass2,VK_KHR_synchronization2")]
public static unsafe class VkHuaweiSubpassShading
{
    /// <summary> The spec version. </summary>
    public const uint VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME = "VK_HUAWEI_subpass_shading";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u485f\u4155\u4557\u5f49\u5553\u5042\u5341\u5f53\u4853\u4441\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI - Query maximum supported subpass shading workgroup size for a give
    ///     render pass -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is a handle to a local device object that was used to create the given render pass.</param>
    /// <param name="renderpass">
    ///     renderPass is a handle to a render pass object describing the environment in which the
    ///     pipeline will be used. The pipeline must only be used with a render pass instance compatible with the one provided.
    ///     See Render Pass Compatibility for more information.
    /// </param>
    /// <param name="pMaxWorkgroupSize">pMaxWorkgroupSize is a pointer to a VkExtent2D structure.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkRenderPass /*renderpass*/,
        VkExtent2D* /*pMaxWorkgroupSize*/,
        VkResult> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = null;

    /// <summary>
    ///     vkCmdSubpassShadingHUAWEI - Dispatch compute work items -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSubpassShadingHUAWEI.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSubpassShadingHUAWEI.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void> vkCmdSubpassShadingHUAWEI = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkRenderPass, VkExtent2D*, VkResult>* pvkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = &vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI)
        {
            *pvkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = (delegate*<VkDevice, VkRenderPass, VkExtent2D*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u5365\u6275\u6170\u7373\u6853\u6461\u6e69\u4d67\u7861\u6f57\u6b72\u7267\u756f\u5370\u7a69\u4865\u4155\u4557\u0049");
        }
        fixed (delegate*<VkCommandBuffer, void>* pvkCmdSubpassShadingHUAWEI = &vkCmdSubpassShadingHUAWEI)
        {
            *pvkCmdSubpassShadingHUAWEI = (delegate*<VkCommandBuffer, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u6275\u6170\u7373\u6853\u6461\u6e69\u4867\u4155\u4557\u0049");
        }
    }
}