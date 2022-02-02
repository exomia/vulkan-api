// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoComponentBitDepthFlagBitsKHR - Video component bit depth - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoComponentBitDepthFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoComponentBitDepthFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoComponentBitDepthFlagBitsKHR : int {
    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR<br/><a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoComponentBitDepthFlagBitsKHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoComponentBitDepthFlagBitsKHR</a></summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = 0,
    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR - the format component bit depth is 8 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = 0,
    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR - the format component bit depth is 10 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = 2,
    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR - the format component bit depth is 12 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = 4
}
