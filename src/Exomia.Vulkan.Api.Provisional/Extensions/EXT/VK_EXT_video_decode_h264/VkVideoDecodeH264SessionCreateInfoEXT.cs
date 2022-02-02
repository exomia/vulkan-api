// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264SessionCreateInfoEXT - Structure specifies H.264 decode session creation parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionCreateInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionCreateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkVideoDecodeH264CreateFlagsEXT flags;
    /// <summary>pStdExtensionVersion is a pointer to a VkExtensionPropertiesstructure specifying the H.264 codec extensions defined in StdVideoH264Extensions.</summary>
    public VkExtensionProperties* pStdExtensionVersion;
}
