#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrExternalSemaphoreCapabilities;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_external_semaphore_capabilities - instance extension (nr. 77) - author 'KHR' [platform '' | contact 'James
///     Jones @cubanismo']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_capabilities.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_capabilities.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkInstanceExt]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_external_semaphore_capabilities.html#_deprecation_state")]
public static unsafe class VkKhrExternalSemaphoreCapabilities
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME = "VK_KHR_external_semaphore_capabilities";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u455f\u5458\u5245\u414e\u5f4c\u4553\u414d\u4850\u524f\u5f45\u4143\u4150\u4942\u494c\u4954\u5345\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_LUID_SIZE - Length of a locally unique device identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html</a>
    /// </summary>
    /// <remarks> VK_LUID_SIZE_KHR alias for VK_LUID_SIZE_KHR. </remarks>
    public const uint VK_LUID_SIZE_KHR = VK_LUID_SIZE;

    /// vkGetPhysicalDeviceExternalSemaphorePropertiesKHR alias for vkGetPhysicalDeviceExternalSemaphoreProperties
    /// <summary>
    ///     vkGetPhysicalDeviceExternalSemaphoreProperties - Function for querying external semaphore handle capabilities. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphorePropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphorePropertiesKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceExternalSemaphoreInfo* /*pExternalSemaphoreInfo*/,
        VkExternalSemaphoreProperties* /*pExternalSemaphoreProperties*/,
        void> vkGetPhysicalDeviceExternalSemaphorePropertiesKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceExternalSemaphorePropertiesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>* pvkGetPhysicalDeviceExternalSemaphorePropertiesKHR =
            &vkGetPhysicalDeviceExternalSemaphorePropertiesKHR)
        {
            *pvkGetPhysicalDeviceExternalSemaphorePropertiesKHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4565\u7478\u7265\u616e\u536c\u6d65\u7061\u6f68\u6572\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }
    }
}