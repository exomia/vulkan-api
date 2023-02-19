#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtShaderModuleIdentifier;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_shader_module_identifier - device extension (nr. 463) - author 'EXT' [platform '' | contact 'Hans-Kristian
///     Arntzen @HansKristian-Work']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_module_identifier.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_module_identifier.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2+VK_EXT_pipeline_creation_cache_control")]
public static unsafe class VkExtShaderModuleIdentifier
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SHADER_MODULE_IDENTIFIER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME = "VK_EXT_shader_module_identifier";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u535f\u4148\u4544\u5f52\u4f4d\u5544\u454c\u495f\u4544\u544e\u4649\u4549\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT - Maximum length of a shader module identifier -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT.html
    ///     </a>
    /// </summary>
    public const uint VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT = 32;

    /// <summary>
    ///     vkGetShaderModuleIdentifierEXT - Query a unique identifier for a shader module -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleIdentifierEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleIdentifierEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that created the shader module.</param>
    /// <param name="shaderModule">shaderModule is the handle of the shader module.</param>
    /// <param name="pIdentifier">pIdentifier is a pointer to the returned VkShaderModuleIdentifierEXT.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkShaderModule /*shaderModule*/,
        VkShaderModuleIdentifierEXT* /*pIdentifier*/,
        void> vkGetShaderModuleIdentifierEXT = null;

    /// <summary>
    ///     vkGetShaderModuleCreateInfoIdentifierEXT - Query a unique identifier for a shader module create info -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleCreateInfoIdentifierEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleCreateInfoIdentifierEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that can create a VkShaderModule from pCreateInfo.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkShaderModuleCreateInfostructure.</param>
    /// <param name="pIdentifier">pIdentifier is a pointer to the returned VkShaderModuleIdentifierEXT.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkShaderModuleCreateInfo* /*pCreateInfo*/,
        VkShaderModuleIdentifierEXT* /*pIdentifier*/,
        void> vkGetShaderModuleCreateInfoIdentifierEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetShaderModuleIdentifierEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetShaderModuleCreateInfoIdentifierEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>* pvkGetShaderModuleIdentifierEXT = &vkGetShaderModuleIdentifierEXT)
        {
            *pvkGetShaderModuleIdentifierEXT = (delegate*<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6168\u6564\u4d72\u646f\u6c75\u4965\u6564\u746e\u6669\u6569\u4572\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>* pvkGetShaderModuleCreateInfoIdentifierEXT = &vkGetShaderModuleCreateInfoIdentifierEXT)
        {
            *pvkGetShaderModuleCreateInfoIdentifierEXT = (delegate*<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6168\u6564\u4d72\u646f\u6c75\u4365\u6572\u7461\u4965\u666e\u496f\u6564\u746e\u6669\u6569\u4572\u5458\u0000");
        }
    }
}