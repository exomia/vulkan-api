// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH264CapabilitiesEXT - Structure specifying H.264 decode capabilities - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264CapabilitiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264CapabilitiesEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCapabilitiesKHR</description></item>
    ///     <item><term>returnedonly</term><description>true</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264CapabilitiesEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>maxLevel is the maximum H.264 level supported by the device.</summary>
    public uint maxLevel;
    /// <summary>fieldOffsetGranularity - if Interlaced Video Content is suported, the maximum field offset granularity supported for the picture resource.</summary>
    public VkOffset2D fieldOffsetGranularity;
    /// <summary>stdExtensionVersion is a VkExtensionProperties structure specifying the H.264 extension name and version supported by this implementation.</summary>
    public VkExtensionProperties stdExtensionVersion;
}
