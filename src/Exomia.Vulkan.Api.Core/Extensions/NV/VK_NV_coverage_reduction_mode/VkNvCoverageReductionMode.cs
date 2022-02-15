#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvCoverageReductionMode;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_coverage_reduction_mode - device extension (nr. 251) - author 'NV' [platform '' | contact 'Kedarnath Thangudu
///     @kthangudu']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_coverage_reduction_mode.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_coverage_reduction_mode.html</a>
/// </summary>
[VkRequires("VK_NV_framebuffer_mixed_samples")]
public static unsafe class VkNvCoverageReductionMode
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME = "VK_NV_coverage_reduction_mode";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4f43\u4556\u4152\u4547\u525f\u4445\u4355\u4954\u4e4f\u4d5f\u444f\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV - Query supported sample count combinations -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the set of combinations.</param>
    /// <param name="pCombinationCount">
    ///     pCombinationCount is a pointer to an integer related to the number of combinations
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pCombinations">
    ///     pCombinations is either NULL or a pointer to an array of
    ///     VkFramebufferMixedSamplesCombinationNV values, indicating the supported combinations of coverage reduction mode,
    ///     rasterization samples, and color, depth, stencil attachment sample counts.
    /// </param>
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
        VkPhysicalDevice /*physicalDevice*/,
        uint* /*pCombinationCount*/,
        VkFramebufferMixedSamplesCombinationNV* /*pCombinations*/,
        VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult>* pvkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV =
                   &vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV)
        {
            *pvkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = (delegate*<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult>)Core.Vk.GetVkFunction(
                instance,
                "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7075\u6f70\u7472\u6465\u7246\u6d61\u6265\u6675\u6566\u4d72\u7869\u6465\u6153\u706d\u656c\u4373\u6d6f\u6962\u616e\u6974\u6e6f\u4e73\u0056");
        }
    }
}