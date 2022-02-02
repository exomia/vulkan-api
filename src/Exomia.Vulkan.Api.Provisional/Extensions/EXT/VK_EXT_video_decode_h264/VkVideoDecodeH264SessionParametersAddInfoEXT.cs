// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264SessionParametersAddInfoEXT - Structure specifies H.264 decoder parameter set information - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionParametersAddInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionParametersAddInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionParametersUpdateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionParametersUpdateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersAddInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>spsStdCount is the number of SPS elements in pSpsStd. Its value must be less than or equal to the value of maxSpsStdCount.</summary>
    public uint spsStdCount;
    /// <summary>pSpsStd is a pointer to an array of StdVideoH264SequenceParameterSet structures representing H.264 sequence parameter sets. Each element of the array must have a unique H.264 SPS ID.</summary>
    public StdVideoH264SequenceParameterSet* pSpsStd;
    /// <summary>ppsStdCount is the number of PPS provided in pPpsStd. Its value must be less than or equal to the value of maxPpsStdCount.</summary>
    public uint ppsStdCount;
    /// <summary>pPpsStd is a pointer to an array of StdVideoH264PictureParameterSet structures representing H.264 picture parameter sets. Each element of the array must have a unique H.264 SPS-PPS ID pair.</summary>
    public StdVideoH264PictureParameterSet* pPpsStd;
}
