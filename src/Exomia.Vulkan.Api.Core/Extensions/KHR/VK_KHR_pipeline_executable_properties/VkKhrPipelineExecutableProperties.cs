#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrPipelineExecutableProperties;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_pipeline_executable_properties - device extension (nr. 270) - author 'KHR' [platform '' | contact 'Jason Ekstrand @jekstrand']
///     <br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_pipeline_executable_properties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_pipeline_executable_properties.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: devtools
/// </remarks>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[VkSpecialuse("devtools")]
public static unsafe class VkKhrPipelineExecutableProperties
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME = "VK_KHR_pipeline_executable_properties";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u505f\u5049\u4c45\u4e49\u5f45\u5845\u4345\u5455\u4241\u454c\u505f\u4f52\u4550\u5452\u4549\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPipelineExecutablePropertiesKHR - Get the executables associated with a pipeline -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutablePropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutablePropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the device that created the pipeline. </param>
    /// <param name="pPipelineInfo"> pPipelineInfo describes the pipeline being queried. </param>
    /// <param name="pExecutableCount"> pExecutableCount is a pointer to an integer related to the number of pipeline executables available or queried, as described below. </param>
    /// <param name="pProperties"> pProperties is either NULL or a pointer to an array of VkPipelineExecutablePropertiesKHR structures. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineInfoKHR* /*pPipelineInfo*/,
        uint* /*pExecutableCount*/,
        VkPipelineExecutablePropertiesKHR* /*pProperties*/,
        VkResult> vkGetPipelineExecutablePropertiesKHR = null;

    /// <summary>
    ///     vkGetPipelineExecutableStatisticsKHR - Get compile time statistics associated with a pipeline executable -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableStatisticsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableStatisticsKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the device that created the pipeline. </param>
    /// <param name="pExecutableInfo"> pExecutableInfo describes the pipeline executable being queried. </param>
    /// <param name="pStatisticCount"> pStatisticCount is a pointer to an integer related to the number of statistics available or queried, as described below. </param>
    /// <param name="pStatistics"> pStatistics is either NULL or a pointer to an array of VkPipelineExecutableStatisticKHR structures. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineExecutableInfoKHR* /*pExecutableInfo*/,
        uint* /*pStatisticCount*/,
        VkPipelineExecutableStatisticKHR* /*pStatistics*/,
        VkResult> vkGetPipelineExecutableStatisticsKHR = null;

    /// <summary>
    ///     vkGetPipelineExecutableInternalRepresentationsKHR - Get internal representations of the pipeline executable -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableInternalRepresentationsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableInternalRepresentationsKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device"> device is the device that created the pipeline. </param>
    /// <param name="pExecutableInfo"> pExecutableInfo describes the pipeline executable being queried. </param>
    /// <param name="pInternalRepresentationCount"> pInternalRepresentationCount is a pointer to an integer related to the number of internal representations available or queried, as described below. </param>
    /// <param name="pInternalRepresentations"> pInternalRepresentations is either NULL or a pointer to an array of VkPipelineExecutableInternalRepresentationKHR structures. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS,VK_INCOMPLETE </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineExecutableInfoKHR* /*pExecutableInfo*/,
        uint* /*pInternalRepresentationCount*/,
        VkPipelineExecutableInternalRepresentationKHR* /*pInternalRepresentations*/,
        VkResult> vkGetPipelineExecutableInternalRepresentationsKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkGetPipelineExecutablePropertiesKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetPipelineExecutableStatisticsKHR </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetPipelineExecutableInternalRepresentationsKHR </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult>* pvkGetPipelineExecutablePropertiesKHR = &vkGetPipelineExecutablePropertiesKHR)
        {
            *pvkGetPipelineExecutablePropertiesKHR = (delegate*<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4565\u6578\u7563\u6174\u6c62\u5065\u6f72\u6570\u7472\u6569\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult>* pvkGetPipelineExecutableStatisticsKHR = &vkGetPipelineExecutableStatisticsKHR)
        {
            *pvkGetPipelineExecutableStatisticsKHR = (delegate*<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4565\u6578\u7563\u6174\u6c62\u5365\u6174\u6974\u7473\u6369\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult>* pvkGetPipelineExecutableInternalRepresentationsKHR =
            &vkGetPipelineExecutableInternalRepresentationsKHR)
        {
            *pvkGetPipelineExecutableInternalRepresentationsKHR = (delegate*<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7069\u6c65\u6e69\u4565\u6578\u7563\u6174\u6c62\u4965\u746e\u7265\u616e\u526c\u7065\u6572\u6573\u746e\u7461\u6f69\u736e\u484b\u0052");
        }
    }
}