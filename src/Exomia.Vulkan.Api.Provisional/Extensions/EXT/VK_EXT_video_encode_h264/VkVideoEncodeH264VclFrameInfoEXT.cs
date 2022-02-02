// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264VclFrameInfoEXT - Structure specifies H.264 encode frame parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264VclFrameInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264VclFrameInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264VclFrameInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_VCL_FRAME_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>refDefaultFinalList0EntryCount is the default number of reference List0 entries for all slices of this frame. Each slice may override this by providing its own List0 entries.</summary>
    public byte refDefaultFinalList0EntryCount;
    /// <summary>pRefDefaultFinalList0Entries is a pointer to an array of VkVideoEncodeH264DpbSlotInfoEXT structures providing information for each reference List0 entry. The entries provided must be ordered after all reference List0 modification operations are applied (i.e. final list order). The entires provided must not reflect decoded picture marking operations in this frame that are applicable to references; the impact of such operations must be reflected in future frame encode cmds. The slot index in each entry must match one of the slot indexes provided in pReferenceSlots of the VkVideoEncodeInfoKHRstructure to which this structure is chained.</summary>
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList0Entries;
    /// <summary>refDefaultFinalList1EntryCount is the default number of reference List1 entries for all slices of this frame. Each slice may override this by providing its own List1 entries.</summary>
    public byte refDefaultFinalList1EntryCount;
    /// <summary>pRefDefaultFinalList1Entries is a pointer to an array of VkVideoEncodeH264DpbSlotInfoEXT structures providing information related to each reference List1 entry. The entries provided must be ordered after all reference List1 modification operations are applied (i.e. final list order). The entires provided must not reflect decoded picture marking operations in this frame that are applicable to references; the impact of such operations must be reflected in future frame encode cmds. The slot index in each entry must match one of the slot indexes provided in pReferenceSlots of the VkVideoEncodeInfoKHRstructure to which this structure is chained.</summary>
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList1Entries;
    /// <summary>naluSliceEntryCount is the number of NALUs in this frame.</summary>
    public uint naluSliceEntryCount;
    /// <summary>pNaluSliceEntries is a pointer to an array of naluCountVkVideoEncodeH264NaluSliceEXT structures that make up the frame. This is an ordered sequence; the NALUs are generated consecutively in the bitstream buffer (provided in bitstreamBuffer in VkVideoBeginCodingInfoKHR) in the same order as in this array.</summary>
    public VkVideoEncodeH264NaluSliceEXT* pNaluSliceEntries;
    /// <summary>pCurrentPictureInfo is a pointer to a VkVideoEncodeH264DpbSlotInfoEXT structure specifying information for the reconstructed picture for this frame. Info provided must reflect decoded picture marking operations in this frame that are applicable to this frame. The slot index in pCurrentPictureInfo must match the slot index provided in pSetupReferenceSlot of VkVideoEncodeInfoKHRstructure to which this structure is chained to.</summary>
    public VkVideoEncodeH264DpbSlotInfoEXT* pCurrentPictureInfo;
}
