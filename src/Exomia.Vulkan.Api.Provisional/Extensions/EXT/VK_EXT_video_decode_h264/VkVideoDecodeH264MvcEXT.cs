// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264MvcEXT - Structure specifies parameters of mvc views - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264MvcEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264MvcEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoDecodeH264PictureInfoEXT</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoDecodeH264PictureInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264MvcEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_MVC_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>pStdMvc is a pointer to a StdVideoDecodeH264Mvc structure specifying H.264 codec specification information for MVC.</summary>
    public StdVideoDecodeH264Mvc* pStdMvc;
}
