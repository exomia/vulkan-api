// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoCodingQualityPresetFlagBitsKHR - Video codec profile types - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingQualityPresetFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingQualityPresetFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoCodingQualityPresetFlagBitsKHR : int {
    /// <summary>VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR defines normal decode case.</summary>
    VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR = 0,
    /// <summary>VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR defines power efficient case.</summary>
    VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR = 1,
    /// <summary>VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR defines quality focus case.</summary>
    VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR = 2
}
