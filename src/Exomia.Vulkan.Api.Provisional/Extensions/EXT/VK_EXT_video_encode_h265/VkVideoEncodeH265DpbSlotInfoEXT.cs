// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265DpbSlotInfoEXT - Structure specifies H.265 encode decoded pic info - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265DpbSlotInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265DpbSlotInfoEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265DpbSlotInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>slotIndex is the DPB Slot index for this picture.</summary>
    public int8_t slotIndex;
    /// <summary>pStdReferenceInfo is a pointer to a StdVideoEncodeH265ReferenceInfo structure specifying the syntax and other codec-specific information from the H.265 specification, associated with this reference picture.</summary>
    public StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo;
}
