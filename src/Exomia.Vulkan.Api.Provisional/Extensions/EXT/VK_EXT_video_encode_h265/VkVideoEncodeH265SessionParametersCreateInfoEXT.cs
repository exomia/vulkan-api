// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoEncodeH265SessionParametersCreateInfoEXT - Structure specifies H.265 encoder parameter set info - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersCreateInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionParametersCreateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionParametersCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionParametersCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>maxVpsStdCount is the maximum number of entries of type StdVideoH265VideoParameterSet within VkVideoSessionParametersKHR.</summary>
    public uint maxVpsStdCount;
    /// <summary>maxSpsStdCount is the maximum number of entries of type StdVideoH265SequenceParameterSet within VkVideoSessionParametersKHR.</summary>
    public uint maxSpsStdCount;
    /// <summary>maxPpsStdCount is the maximum number of entries of type StdVideoH265PictureParameterSet within VkVideoSessionParametersKHR.</summary>
    public uint maxPpsStdCount;
    /// <summary>pParametersAddInfo is NULL or a pointer to a VkVideoEncodeH265SessionParametersAddInfoEXT structure specifying the video session parameters to add upon creation of this object.</summary>
    public VkVideoEncodeH265SessionParametersAddInfoEXT* pParametersAddInfo;
}
