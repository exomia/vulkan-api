// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH265SessionParametersCreateInfoEXT - Structure specifies H.265 decoder parameter set information - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersCreateInfoEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoSessionParametersCreateInfoKHR</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoSessionParametersCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>maxSpsStdCount is the maximum number of SPS parameters that the VkVideoSessionParametersKHR can contain.</summary>
    public uint maxSpsStdCount;
    /// <summary>maxPpsStdCount is the maximum number of PPS parameters that the VkVideoSessionParametersKHR can contain.</summary>
    public uint maxPpsStdCount;
    /// <summary>pParametersAddInfo is NULL or a pointer to a VkVideoDecodeH265SessionParametersAddInfoEXT structure specifying H.265 parameters to add upon object creation.</summary>
    public VkVideoDecodeH265SessionParametersAddInfoEXT* pParametersAddInfo;
}
