// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoQueueFamilyProperties2KHR - Structure specifying the codec video operations - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoQueueFamilyProperties2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoQueueFamilyProperties2KHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkQueueFamilyProperties2</description></item>
    /// </list></remarks>
[VkStructExtends("VkQueueFamilyProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoQueueFamilyProperties2KHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_QUEUE_FAMILY_PROPERTIES_2_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>videoCodecOperations is a bitmask of VkVideoCodecOperationFlagBitsKHR specifying supported video codec operation(s).</summary>
    public VkVideoCodecOperationFlagsKHR videoCodecOperations;
}
