// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoCodingControlFlagBitsKHR - Video Coding Control Command Flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoCodingControlFlagBitsKHR : int {
    /// <summary>VK_VIDEO_CODING_CONTROL_DEFAULT_KHR indicates a request for the coding control paramaters to be applied to the current state of the bound video session.</summary>
    VK_VIDEO_CODING_CONTROL_DEFAULT_KHR = 0,
    /// <summary>VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR indicates a request for the bound video session device context to be reset before the coding control parameters are applied.</summary>
    VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR = 0
}
