#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrFragmentShadingRate;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_fragment_shading_rate - device extension (nr. 227) - author 'KHR' [platform '' | contact 'Tobias Hector
///     @tobski']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_fragment_shading_rate.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_fragment_shading_rate.html</a>
/// </summary>
[VkRequires("VK_KHR_create_renderpass2,VK_KHR_get_physical_device_properties2")]
public static unsafe class VkKhrFragmentShadingRate
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME = "VK_KHR_fragment_shading_rate";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u465f\u4152\u4d47\u4e45\u5f54\u4853\u4441\u4e49\u5f47\u4152\u4554\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceFragmentShadingRatesKHR - Get available shading rates for a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFragmentShadingRatesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFragmentShadingRatesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device whose properties will be queried.</param>
    /// <param name="pFragmentShadingRateCount">
    ///     pFragmentShadingRateCount is a pointer to an integer related to the number of
    ///     fragment shading rates available or queried, as described below.
    /// </param>
    /// <param name="pFragmentShadingRates">
    ///     pFragmentShadingRates is either NULL or a pointer to an array of
    ///     VkPhysicalDeviceFragmentShadingRateKHR structures.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pFragmentShadingRateCount*/,
        VkPhysicalDeviceFragmentShadingRateKHR* /*pFragmentShadingRates*/,
        VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR = null;

    /// <summary>
    ///     vkCmdSetFragmentShadingRateKHR - Set pipeline fragment shading rate and combiner operation dynamically for a
    ///     command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pFragmentSize">pFragmentSize specifies the pipeline fragment shading rate for subsequent drawing commands.</param>
    /// <param name="combinerOps">
    ///     combinerOps specifies a VkFragmentShadingRateCombinerOpKHRdetermining how the pipeline,
    ///     primitive, and attachment shading ratesare combined for fragments generated by subsequent drawing commands.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkExtent2D* /*pFragmentSize*/,
        VkArray2<VkFragmentShadingRateCombinerOpKHR> /*combinerOps*/,
        void> vkCmdSetFragmentShadingRateKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceFragmentShadingRatesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>* pvkGetPhysicalDeviceFragmentShadingRatesKHR = &vkGetPhysicalDeviceFragmentShadingRatesKHR)
        {
            *pvkGetPhysicalDeviceFragmentShadingRatesKHR = (delegate*<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4665\u6172\u6d67\u6e65\u5374\u6168\u6964\u676e\u6152\u6574\u4b73\u5248\u0000");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetFragmentShadingRateKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkExtent2D*, VkArray2<VkFragmentShadingRateCombinerOpKHR>, void>* pvkCmdSetFragmentShadingRateKHR = &vkCmdSetFragmentShadingRateKHR)
        {
            *pvkCmdSetFragmentShadingRateKHR = (delegate*<VkCommandBuffer, VkExtent2D*, VkArray2<VkFragmentShadingRateCombinerOpKHR>, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7246\u6761\u656d\u746e\u6853\u6461\u6e69\u5267\u7461\u4b65\u5248\u0000");
        }
    }
}