// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoChromaSubsamplingFlagBitsKHR - Video chroma subsampling - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html</a> </summary>
[Flags]
public enum VkVideoChromaSubsamplingFlagBitsKHR : int {
    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_BIT_KHR<br/><a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoChromaSubsamplingFlagBitsKHR">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoChromaSubsamplingFlagBitsKHR</a></summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_BIT_KHR = 0,
    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR - the format is monochrome.</summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = 0,
    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR - the format is 4:2:0 chroma subsampled. The two chroma components are each subsampled at a factor of 2 both horizontally and vertically.</summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = 1,
    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR - the format is 4:2:2 chroma subsampled. The two chroma components are sampled at half the sample rate of luma. The horizontal chroma resolution is halved.</summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = 2,
    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR - the format is 4:4:4 chroma sampled. Each of the three YCbCr components have the same sample rate, thus there is no chroma subsampling.</summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = 3
}
