#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvOpticalFlow;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_optical_flow - device extension (nr. 465) - author 'NV' [platform '' | contact 'Carsten Rohde @crohde']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_optical_flow.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_optical_flow.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_format_feature_flags2,VK_KHR_synchronization2")]
public static unsafe class VkNvOpticalFlow
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_OPTICAL_FLOW_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_OPTICAL_FLOW_EXTENSION_NAME = "VK_NV_optical_flow";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_OPTICAL_FLOW_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_OPTICAL_FLOW_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_OPTICAL_FLOW_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u504f\u4954\u4143\u5f4c\u4c46\u574f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceOpticalFlowImageFormatsNV - Query image formats for optical flow -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceOpticalFlowImageFormatsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceOpticalFlowImageFormatsNV.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device being queried.</param>
    /// <param name="pOpticalFlowImageFormatInfo">
    ///     pOpticalFlowImageFormatInfo is a pointer to a VkOpticalFlowImageFormatInfoNV
    ///     structure specifying the optical flow usage for which information is returned.
    /// </param>
    /// <param name="pFormatCount">
    ///     pFormatCount is a pointer to an integer related to the number of optical flow properties
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pImageFormatProperties">
    ///     pImageFormatProperties is a pointer to an array of
    ///     VkOpticalFlowImageFormatPropertiesNV structures in which supported formats and image parameters are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_FORMAT_NOT_SUPPORTED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkOpticalFlowImageFormatInfoNV* /*pOpticalFlowImageFormatInfo*/,
        uint* /*pFormatCount*/,
        VkOpticalFlowImageFormatPropertiesNV* /*pImageFormatProperties*/,
        VkResult> vkGetPhysicalDeviceOpticalFlowImageFormatsNV = null;

    /// <summary>
    ///     vkCreateOpticalFlowSessionNV - Creates an optical flow session object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateOpticalFlowSessionNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateOpticalFlowSessionNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the optical flow session object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkOpticalFlowSessionCreateInfoNV structure containing
    ///     parameters specifying the creation of the optical flow session.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pSession">
    ///     pSession is a pointer to a VkOpticalFlowSessionNV handle specifying the optical flow session
    ///     object which will be created by this function when it returns VK_SUCCESS
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkOpticalFlowSessionCreateInfoNV* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkOpticalFlowSessionNV* /*pSession*/,
        VkResult> vkCreateOpticalFlowSessionNV = null;

    /// <summary>
    ///     vkDestroyOpticalFlowSessionNV - Destroy optical flow session object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyOpticalFlowSessionNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyOpticalFlowSessionNV.html</a>
    /// </summary>
    /// <param name="device">device is the device that was used for the creation of the optical flow session.</param>
    /// <param name="session">session is the optical flow session to be destroyed.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkOpticalFlowSessionNV /*session*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyOpticalFlowSessionNV = null;

    /// <summary>
    ///     vkBindOpticalFlowSessionImageNV - Bind image to an optical flow session -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindOpticalFlowSessionImageNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindOpticalFlowSessionImageNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device which owns the optical flow session object session.</param>
    /// <param name="session">session is the optical flow session object to which the image view is to be bound.</param>
    /// <param name="bindingPoint">
    ///     bindingPoint specifies the binding point VkOpticalFlowSessionBindingPointNV to which the
    ///     image view is bound.
    /// </param>
    /// <param name="view">view is a VkImageView to be bound.</param>
    /// <param name="layout"> VUID-vkBindOpticalFlowSessionImageNV-layout-parameter layout must be a valid VkImageLayout value</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkOpticalFlowSessionNV /*session*/,
        VkOpticalFlowSessionBindingPointNV /*bindingPoint*/,
        VkImageView /*view*/,
        VkImageLayout /*layout*/,
        VkResult> vkBindOpticalFlowSessionImageNV = null;

    /// <summary>
    ///     vkCmdOpticalFlowExecuteNV - Calculate optical flow vectors -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="session">session is the optical flow session object on which this command is operating.</param>
    /// <param name="pExecuteInfo">pExecuteInfo Info is a pointer to a VkOpticalFlowExecuteInfoNV.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkOpticalFlowSessionNV /*session*/,
        VkOpticalFlowExecuteInfoNV* /*pExecuteInfo*/,
        void> vkCmdOpticalFlowExecuteNV = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceOpticalFlowImageFormatsNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult>* pvkGetPhysicalDeviceOpticalFlowImageFormatsNV =
            &vkGetPhysicalDeviceOpticalFlowImageFormatsNV)
        {
            *pvkGetPhysicalDeviceOpticalFlowImageFormatsNV = (delegate*<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4f65\u7470\u6369\u6c61\u6c46\u776f\u6d49\u6761\u4665\u726f\u616d\u7374\u564e\u0000");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateOpticalFlowSessionNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyOpticalFlowSessionNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkBindOpticalFlowSessionImageNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdOpticalFlowExecuteNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult>* pvkCreateOpticalFlowSessionNV = &vkCreateOpticalFlowSessionNV)
        {
            *pvkCreateOpticalFlowSessionNV = (delegate*<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u704f\u6974\u6163\u466c\u6f6c\u5377\u7365\u6973\u6e6f\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void>* pvkDestroyOpticalFlowSessionNV = &vkDestroyOpticalFlowSessionNV)
        {
            *pvkDestroyOpticalFlowSessionNV = (delegate*<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void>)GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4f79\u7470\u6369\u6c61\u6c46\u776f\u6553\u7373\u6f69\u4e6e\u0056");
        }

        fixed (delegate*<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult>* pvkBindOpticalFlowSessionImageNV =
            &vkBindOpticalFlowSessionImageNV)
        {
            *pvkBindOpticalFlowSessionImageNV = (delegate*<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult>)GetVkFunction(
                device, "\u6b76\u6942\u646e\u704f\u6974\u6163\u466c\u6f6c\u5377\u7365\u6973\u6e6f\u6d49\u6761\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void>* pvkCmdOpticalFlowExecuteNV = &vkCmdOpticalFlowExecuteNV)
        {
            *pvkCmdOpticalFlowExecuteNV = (delegate*<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4f64\u7470\u6369\u6c61\u6c46\u776f\u7845\u6365\u7475\u4e65\u0056");
        }
    }
}