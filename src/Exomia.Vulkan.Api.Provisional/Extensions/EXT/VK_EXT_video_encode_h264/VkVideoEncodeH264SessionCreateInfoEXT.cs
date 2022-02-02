// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH264SessionCreateInfoEXT - Structure specifies H.264 encoder creation parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionCreateInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionCreateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264SessionCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is a bitmask of VkVideoEncodeH264CreateFlagsEXTspecifying H.264 encoder creation flags.</summary>
    public VkVideoEncodeH264CreateFlagsEXT flags;
    /// <summary>maxPictureSizeInMbs specifies the syntax element pic_width_in_mbs_minus1 + 1 and the syntax element pic_height_in_map_units_minus1 + 1.</summary>
    public VkExtent2D maxPictureSizeInMbs;
    /// <summary>pStdExtensionVersion is a pointer to a VkExtensionPropertiesstructure specifying H.264 codec extensions.</summary>
    public VkExtensionProperties* pStdExtensionVersion;
}
