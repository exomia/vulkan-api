// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoSessionParametersUpdateInfoKHR - Structure to update video session parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersUpdateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersUpdateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersUpdateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>updateSequenceCount is the sequence number of the object update with parameters, starting from 1 and incrementing the value by one with each subsequent update.</summary>
    public uint updateSequenceCount;
}
