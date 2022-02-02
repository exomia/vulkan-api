// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkQueueFamilyQueryResultStatusProperties2KHR - Structure specifying support for result status query - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyQueryResultStatusProperties2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyQueryResultStatusProperties2KHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkQueueFamilyProperties2</description></item>
    /// </list></remarks>
[VkStructExtends("VkQueueFamilyProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyQueryResultStatusProperties2KHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_2_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>supported reports VK_TRUE if query type VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR and use of VK_QUERY_RESULT_WITH_STATUS_BIT_KHR are supported.</summary>
    public VkBool32 supported;
}
