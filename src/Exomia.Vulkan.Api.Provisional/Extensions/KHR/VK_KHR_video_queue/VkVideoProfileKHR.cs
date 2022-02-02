// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoProfileKHR - Structure specifying the codec video profile - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_PROFILE_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>videoCodecOperation is a VkVideoCodecOperationFlagBitsKHRvalue specifying a video codec operation.</summary>
    public VkVideoCodecOperationFlagBitsKHR videoCodecOperation;
    /// <summary>chromaSubsampling is a bitmask of VkVideoChromaSubsamplingFlagBitsKHR specifying video chroma subsampling information.</summary>
    public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
    /// <summary>lumaBitDepth is a bitmask of VkVideoComponentBitDepthFlagBitsKHR specifying video luma bit depth information.</summary>
    public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
    /// <summary>chromaBitDepth is a bitmask of VkVideoComponentBitDepthFlagBitsKHR specifying video chroma bit depth information.</summary>
    public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
}
