// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264EmitPictureParametersEXT - Structure specifies H.264 encode SPS NALU insertion parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264EmitPictureParametersEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264EmitPictureParametersEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264EmitPictureParametersEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_EMIT_PICTURE_PARAMETERS_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>spsId is the H.264 SPS ID for the H.264 SPS to insert in the bitstream. The SPS ID must match the SPS provided in spsStd of VkVideoEncodeH264SessionParametersCreateInfoEXT. This is retrieved from the VkVideoSessionParametersKHR object provided in VkVideoBeginCodingInfoKHR.</summary>
    public byte spsId;
    /// <summary>emitSpsEnable enables the emitting of the SPS structure with id of spsId.</summary>
    public VkBool32 emitSpsEnable;
    /// <summary>ppsIdEntryCount is the number of entries in the ppsIdEntries. If this parameter is 0 then no pps entries are going to be emitted in the bitstream.</summary>
    public uint ppsIdEntryCount;
    /// <summary>ppsIdEntries is a pointer to an array of H.264 PPS IDs for the H.264 PPS to insert in the bitstream. The PPS IDs must match one of the IDs of the PPS(s) provided in pPpsStd of VkVideoEncodeH264SessionParametersCreateInfoEXTto identify the PPS parameter set to insert in the bitstream. This is retrieved from the VkVideoSessionParametersKHR object provided in VkVideoBeginCodingInfoKHR.</summary>
    public byte* ppsIdEntries;
}
