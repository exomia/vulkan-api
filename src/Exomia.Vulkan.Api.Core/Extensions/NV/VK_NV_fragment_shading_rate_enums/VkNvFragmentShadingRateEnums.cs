﻿#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvFragmentShadingRateEnums;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_fragment_shading_rate_enums - device extension (nr. 327) - author 'NV' [platform '' | contact 'Pat Brown
///     @nvpbrown']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_fragment_shading_rate_enums.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_fragment_shading_rate_enums.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_fragment_shading_rate")]
public static unsafe class VkNvFragmentShadingRateEnums
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME = "VK_NV_fragment_shading_rate_enums";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u5246\u4741\u454d\u544e\u535f\u4148\u4944\u474e\u525f\u5441\u5f45\u4e45\u4d55\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetFragmentShadingRateEnumNV - Set pipeline fragment shading rate dynamically for a command buffer using
    ///     enums -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateEnumNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateEnumNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="shadingRate">
    ///     shadingRate specifies a VkFragmentShadingRateNV enum indicating the pipeline fragment shading
    ///     rate for subsequent drawing commands.
    /// </param>
    /// <param name="combinerOps">
    ///     combinerOps specifies a VkFragmentShadingRateCombinerOpKHRdetermining how the pipeline,
    ///     primitive, and attachment shading ratesare combined for fragments generated by subsequent drawing commands.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkFragmentShadingRateNV /*shadingRate*/,
        VkArray2<VkFragmentShadingRateCombinerOpKHR> /*combinerOps*/,
        void> vkCmdSetFragmentShadingRateEnumNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkFragmentShadingRateNV, VkArray2<VkFragmentShadingRateCombinerOpKHR>, void>* pvkCmdSetFragmentShadingRateEnumNV = &vkCmdSetFragmentShadingRateEnumNV)
        {
            *pvkCmdSetFragmentShadingRateEnumNV = (delegate*<VkCommandBuffer, VkFragmentShadingRateNV, VkArray2<VkFragmentShadingRateCombinerOpKHR>, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7246\u6761\u656d\u746e\u6853\u6461\u6e69\u5267\u7461\u4565\u756e\u4e6d\u0056");
        }
    }
}