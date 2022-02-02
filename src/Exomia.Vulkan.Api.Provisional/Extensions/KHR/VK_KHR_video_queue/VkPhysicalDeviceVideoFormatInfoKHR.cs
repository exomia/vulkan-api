// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkPhysicalDeviceVideoFormatInfoKHR - Structure specifying the codec video format - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoFormatInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoFormatInfoKHR.html</a></summary>
    /// <remarks><list type="table">
    ///     <item><term>returnedonly</term><description>true</description></item>
    /// </list></remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>imageUsage is a bitmask of VkImageUsageFlagBits specifying intended video image usages.</summary>
    public VkImageUsageFlags imageUsage;
    /// <summary>pVideoProfiles is a pointer to a VkVideoProfilesKHRstructure providing the video profile(s) of video session(s) that will use the image. For most use cases, the image is used by a single video session and a single video profile is provided. For a use case such as transcode, where a decode session output image may be used as encode input for one or more encode sessions, multiple video profiles representing the video sessions that will share the image may be provided.</summary>
    public VkVideoProfilesKHR* pVideoProfiles;
}
