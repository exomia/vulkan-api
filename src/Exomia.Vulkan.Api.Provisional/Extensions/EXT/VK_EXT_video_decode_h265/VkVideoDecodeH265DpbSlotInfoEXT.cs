// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH265DpbSlotInfoEXT - Structure specifies H.265 DPB information when decoding a frame - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265DpbSlotInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265DpbSlotInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoReferenceSlotKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoReferenceSlotKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265DpbSlotInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pStdReferenceInfo is a pointer to a StdVideoDecodeH265ReferenceInfo structure specifying the codec standard specific picture reference information from the H.264 specification.</summary>
    public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
}
