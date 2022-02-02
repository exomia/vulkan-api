// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoCapabilityFlagBitsKHR - Video Decode and Encode Capability Flags - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilityFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoCapabilityFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoCapabilityFlagBitsKHR : int {
    /// <summary>VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR - the decode or encode session supports protected content.</summary>
    VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = 0,
    /// <summary>VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR - the DPB or Reconstructed Video Picture Resources for the video session may be created as a separate <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImage.html">VkImage</a> for each DPB picture. If not supported, the DPB must be created as single multi-layered image where each layer represents one of the DPB Video Picture Resources.</summary>
    VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = 1
}
