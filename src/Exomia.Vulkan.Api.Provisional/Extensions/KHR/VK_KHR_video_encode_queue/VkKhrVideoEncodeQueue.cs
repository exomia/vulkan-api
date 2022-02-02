global using static Exomia.Vulkan.Api.Provisional.VkKhrVideoEncodeQueue;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///    VK_KHR_video_encode_queue - device extension (nr. 300) - author 'KHR' [platform 'provisional' | contact 'ahmed.abdelkalek@amd.com']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_queue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_queue.html</a>
/// </summary>
/// <remarks>
///    provisional: true
/// </remarks>
[VkRequires("VK_KHR_video_queue,VK_KHR_synchronization2")]
[VkProvisional("true")]
public static unsafe partial class VkKhrVideoEncodeQueue
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 3;
    /// <summary> The extension name. </summary>
    public const string VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME = "VK_KHR_video_encode_queue";
    /// <summary> An UTF8 null terminated version of <see cref="VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u565f\u4449\u4f45\u455f\u434e\u444f\u5f45\u5551\u5545\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary> vkCmdEncodeVideoKHR - Encode operation for bitstream generation - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html</a> </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer to be filled with this function for encoding to generate a bitstream.</param>
    /// <param name="pEncodeInfo">pEncodeInfo is a pointer to a VkVideoEncodeInfoKHRstructure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/, 
        VkVideoEncodeInfoKHR* /*pEncodeInfo*/, 
        void> vkCmdEncodeVideoKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device) {
        fixed(delegate*<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>* pvkCmdEncodeVideoKHR = &vkCmdEncodeVideoKHR) 
        {
            *pvkCmdEncodeVideoKHR = (delegate*<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4564\u636e\u646f\u5665\u6469\u6f65\u484b\u0052");
        }
    }
}
