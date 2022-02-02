// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoSessionCreateFlagBitsKHR - Video decode or encode video session creation flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoSessionCreateFlagBitsKHR : int {
    /// <summary>VK_VIDEO_SESSION_CREATE_DEFAULT_KHR<br/><a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoSessionCreateFlagBitsKHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoSessionCreateFlagBitsKHR</a></summary>
    VK_VIDEO_SESSION_CREATE_DEFAULT_KHR = 0,
    /// <summary>VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR - create the video session for use with protected video content</summary>
    VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR = 0
}
