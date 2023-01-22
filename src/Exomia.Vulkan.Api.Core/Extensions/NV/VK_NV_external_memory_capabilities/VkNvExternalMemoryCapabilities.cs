#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvExternalMemoryCapabilities;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_external_memory_capabilities - instance extension (nr. 56) - author 'NV' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_capabilities.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_capabilities.html
///     </a>
/// </summary>
[Obsolete(
    "deprecated by VK_KHR_external_memory_capabilities", false,
    UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_external_memory_capabilities.html#_deprecation_state")]
public static unsafe class VkNvExternalMemoryCapabilities
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = "VK_NV_external_memory_capabilities";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u5845\u4554\u4e52\u4c41\u4d5f\u4d45\u524f\u5f59\u4143\u4150\u4942\u494c\u4954\u5345\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceExternalImageFormatPropertiesNV - Determine image capabilities compatible with external memory
    ///     handle types -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalImageFormatPropertiesNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalImageFormatPropertiesNV.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the image capabilities</param>
    /// <param name="format">format is the image format, corresponding to VkImageCreateInfo::format.</param>
    /// <param name="type">type is the image type, corresponding to VkImageCreateInfo::imageType.</param>
    /// <param name="tiling">tiling is the image tiling, corresponding to VkImageCreateInfo::tiling.</param>
    /// <param name="usage">usage is the intended usage of the image, corresponding to VkImageCreateInfo::usage.</param>
    /// <param name="flags">
    ///     flags is a bitmask describing additional parameters of the image, corresponding to
    ///     VkImageCreateInfo::flags.
    /// </param>
    /// <param name="externalHandleType">
    ///     externalHandleType is either one of the bits from
    ///     VkExternalMemoryHandleTypeFlagBitsNV, or 0.
    /// </param>
    /// <param name="pExternalImageFormatProperties">
    ///     pExternalImageFormatProperties is a pointer to a
    ///     VkExternalImageFormatPropertiesNV structure in which capabilities are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_FORMAT_NOT_SUPPORTED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkFormat /*format*/,
        VkImageType /*type*/,
        VkImageTiling /*tiling*/,
        VkImageUsageFlags /*usage*/,
        VkImageCreateFlags /*flags*/,
        VkExternalMemoryHandleTypeFlagsNV /*externalHandleType*/,
        VkExternalImageFormatPropertiesNV* /*pExternalImageFormatProperties*/,
        VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceExternalImageFormatPropertiesNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*, VkResult>
            * pvkGetPhysicalDeviceExternalImageFormatPropertiesNV = &vkGetPhysicalDeviceExternalImageFormatPropertiesNV)
        {
            *pvkGetPhysicalDeviceExternalImageFormatPropertiesNV =
                (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*,
                    VkResult>)GetVkFunction(
                    instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4565\u7478\u7265\u616e\u496c\u616d\u6567\u6f46\u6d72\u7461\u7250\u706f\u7265\u6974\u7365\u564e\u0000");
        }
    }
}