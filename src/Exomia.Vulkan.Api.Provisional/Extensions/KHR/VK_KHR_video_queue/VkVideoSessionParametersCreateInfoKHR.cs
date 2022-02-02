// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary> VkVideoSessionParametersCreateInfoKHR - Structure to set video session parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateInfoKHR.html</a></summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersCreateInfoKHR {
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;
    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;
    /// <summary>videoSessionParametersTemplate is VK_NULL_HANDLE or a valid handle to a VkVideoSessionParametersKHR object. If this parameter represents a valid handle, then the underlying Video Session Parameters object will be used as a template for constructing the new video session parameters object. All of the template object&#8217;s current parameters will be inherited by the new object in such a case. Optionally, some of the template&#8217;s parameters can be updated or new parameters added to the newly constructed object via the extension-specific parameters.</summary>
    public VkVideoSessionParametersKHR videoSessionParametersTemplate;
    /// <summary>videoSession is the video session object against which the video session parameters object is going to be created.</summary>
    public VkVideoSessionKHR videoSession;
}
