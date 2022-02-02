// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265EmitPictureParametersEXT - Structure specifies H.265 encode VPS NALU insertion parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265EmitPictureParametersEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265EmitPictureParametersEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265EmitPictureParametersEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_EMIT_PICTURE_PARAMETERS_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>vpsId is the H.265 VPS ID for the H.265 VPS to insert in the bitstream. The VPS ID must match the VPS provided in vpsStd of VkVideoEncodeH265SessionParametersCreateInfoEXT. This is retrieved from the VkVideoSessionParametersKHR object provided in VkVideoBeginCodingInfoKHR.</summary>
    public byte vpsId;
    /// <summary>spsId is the H.265 SPS ID for the H.265 SPS to insert in the bitstream. The SPS ID must match one of the IDs of the SPS(s) provided in pSpsStd of VkVideoEncodeH265SessionParametersCreateInfoEXTto identify the SPS parameter set to insert in the bitstream. This is retrieved from the VkVideoSessionParametersKHR object provided in VkVideoBeginCodingInfoKHR.</summary>
    public byte spsId;
    /// <summary>emitVpsEnable enables the emitting of the VPS structure with id of vpsId.</summary>
    public VkBool32 emitVpsEnable;
    /// <summary>emitSpsEnable enables the emitting of the SPS structure with id of spsId.</summary>
    public VkBool32 emitSpsEnable;
    /// <summary>ppsIdEntryCount is the number of entries in the ppsIdEntries. If this parameter is 0 then no pps entries are going to be emitted in the bitstream.</summary>
    public uint ppsIdEntryCount;
    /// <summary>ppsIdEntries is the H.265 PPS IDs for the H.265 PPS to insert in the bitstream. The PPS IDs must match one of the IDs of the PPS(s) provided in pPpsStd of VkVideoEncodeH265SessionParametersCreateInfoEXTto identify the PPS parameter set to insert in the bitstream. This is retrieved from the VkVideoSessionParametersKHR object provided in VkVideoBeginCodingInfoKHR.</summary>
    public byte* ppsIdEntries;
}
