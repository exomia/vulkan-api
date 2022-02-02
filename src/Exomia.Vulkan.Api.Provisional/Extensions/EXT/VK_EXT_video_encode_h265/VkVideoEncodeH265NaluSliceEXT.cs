// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265NaluSliceEXT - Structure specifies H.265 encode slice NALU parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265NaluSliceEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265NaluSliceEXT.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265NaluSliceEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>ctbCount is the number of CTBs in this slice.</summary>
    public uint ctbCount;
    /// <summary>pReferenceFinalLists is NULL or a pointer to a VkVideoEncodeH265ReferenceListsEXT structure specifying the reference lists to be used for the current slice. If pReferenceFinalLists is not NULL, these reference lists override the reference lists provided in VkVideoEncodeH265VclFrameInfoEXT::pReferenceFinalLists.</summary>
    public VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;
    /// <summary>pSliceHeaderStd is a pointer to a StdVideoEncodeH265SliceHeader structure specifying the slice header for the current slice.</summary>
    public StdVideoEncodeH265SliceHeader* pSliceHeaderStd;
}
