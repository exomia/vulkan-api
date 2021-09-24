#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete(
        "Deprecated by VK_KHR_buffer_device_address extension - Which in turn was promoted to Vulkan 1.2", false,
        UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_buffer_device_address.html#_deprecation_state")]
    [VkExtGenerator]
    public static unsafe partial class VkExtBufferDeviceAddress
    {
        public const int    VK_EXT_BUFFER_DEVICE_ADDRESS                = 1;
        public const int    VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION   = 2;
        public const string VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME = "VK_EXT_buffer_device_address";

        public static delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            VkDeviceAddress> vkGetBufferDeviceAddressEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}