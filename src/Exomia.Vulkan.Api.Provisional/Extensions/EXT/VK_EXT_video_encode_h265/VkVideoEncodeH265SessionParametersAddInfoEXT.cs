// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265SessionParametersAddInfoEXT - Structure specifies H.265 encoder parameter set info - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersAddInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersAddInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionParametersUpdateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionParametersUpdateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionParametersAddInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>vpsStdCount is the number of VPS elements in pVpsStd.</summary>
    public uint vpsStdCount;
    /// <summary>pVpsStd is a pointer to an array of vpsStdCountStdVideoH265VideoParameterSet structures representing H.265 video parameter sets.</summary>
    public StdVideoH265VideoParameterSet* pVpsStd;
    /// <summary>spsStdCount is the number of SPS elements in pSpsStd.</summary>
    public uint spsStdCount;
    /// <summary>pSpsStd is a pointer to an array of spsStdCountStdVideoH265SequenceParameterSet structures representing H.265 sequence parameter sets.</summary>
    public StdVideoH265SequenceParameterSet* pSpsStd;
    /// <summary>ppsStdCount is the number of PPS elements in pPpsStd.</summary>
    public uint ppsStdCount;
    /// <summary>pPpsStd is a pointer to an array of ppsStdCountStdVideoH265PictureParameterSet structures representing H.265 picture parameter sets.</summary>
    public StdVideoH265PictureParameterSet* pPpsStd;
}
