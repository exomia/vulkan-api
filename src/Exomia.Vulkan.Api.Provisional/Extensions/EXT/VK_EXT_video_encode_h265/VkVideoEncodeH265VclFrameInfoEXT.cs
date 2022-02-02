// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265VclFrameInfoEXT - Structure specifies H.265 encode frame parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265VclFrameInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265VclFrameInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoEncodeInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265VclFrameInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_VCL_FRAME_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pReferenceFinalLists is NULL or a pointer to a VkVideoEncodeH265ReferenceListsEXT structure specifying the reference lists to be used for the current picture.</summary>
    public VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;
    /// <summary>naluSliceEntryCount is the number of slice NALUs in the frame.</summary>
    public uint naluSliceEntryCount;
    /// <summary>pNaluSliceEntries is a pointer to an array of VkVideoEncodeH265NaluSliceEXT structures specifying the division of the current picture into slices and the properties of these slices.</summary>
    public VkVideoEncodeH265NaluSliceEXT* pNaluSliceEntries;
    /// <summary>pCurrentPictureInfo is a pointer to a StdVideoEncodeH265PictureInfo structure specifying the syntax and other codec-specific information from the H.265 specification, associated with this picture.</summary>
    public StdVideoEncodeH265PictureInfo* pCurrentPictureInfo;
}
