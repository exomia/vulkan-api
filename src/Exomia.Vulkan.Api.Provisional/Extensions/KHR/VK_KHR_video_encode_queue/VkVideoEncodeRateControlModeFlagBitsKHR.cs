// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeRateControlModeFlagBitsKHR - Video encode rate control modes - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoEncodeRateControlModeFlagBitsKHR : int {
    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR for disabling rate control.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR = 0,
    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR for constant bitrate rate control mode.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = 1,
    /// <summary>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR for variable bitrate rate control mode.</summary>
    VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = 2
}
