// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkPhysicalDevicePortabilitySubsetPropertiesKHR - Structure describing additional properties supported by a portable implementation - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePortabilitySubsetPropertiesKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkPhysicalDeviceProperties2</description></item>
    /// </list></remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePortabilitySubsetPropertiesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>minVertexInputBindingStrideAlignment indicates the minimum alignment for vertex input strides. VkVertexInputBindingDescription::stride must be a multiple of, and at least as large as, this value. The value must be a power of two.</summary>
    public uint minVertexInputBindingStrideAlignment;
}
