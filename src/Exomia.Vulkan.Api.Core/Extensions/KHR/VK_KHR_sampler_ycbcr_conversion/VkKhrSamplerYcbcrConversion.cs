#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSamplerYcbcrConversion;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_sampler_ycbcr_conversion - device extension (nr. 157) - author 'KHR' [platform '' | contact 'Andrew Garrard
///     @fluppeteer']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_sampler_ycbcr_conversion.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_sampler_ycbcr_conversion.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_maintenance1,VK_KHR_bind_memory2,VK_KHR_get_memory_requirements2,VK_KHR_get_physical_device_properties2")]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_sampler_ycbcr_conversion.html#_deprecation_state")]
public static unsafe class VkKhrSamplerYcbcrConversion
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = 14;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME = "VK_KHR_sampler_ycbcr_conversion";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4d41\u4c50\u5245\u595f\u4243\u5243\u435f\u4e4f\u4556\u5352\u4f49\u5f4e\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkCreateSamplerYcbcrConversionKHR alias for vkCreateSamplerYcbcrConversion
    /// <summary>
    ///     vkCreateSamplerYcbcrConversion - Create a new Y′CBCR conversion -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversionKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversionKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSamplerYcbcrConversionCreateInfo* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSamplerYcbcrConversion* /*pYcbcrConversion*/,
        VkResult> vkCreateSamplerYcbcrConversionKHR = null;

    /// vkDestroySamplerYcbcrConversionKHR alias for vkDestroySamplerYcbcrConversion
    /// <summary>
    ///     vkDestroySamplerYcbcrConversion - Destroy a created Y′CBCR conversion -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversionKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversionKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSamplerYcbcrConversion /*ycbcrConversion*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroySamplerYcbcrConversionKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateSamplerYcbcrConversionKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroySamplerYcbcrConversionKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>* pvkCreateSamplerYcbcrConversionKHR =
                   &vkCreateSamplerYcbcrConversionKHR)
        {
            *pvkCreateSamplerYcbcrConversionKHR = (delegate*<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6153\u706d\u656c\u5972\u6263\u7263\u6f43\u766e\u7265\u6973\u6e6f\u484b\u0052");
        }

        fixed (delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>* pvkDestroySamplerYcbcrConversionKHR = &vkDestroySamplerYcbcrConversionKHR)
        {
            *pvkDestroySamplerYcbcrConversionKHR = (delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u5379\u6d61\u6c70\u7265\u6359\u6362\u4372\u6e6f\u6576\u7372\u6f69\u4b6e\u5248\u0000");
        }
    }
}