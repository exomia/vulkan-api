// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoFormatPropertiesKHR - Structure enumerating the video image formats - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoFormatPropertiesKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>returnedonly</term><description>true</description></item>
    /// </list></remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoFormatPropertiesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>format is one of the supported formats reported by the implementation.</summary>
    public VkFormat format;
}
