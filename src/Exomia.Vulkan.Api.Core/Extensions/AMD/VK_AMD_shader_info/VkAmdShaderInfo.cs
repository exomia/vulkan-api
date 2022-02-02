#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdShaderInfo;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_shader_info - device extension (nr. 43) - author 'AMD' [platform '' | contact 'Jaakko Konttinen @jaakkoamd']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_shader_info.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_shader_info.html</a>
/// </summary>
/// <remarks>
///     specialuse: devtools
/// </remarks>
[VkSpecialuse("devtools")]
public static unsafe class VkAmdShaderInfo
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_SHADER_INFO_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_SHADER_INFO_EXTENSION_NAME = "VK_AMD_shader_info";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_SHADER_INFO_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_SHADER_INFO_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_SHADER_INFO_EXTENSION_NAME_UTF8_NT = "\u4b56\u415f\u444d\u535f\u4148\u4544\u5f52\u4e49\u4f46\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetShaderInfoAMD - Get information about a shader in a pipeline -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderInfoAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderInfoAMD.html</a>
    /// </summary>
    /// <param name="device">device is the device that created pipeline.</param>
    /// <param name="pipeline">pipeline is the target of the query.</param>
    /// <param name="shaderStage">
    ///     shaderStage is a VkShaderStageFlagBits specifying the particular shader within the pipeline
    ///     about which information is being queried.
    /// </param>
    /// <param name="infoType">infoType describes what kind of information is being queried.</param>
    /// <param name="pInfoSize">
    ///     pInfoSize is a pointer to a value related to the amount of data the query returns, as described
    ///     below.
    /// </param>
    /// <param name="pInfo">pInfo is either NULL or a pointer to a buffer.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_FEATURE_NOT_PRESENT,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*pipeline*/,
        VkShaderStageFlagBits /*shaderStage*/,
        VkShaderInfoTypeAMD /*infoType*/,
        nuint* /*pInfoSize*/,
        void* /*pInfo*/,
        VkResult> vkGetShaderInfoAMD = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult>* pvkGetShaderInfoAMD = &vkGetShaderInfoAMD)
        {
            *pvkGetShaderInfoAMD =
                (delegate*<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult>)GetVkFunction(
                    device, "\u6b76\u6547\u5374\u6168\u6564\u4972\u666e\u416f\u444d\u0000");
        }
    }
}