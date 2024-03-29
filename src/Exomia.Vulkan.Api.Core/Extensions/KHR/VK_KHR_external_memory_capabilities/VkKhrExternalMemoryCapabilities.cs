#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalMemoryCapabilities;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_memory_capabilities - instance extension (nr. 72) - author 'KHR' [platform '' | contact 'James
///     Jones @cubanismo']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_capabilities.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_capabilities.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkInstanceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_memory_capabilities.html#_deprecation_state")]
public static unsafe class VkKhrExternalMemoryCapabilities
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME = "VK_KHR_external_memory_capabilities";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u435f\u5041\u4241\u4c49\u5449\u4549\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     VK_LUID_SIZE - Length of a locally unique device identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html</a>
    /// </summary>
    /// <remarks> VK_LUID_SIZE_KHR alias for VK_LUID_SIZE_KHR. </remarks>
    public const uint VK_LUID_SIZE_KHR = VK_LUID_SIZE;

    /// vkGetPhysicalDeviceExternalBufferPropertiesKHR alias for vkGetPhysicalDeviceExternalBufferProperties
    /// <summary>
    ///     vkGetPhysicalDeviceExternalBufferProperties - Query external handle types supported by buffers -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferPropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferPropertiesKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceExternalBufferInfo* /*pExternalBufferInfo*/,
        VkExternalBufferProperties* /*pExternalBufferProperties*/,
        void> vkGetPhysicalDeviceExternalBufferPropertiesKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceExternalBufferPropertiesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>* pvkGetPhysicalDeviceExternalBufferPropertiesKHR =
            &vkGetPhysicalDeviceExternalBufferPropertiesKHR)
        {
            *pvkGetPhysicalDeviceExternalBufferPropertiesKHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4565\u7478\u7265\u616e\u426c\u6675\u6566\u5072\u6f72\u6570\u7472\u6569\u4b73\u5248\u0000");
        }
    }
}