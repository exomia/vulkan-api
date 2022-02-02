// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary> VkImageConstraintsInfoFlagBitsFUCHSIA - Bitmask specifying image constraints flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFlagBitsFUCHSIA.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageConstraintsInfoFlagBitsFUCHSIA.html</a> </summary>
[Flags]
public enum VkImageConstraintsInfoFlagBitsFUCHSIA : int {
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA = 0,
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA = 1,
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA = 2,
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA</summary>
    VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA = 3,
    /// <summary>VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA specifies that protected memory is optional for the buffer collection.</summary>
    VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA = 4
}
