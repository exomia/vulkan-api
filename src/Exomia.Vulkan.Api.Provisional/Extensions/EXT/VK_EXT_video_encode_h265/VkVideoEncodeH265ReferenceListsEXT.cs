// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265ReferenceListsEXT - Structure specifies H.265 reference frame lists - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265ReferenceListsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265ReferenceListsEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265ReferenceListsEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_REFERENCE_LISTS_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>referenceList0EntryCount is the number of reference pictures in reference list L0 and is identical to StdVideoEncodeH265SliceHeader::num_ref_idx_l0_active_minus1 + 1.</summary>
    public byte referenceList0EntryCount;
    /// <summary>pReferenceList0Entries is a pointer to an array of referenceList0EntryCount VkVideoEncodeH265DpbSlotInfoEXTstructures specifying the reference list L0 entries for the current picture.</summary>
    public VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList0Entries;
    /// <summary>referenceList1EntryCount is the number of reference pictures in reference list L1 and is identical to StdVideoEncodeH265SliceHeader::num_ref_idx_l1_active_minus1 + 1.</summary>
    public byte referenceList1EntryCount;
    /// <summary>pReferenceList1Entries is a pointer to an array of referenceList1EntryCount VkVideoEncodeH265DpbSlotInfoEXTstructures specifying the reference list L1 entries for the current picture.</summary>
    public VkVideoEncodeH265DpbSlotInfoEXT* pReferenceList1Entries;
    /// <summary>pReferenceModifications is a pointer to a StdVideoEncodeH265ReferenceModifications structure specifying reference list modifications.</summary>
    public StdVideoEncodeH265ReferenceModifications* pReferenceModifications;
}
