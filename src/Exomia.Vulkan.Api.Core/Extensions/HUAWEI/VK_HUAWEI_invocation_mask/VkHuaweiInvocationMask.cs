#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkHuaweiInvocationMask;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_HUAWEI_invocation_mask - device extension (nr. 371) - author 'Huawei' [platform '' | contact 'Pan Gao
///     @PanGao-h']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_invocation_mask.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_invocation_mask.html</a>
/// </summary>
[VkRequires("VK_KHR_ray_tracing_pipeline,VK_KHR_synchronization2")]
public static unsafe class VkHuaweiInvocationMask
{
    /// <summary> The spec version. </summary>
    public const uint VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME = "VK_HUAWEI_invocation_mask";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u485f\u4155\u4557\u5f49\u4e49\u4f56\u4143\u4954\u4e4f\u4d5f\u5341\u5f4b\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdBindInvocationMaskHUAWEI - Bind an invocation mask image on a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindInvocationMaskHUAWEI.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindInvocationMaskHUAWEI.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded</param>
    /// <param name="imageView">
    ///     imageView is an image view handle specifying the invocation mask image imageView may be set to
    ///     VK_NULL_HANDLE, which is equivalent to specifying a view of an image filled with ones value.
    /// </param>
    /// <param name="imageLayout">
    ///     imageLayout is the layout that the image subresources accessible from imageView will be in
    ///     when the invocation mask image is accessed
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkImageView /*imageView*/,
        VkImageLayout /*imageLayout*/,
        void> vkCmdBindInvocationMaskHUAWEI = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBindInvocationMaskHUAWEI</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkImageView, VkImageLayout, void>* pvkCmdBindInvocationMaskHUAWEI = &vkCmdBindInvocationMaskHUAWEI)
        {
            *pvkCmdBindInvocationMaskHUAWEI = (delegate*<VkCommandBuffer, VkImageView, VkImageLayout, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4964\u766e\u636f\u7461\u6f69\u4d6e\u7361\u486b\u4155\u4557\u0049");
        }
    }
}