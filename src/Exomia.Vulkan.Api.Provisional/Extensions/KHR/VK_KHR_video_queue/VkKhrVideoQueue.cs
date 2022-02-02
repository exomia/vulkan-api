global using static Exomia.Vulkan.Api.Provisional.VkKhrVideoQueue;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///    VK_KHR_video_queue - device extension (nr. 24) - author 'KHR' [platform 'provisional' | contact 'Tony Zlatinski @tzlatinski']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_queue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_queue.html</a>
/// </summary>
/// <remarks>
///    provisional: true
/// </remarks>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_sampler_ycbcr_conversion")]
[VkProvisional("true")]
public static unsafe partial class VkKhrVideoQueue
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_VIDEO_QUEUE_SPEC_VERSION = 2;
    /// <summary> The extension name. </summary>
    public const string VK_KHR_VIDEO_QUEUE_EXTENSION_NAME = "VK_KHR_video_queue";
    /// <summary> An UTF8 null terminated version of <see cref="VK_KHR_VIDEO_QUEUE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_KHR_VIDEO_QUEUE_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_VIDEO_QUEUE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u565f\u4449\u4f45\u515f\u4555\u4555\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary> vkGetPhysicalDeviceVideoCapabilitiesKHR - Query video decode or encode capabilities - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoCapabilitiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoCapabilitiesKHR.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device whose video decode or encode capabilities will be queried.</param>
    /// <param name="pVideoProfile">pVideoProfile is a pointer to a VkVideoProfileKHR structure with a chained codec-operation specific video profile structure.</param>
    /// <param name="pCapabilities">pCapabilities is a pointer to a VkVideoCapabilitiesKHRstructure in which the capabilities are returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_FEATURE_NOT_PRESENT,VK_ERROR_FORMAT_NOT_SUPPORTED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        VkVideoProfileKHR* /*pVideoProfile*/, 
        VkVideoCapabilitiesKHR* /*pCapabilities*/, 
        VkResult> vkGetPhysicalDeviceVideoCapabilitiesKHR = null;

    /// <summary> vkGetPhysicalDeviceVideoFormatPropertiesKHR - Query supported Video Decode and Encode image formats - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device being queried.</param>
    /// <param name="pVideoFormatInfo">pVideoFormatInfo is a pointer to a VkPhysicalDeviceVideoFormatInfoKHR structure specifying the codec and video profile for which information is returned.</param>
    /// <param name="pVideoFormatPropertyCount">pVideoFormatPropertyCount is a pointer to an integer related to the number of video format properties available or queried, as described below.</param>
    /// <param name="pVideoFormatProperties">pVideoFormatProperties is a pointer to an array of VkVideoFormatPropertiesKHR structures in which supported formats are returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_FORMAT_NOT_SUPPORTED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        VkPhysicalDeviceVideoFormatInfoKHR* /*pVideoFormatInfo*/, 
        uint* /*pVideoFormatPropertyCount*/, 
        VkVideoFormatPropertiesKHR* /*pVideoFormatProperties*/, 
        VkResult> vkGetPhysicalDeviceVideoFormatPropertiesKHR = null;

    /// <summary> vkCreateVideoSessionKHR - Creates a video session object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionKHR.html</a> </summary>
    /// <param name="device">device is the logical device that creates the decode or encode session object.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkVideoSessionCreateInfoKHRstructure containing parameters specifying the creation of the decode or encode session.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pVideoSession">pVideoSession is a pointer to a VkVideoSessionKHR structure specifying the decode or encode video session object which will be created by this function when it returns VK_SUCCESS</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_INCOMPATIBLE_DRIVER,VK_ERROR_FEATURE_NOT_PRESENT</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionCreateInfoKHR* /*pCreateInfo*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        VkVideoSessionKHR* /*pVideoSession*/, 
        VkResult> vkCreateVideoSessionKHR = null;

    /// <summary> vkDestroyVideoSessionKHR - Destroy decode session object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionKHR.html</a> </summary>
    /// <param name="device">device is the device that was used for the creation of the video session.</param>
    /// <param name="videoSession">videoSession is the decode or encode video session to be destroyed.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionKHR /*videoSession*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        void> vkDestroyVideoSessionKHR = null;

    /// <summary> vkGetVideoSessionMemoryRequirementsKHR - Get Memory Requirements - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetVideoSessionMemoryRequirementsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetVideoSessionMemoryRequirementsKHR.html</a> </summary>
    /// <param name="device">device is the logical device that owns the video session.</param>
    /// <param name="videoSession">videoSession is the video session to query.</param>
    /// <param name="pVideoSessionMemoryRequirementsCount">pVideoSessionMemoryRequirementsCount is a pointer to an integer related to the number of memory heap requirements available or queried, as described below.</param>
    /// <param name="pVideoSessionMemoryRequirements">pVideoSessionMemoryRequirements is NULL or a pointer to an array of VkVideoGetMemoryPropertiesKHR structures in which the memory heap requirements of the video session are returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionKHR /*videoSession*/, 
        uint* /*pVideoSessionMemoryRequirementsCount*/, 
        VkVideoGetMemoryPropertiesKHR* /*pVideoSessionMemoryRequirements*/, 
        VkResult> vkGetVideoSessionMemoryRequirementsKHR = null;

    /// <summary> vkBindVideoSessionMemoryKHR - Bind Video Memory - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindVideoSessionMemoryKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindVideoSessionMemoryKHR.html</a> </summary>
    /// <param name="device">device is the logical device that owns the video session&#8217;s memory.</param>
    /// <param name="videoSession">videoSession is the video session to be bound with device memory.</param>
    /// <param name="videoSessionBindMemoryCount">videoSessionBindMemoryCount is the number of pVideoSessionBindMemories to be bound.</param>
    /// <param name="pVideoSessionBindMemories">pVideoSessionBindMemories is a pointer to an array of VkVideoBindMemoryKHR structures specifying memory regions to be bound to a device memory heap.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionKHR /*videoSession*/, 
        uint /*videoSessionBindMemoryCount*/, 
        VkVideoBindMemoryKHR* /*pVideoSessionBindMemories*/, 
        VkResult> vkBindVideoSessionMemoryKHR = null;

    /// <summary> vkCreateVideoSessionParametersKHR - Creates video session video session parameter object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionParametersKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionParametersKHR.html</a> </summary>
    /// <param name="device">device is the logical device that was used for the creation of the video session object.</param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to VkVideoSessionParametersCreateInfoKHR structure specifying the video session parameters.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pVideoSessionParameters">pVideoSessionParameters is a pointer to a VkVideoSessionParametersKHR handle in which the video session parameters object is returned.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_TOO_MANY_OBJECTS</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionParametersCreateInfoKHR* /*pCreateInfo*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        VkVideoSessionParametersKHR* /*pVideoSessionParameters*/, 
        VkResult> vkCreateVideoSessionParametersKHR = null;

    /// <summary> vkUpdateVideoSessionParametersKHR - Update video session video session parameter object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateVideoSessionParametersKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateVideoSessionParametersKHR.html</a> </summary>
    /// <param name="device">device is the logical device that was used for the creation of the video session object.</param>
    /// <param name="videoSessionParameters">videoSessionParameters is the video session object that is going to be updated.</param>
    /// <param name="pUpdateInfo">pUpdateInfo is a pointer to a VkVideoSessionParametersUpdateInfoKHR structure containing the session parameters update information.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_TOO_MANY_OBJECTS</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionParametersKHR /*videoSessionParameters*/, 
        VkVideoSessionParametersUpdateInfoKHR* /*pUpdateInfo*/, 
        VkResult> vkUpdateVideoSessionParametersKHR = null;

    /// <summary> vkDestroyVideoSessionParametersKHR - Destroy video session parameters object - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionParametersKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionParametersKHR.html</a> </summary>
    /// <param name="device">device is the device the video session was created with.</param>
    /// <param name="videoSessionParameters">videoSessionParameters is the video session parameters object to be destroyed.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/, 
        VkVideoSessionParametersKHR /*videoSessionParameters*/, 
        VkAllocationCallbacks* /*pAllocator*/, 
        void> vkDestroyVideoSessionParametersKHR = null;

    /// <summary> vkCmdBeginVideoCodingKHR - Start decode jobs - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginVideoCodingKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginVideoCodingKHR.html</a> </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer to be used when recording commands for the video decode or encode operations.</param>
    /// <param name="pBeginInfo">pBeginInfo is a pointer to a VkVideoBeginCodingInfoKHRstructure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/, 
        VkVideoBeginCodingInfoKHR* /*pBeginInfo*/, 
        void> vkCmdBeginVideoCodingKHR = null;

    /// <summary> vkCmdEndVideoCodingKHR - End decode jobs - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndVideoCodingKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndVideoCodingKHR.html</a> </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer to be filled by this function.</param>
    /// <param name="pEndCodingInfo">pEndCodingInfo is a pointer to a VkVideoEndCodingInfoKHRstructure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/, 
        VkVideoEndCodingInfoKHR* /*pEndCodingInfo*/, 
        void> vkCmdEndVideoCodingKHR = null;

    /// <summary> vkCmdControlVideoCodingKHR - Set encode rate control parameters - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdControlVideoCodingKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdControlVideoCodingKHR.html</a> </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer to be filled by this function.</param>
    /// <param name="pCodingControlInfo">pCodingControlInfo is a pointer to a VkVideoCodingControlInfoKHR structure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/, 
        VkVideoCodingControlInfoKHR* /*pCodingControlInfo*/, 
        void> vkCmdControlVideoCodingKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device) {
        fixed(delegate*<VkPhysicalDevice, VkVideoProfileKHR*, VkVideoCapabilitiesKHR*, VkResult>* pvkGetPhysicalDeviceVideoCapabilitiesKHR = &vkGetPhysicalDeviceVideoCapabilitiesKHR) 
        {
            *pvkGetPhysicalDeviceVideoCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkVideoProfileKHR*, VkVideoCapabilitiesKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5665\u6469\u6f65\u6143\u6170\u6962\u696c\u6974\u7365\u484b\u0052");
        }
        fixed(delegate*<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult>* pvkGetPhysicalDeviceVideoFormatPropertiesKHR = &vkGetPhysicalDeviceVideoFormatPropertiesKHR) 
        {
            *pvkGetPhysicalDeviceVideoFormatPropertiesKHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5665\u6469\u6f65\u6f46\u6d72\u7461\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }
        fixed(delegate*<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult>* pvkCreateVideoSessionKHR = &vkCreateVideoSessionKHR) 
        {
            *pvkCreateVideoSessionKHR = (delegate*<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u7243\u6165\u6574\u6956\u6564\u536f\u7365\u6973\u6e6f\u484b\u0052");
        }
        fixed(delegate*<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>* pvkDestroyVideoSessionKHR = &vkDestroyVideoSessionKHR) 
        {
            *pvkDestroyVideoSessionKHR = (delegate*<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u5679\u6469\u6f65\u6553\u7373\u6f69\u4b6e\u5248\u0000");
        }
        fixed(delegate*<VkDevice, VkVideoSessionKHR, uint*, VkVideoGetMemoryPropertiesKHR*, VkResult>* pvkGetVideoSessionMemoryRequirementsKHR = &vkGetVideoSessionMemoryRequirementsKHR) 
        {
            *pvkGetVideoSessionMemoryRequirementsKHR = (delegate*<VkDevice, VkVideoSessionKHR, uint*, VkVideoGetMemoryPropertiesKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5674\u6469\u6f65\u6553\u7373\u6f69\u4d6e\u6d65\u726f\u5279\u7165\u6975\u6572\u656d\u746e\u4b73\u5248\u0000");
        }
        fixed(delegate*<VkDevice, VkVideoSessionKHR, uint, VkVideoBindMemoryKHR*, VkResult>* pvkBindVideoSessionMemoryKHR = &vkBindVideoSessionMemoryKHR) 
        {
            *pvkBindVideoSessionMemoryKHR = (delegate*<VkDevice, VkVideoSessionKHR, uint, VkVideoBindMemoryKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6942\u646e\u6956\u6564\u536f\u7365\u6973\u6e6f\u654d\u6f6d\u7972\u484b\u0052");
        }
        fixed(delegate*<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult>* pvkCreateVideoSessionParametersKHR = &vkCreateVideoSessionParametersKHR) 
        {
            *pvkCreateVideoSessionParametersKHR = (delegate*<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u7243\u6165\u6574\u6956\u6564\u536f\u7365\u6973\u6e6f\u6150\u6172\u656d\u6574\u7372\u484b\u0052");
        }
        fixed(delegate*<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult>* pvkUpdateVideoSessionParametersKHR = &vkUpdateVideoSessionParametersKHR) 
        {
            *pvkUpdateVideoSessionParametersKHR = (delegate*<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u7055\u6164\u6574\u6956\u6564\u536f\u7365\u6973\u6e6f\u6150\u6172\u656d\u6574\u7372\u484b\u0052");
        }
        fixed(delegate*<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>* pvkDestroyVideoSessionParametersKHR = &vkDestroyVideoSessionParametersKHR) 
        {
            *pvkDestroyVideoSessionParametersKHR = (delegate*<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u5679\u6469\u6f65\u6553\u7373\u6f69\u506e\u7261\u6d61\u7465\u7265\u4b73\u5248\u0000");
        }
        fixed(delegate*<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>* pvkCmdBeginVideoCodingKHR = &vkCmdBeginVideoCodingKHR) 
        {
            *pvkCmdBeginVideoCodingKHR = (delegate*<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4264\u6765\u6e69\u6956\u6564\u436f\u646f\u6e69\u4b67\u5248\u0000");
        }
        fixed(delegate*<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>* pvkCmdEndVideoCodingKHR = &vkCmdEndVideoCodingKHR) 
        {
            *pvkCmdEndVideoCodingKHR = (delegate*<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4564\u646e\u6956\u6564\u436f\u646f\u6e69\u4b67\u5248\u0000");
        }
        fixed(delegate*<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>* pvkCmdControlVideoCodingKHR = &vkCmdControlVideoCodingKHR) 
        {
            *pvkCmdControlVideoCodingKHR = (delegate*<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4364\u6e6f\u7274\u6c6f\u6956\u6564\u436f\u646f\u6e69\u4b67\u5248\u0000");
        }
    }
}
