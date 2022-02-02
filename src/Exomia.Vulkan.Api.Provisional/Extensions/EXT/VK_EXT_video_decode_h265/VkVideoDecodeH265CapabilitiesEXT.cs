// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoDecodeH265CapabilitiesEXT - Structure specifies H.265 decode capabilities parameters when decoding a frame - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265CapabilitiesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265CapabilitiesEXT.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkVideoCapabilitiesKHR</description></item>
    ///     <item><term>returnedonly</term><description>true</description></item>
    /// </list></remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265CapabilitiesEXT {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>maxLevel is the maximum H.265 level supported by the device.</summary>
    public uint maxLevel;
    /// <summary>stdExtensionVersion is a VkExtensionProperties structure specifying the H.265 extension name and version supported by this implementation.</summary>
    public VkExtensionProperties stdExtensionVersion;
}
