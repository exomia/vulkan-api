// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265SessionCreateInfoEXT - Structure specifies H.265 encoder creation parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionCreateInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionCreateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>flags is reserved for future use.</summary>
    public VkVideoEncodeH265CreateFlagsEXT flags;
    /// <summary>pStdExtensionVersion is a pointer to a VkExtensionPropertiesstructure specifying the H.265 codec extension version.</summary>
    public VkExtensionProperties* pStdExtensionVersion;
}
