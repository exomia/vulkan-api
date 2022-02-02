// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264NaluSliceEXT - Structure specifies H.264 encode slice NALU parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264NaluSliceEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264NaluSliceEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264NaluSliceEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pSliceHeaderStd is a pointer to a StdVideoEncodeH264SliceHeader specifying the standard slice header from the H.264 specification.</summary>
    public StdVideoEncodeH264SliceHeader* pSliceHeaderStd;
    /// <summary>mbCount is the number of macroblocks in this slice.</summary>
    public uint mbCount;
    /// <summary>refFinalList0EntryCount is the number of active references in List0. If zero, the default frame List0 provided in the enclosing VkVideoEncodeH264VclFrameInfoEXT is used. If non-zero, it overrides the default frame List0 for this slice.</summary>
    public byte refFinalList0EntryCount;
    /// <summary>pRefFinalList0Entries is a pointer to a VkVideoEncodeH264DpbSlotInfoEXT specifying DPB information for the active List0 references. The same restrictions related to order of entries and decoded picture marking operations described for List0 in VkVideoEncodeH264VclFrameInfoEXT apply here.</summary>
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefFinalList0Entries;
    /// <summary>refFinalList1EntryCount is the number of active references in List1. If zero, the default frame List1 provided in the enclosing VkVideoEncodeH264VclFrameInfoEXT is used. If non-zero, it overrides the default frame List1 for this slice.</summary>
    public byte refFinalList1EntryCount;
    /// <summary>pRefFinalList1Entries is a pointer to a VkVideoEncodeH264DpbSlotInfoEXT structure specifying DPB information for the active List1 references. The same restrictions related to order of entries and decoded picture marking operations described for List1 in VkVideoEncodeH264VclFrameInfoEXT apply here.</summary>
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefFinalList1Entries;
}
