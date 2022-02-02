// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoProfilesKHR - Structure enumerating the video profiles - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfilesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfilesKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>structextends</term><description>VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo</description></item>
    /// </list></remarks>
[VkStructExtends("VkFormatProperties2,VkImageCreateInfo,VkImageViewCreateInfo,VkBufferCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfilesKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_PROFILES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>profileCount is an integer which holds the number of video profiles included in pProfiles.</summary>
    public uint profileCount;
    /// <summary>pProfiles is a pointer to an array of VkVideoProfileKHRstructures. Each VkVideoProfileKHR structure must chain the corresponding codec-operation specific extension video profile structure.</summary>
    public VkVideoProfileKHR* pProfiles;
}
