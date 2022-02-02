// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH265ProfileEXT - Structure specifying H.265 decode profile - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265ProfileEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265ProfileEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoProfileKHR,VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoProfileKHR,VkQueryPoolCreateInfo,VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265ProfileEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>stdProfileIdc is a StdVideoH265ProfileIdc value specifying the H.265 codec profile IDC.</summary>
    public StdVideoH265ProfileIdc stdProfileIdc;
}
