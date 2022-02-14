#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrGetPhysicalDeviceProperties2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_get_physical_device_properties2 - instance extension (nr. 60) - author 'KHR' [platform '' | contact 'Jeff
///     Bolz @jeffbolznv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_physical_device_properties2.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_physical_device_properties2.html
///     </a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_physical_device_properties2.html#_deprecation_state")]
public static unsafe class VkKhrGetPhysicalDeviceProperties2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME = "VK_KHR_get_physical_device_properties2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u475f\u5445\u505f\u5948\u4953\u4143\u5f4c\u4544\u4956\u4543\u505f\u4f52\u4550\u5452\u4549\u5f53\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkGetPhysicalDeviceFeatures2KHR alias for vkGetPhysicalDeviceFeatures2
    /// <summary>
    ///     vkGetPhysicalDeviceFeatures2 - Reports capabilities of a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceFeatures2* /*pFeatures*/,
        void> vkGetPhysicalDeviceFeatures2KHR = null;

    /// vkGetPhysicalDeviceProperties2KHR alias for vkGetPhysicalDeviceProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceProperties2 - Returns properties of a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceProperties2* /*pProperties*/,
        void> vkGetPhysicalDeviceProperties2KHR = null;

    /// vkGetPhysicalDeviceFormatProperties2KHR alias for vkGetPhysicalDeviceFormatProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceFormatProperties2 - Lists physical device's format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkFormat /*format*/,
        VkFormatProperties2* /*pFormatProperties*/,
        void> vkGetPhysicalDeviceFormatProperties2KHR = null;

    /// vkGetPhysicalDeviceImageFormatProperties2KHR alias for vkGetPhysicalDeviceImageFormatProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceImageFormatProperties2 - Lists physical device's image format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceImageFormatInfo2* /*pImageFormatInfo*/,
        VkImageFormatProperties2* /*pImageFormatProperties*/,
        VkResult> vkGetPhysicalDeviceImageFormatProperties2KHR = null;

    /// vkGetPhysicalDeviceQueueFamilyProperties2KHR alias for vkGetPhysicalDeviceQueueFamilyProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceQueueFamilyProperties2 - Reports properties of the queues of the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pQueueFamilyPropertyCount*/,
        VkQueueFamilyProperties2* /*pQueueFamilyProperties*/,
        void> vkGetPhysicalDeviceQueueFamilyProperties2KHR = null;

    /// vkGetPhysicalDeviceMemoryProperties2KHR alias for vkGetPhysicalDeviceMemoryProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceMemoryProperties2 - Reports memory information for the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceMemoryProperties2* /*pMemoryProperties*/,
        void> vkGetPhysicalDeviceMemoryProperties2KHR = null;

    /// vkGetPhysicalDeviceSparseImageFormatProperties2KHR alias for vkGetPhysicalDeviceSparseImageFormatProperties2
    /// <summary>
    ///     vkGetPhysicalDeviceSparseImageFormatProperties2 - Retrieve properties of an image format applied to sparse images -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2KHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceSparseImageFormatInfo2* /*pFormatInfo*/,
        uint* /*pPropertyCount*/,
        VkSparseImageFormatProperties2* /*pProperties*/,
        void> vkGetPhysicalDeviceSparseImageFormatProperties2KHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>* pvkGetPhysicalDeviceFeatures2KHR = &vkGetPhysicalDeviceFeatures2KHR)
        {
            *pvkGetPhysicalDeviceFeatures2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4665\u6165\u7574\u6572\u3273\u484b\u0052");
        }
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>* pvkGetPhysicalDeviceProperties2KHR = &vkGetPhysicalDeviceProperties2KHR)
        {
            *pvkGetPhysicalDeviceProperties2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5065\u6f72\u6570\u7472\u6569\u3273\u484b\u0052");
        }
        fixed (delegate*<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>* pvkGetPhysicalDeviceFormatProperties2KHR = &vkGetPhysicalDeviceFormatProperties2KHR)
        {
            *pvkGetPhysicalDeviceFormatProperties2KHR = (delegate*<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4665\u726f\u616d\u5074\u6f72\u6570\u7472\u6569\u3273\u484b\u0052");
        }
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>* pvkGetPhysicalDeviceImageFormatProperties2KHR =
                   &vkGetPhysicalDeviceImageFormatProperties2KHR)
        {
            *pvkGetPhysicalDeviceImageFormatProperties2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4965\u616d\u6567\u6f46\u6d72\u7461\u7250\u706f\u7265\u6974\u7365\u4b32\u5248\u0000");
        }
        fixed (delegate*<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>* pvkGetPhysicalDeviceQueueFamilyProperties2KHR = &vkGetPhysicalDeviceQueueFamilyProperties2KHR)
        {
            *pvkGetPhysicalDeviceQueueFamilyProperties2KHR = (delegate*<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5165\u6575\u6575\u6146\u696d\u796c\u7250\u706f\u7265\u6974\u7365\u4b32\u5248\u0000");
        }
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>* pvkGetPhysicalDeviceMemoryProperties2KHR = &vkGetPhysicalDeviceMemoryProperties2KHR)
        {
            *pvkGetPhysicalDeviceMemoryProperties2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4d65\u6d65\u726f\u5079\u6f72\u6570\u7472\u6569\u3273\u484b\u0052");
        }
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>* pvkGetPhysicalDeviceSparseImageFormatProperties2KHR =
                   &vkGetPhysicalDeviceSparseImageFormatProperties2KHR)
        {
            *pvkGetPhysicalDeviceSparseImageFormatProperties2KHR =
                (delegate*<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>)Core.Vk.GetVkFunction(
                    instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u6170\u7372\u4965\u616d\u6567\u6f46\u6d72\u7461\u7250\u706f\u7265\u6974\u7365\u4b32\u5248\u0000");
        }
    }
}