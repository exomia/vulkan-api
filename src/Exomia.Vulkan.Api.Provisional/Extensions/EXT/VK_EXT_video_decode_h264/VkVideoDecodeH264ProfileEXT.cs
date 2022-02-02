// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264ProfileEXT - Structure specifying H.264 decode profile - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264ProfileEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264ProfileEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoProfileKHR,VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoProfileKHR,VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264ProfileEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>stdProfileIdc is a StdVideoH264ProfileIdc value specifying the H.264 codec profile IDC</summary>
    public StdVideoH264ProfileIdc stdProfileIdc;
    /// <summary>pictureLayout is a bitmask of VkVideoDecodeH264PictureLayoutFlagBitsEXT specifying the layout of the decoded picture&#8217;s contents depending on the nature (progressive vs. interlaced) of the input content.</summary>
    public VkVideoDecodeH264PictureLayoutFlagsEXT pictureLayout;
}
