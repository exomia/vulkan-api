// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Android;

/// <summary> VkExternalFormatANDROID - Structure containing an Android hardware buffer external format - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFormatANDROID.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFormatANDROID.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkImageCreateInfo,VkSamplerYcbcrConversionCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkImageCreateInfo,VkSamplerYcbcrConversionCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFormatANDROID {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>externalFormat is an implementation-defined identifier for the external format</summary>
    public ulong externalFormat;
}
