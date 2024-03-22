#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrVideoEncodeQueue;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_video_encode_queue - device extension (nr. 300) - author 'KHR' [platform '' | contact 'Ahmed Abdelkhalek
///     @aabdelkh']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_queue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_video_encode_queue.html</a>
/// </summary>
[VkDepends("VK_KHR_video_queue+(VK_KHR_synchronization2,VK_VERSION_1_3)")]
[VkDeviceExt]
public static unsafe class VkKhrVideoEncodeQueue
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 12;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME = "VK_KHR_video_encode_queue";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u565f\u4449\u4f45\u455f\u434e\u444f\u5f45\u5551\u5545\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR - Query video encode quality level properties -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device to query the video encode quality level properties
    ///     for.
    /// </param>
    /// <param name="pQualityLevelInfo">
    ///     pQualityLevelInfo is a pointer to a VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
    ///     structure specifying the video encode profile and quality level to query properties for.
    /// </param>
    /// <param name="pQualityLevelProperties">
    ///     pQualityLevelProperties is a pointer to a VkVideoEncodeQualityLevelPropertiesKHR
    ///     structure in which the properties are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* /*pQualityLevelInfo*/,
        VkVideoEncodeQualityLevelPropertiesKHR* /*pQualityLevelProperties*/,
        VkResult> vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR = null;

    /// <summary>
    ///     vkGetEncodedVideoSessionParametersKHR - Get encoded parameter sets from a video session parameters object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetEncodedVideoSessionParametersKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetEncodedVideoSessionParametersKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the video session parameters object.</param>
    /// <param name="pVideoSessionParametersInfo">
    ///     pVideoSessionParametersInfo is a pointer to a
    ///     VkVideoEncodeSessionParametersGetInfoKHR structure specifying the parameters of the encoded parameter data to
    ///     retrieve.
    /// </param>
    /// <param name="pFeedbackInfo">
    ///     pFeedbackInfo is either NULL or a pointer to a
    ///     VkVideoEncodeSessionParametersFeedbackInfoKHR structure in which feedback about the requested parameter data is
    ///     returned.
    /// </param>
    /// <param name="pDataSize">
    ///     pDataSize is a pointer to a size_t value related to the amount of encode parameter data
    ///     returned, as described below.
    /// </param>
    /// <param name="pData">pData is either NULL or a pointer to a buffer to write the encoded parameter data to.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkVideoEncodeSessionParametersGetInfoKHR* /*pVideoSessionParametersInfo*/,
        VkVideoEncodeSessionParametersFeedbackInfoKHR* /*pFeedbackInfo*/,
        nuint* /*pDataSize*/,
        void* /*pData*/,
        VkResult> vkGetEncodedVideoSessionParametersKHR = null;

    /// <summary>
    ///     vkCmdEncodeVideoKHR - Launch video encode operations -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pEncodeInfo">
    ///     pEncodeInfo is a pointer to a VkVideoEncodeInfoKHR structure specifying the parameters of the
    ///     video encode operations.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkVideoEncodeInfoKHR* /*pEncodeInfo*/,
        void> vkCmdEncodeVideoKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult>*
            pvkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR = &vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR)
        {
            *pvkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR =
                (delegate*<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult>)GetVkFunction(
                    instance,
                    "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5665\u6469\u6f65\u6e45\u6f63\u6564\u7551\u6c61\u7469\u4c79\u7665\u6c65\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetEncodedVideoSessionParametersKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdEncodeVideoKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult>* pvkGetEncodedVideoSessionParametersKHR =
            &vkGetEncodedVideoSessionParametersKHR)
        {
            *pvkGetEncodedVideoSessionParametersKHR =
                (delegate*<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult>)GetVkFunction(
                    device, "\u6b76\u6547\u4574\u636e\u646f\u6465\u6956\u6564\u536f\u7365\u6973\u6e6f\u6150\u6172\u656d\u6574\u7372\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>* pvkCmdEncodeVideoKHR = &vkCmdEncodeVideoKHR)
        {
            *pvkCmdEncodeVideoKHR = (delegate*<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>)GetVkFunction(device, "\u6b76\u6d43\u4564\u636e\u646f\u5665\u6469\u6f65\u484b\u0052");
        }
    }
}