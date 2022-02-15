#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkIntelPerformanceQuery;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_INTEL_performance_query - device extension (nr. 211) - author 'INTEL' [platform '' | contact 'Lionel Landwerlin
///     @llandwerlin']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_INTEL_performance_query.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_INTEL_performance_query.html</a>
/// </summary>
/// <remarks>
///     specialuse: devtools
/// </remarks>
[VkSpecialuse("devtools")]
public static unsafe class VkIntelPerformanceQuery
{
    /// <summary> The spec version. </summary>
    public const uint VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME = "VK_INTEL_performance_query";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u495f\u544e\u4c45\u505f\u5245\u4f46\u4d52\u4e41\u4543\u515f\u4555\u5952\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkInitializePerformanceApiINTEL - Initialize a device for performance queries -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkInitializePerformanceApiINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkInitializePerformanceApiINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device used for the queries.</param>
    /// <param name="pInitializeInfo">
    ///     pInitializeInfo is a pointer to a VkInitializePerformanceApiInfoINTEL structure
    ///     specifying initialization parameters.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkInitializePerformanceApiInfoINTEL* /*pInitializeInfo*/,
        VkResult> vkInitializePerformanceApiINTEL = null;

    /// <summary>
    ///     vkUninitializePerformanceApiINTEL - Uninitialize a device for performance queries -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUninitializePerformanceApiINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUninitializePerformanceApiINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device used for the queries.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        void> vkUninitializePerformanceApiINTEL = null;

    /// <summary>
    ///     vkCmdSetPerformanceMarkerINTEL - Markers -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceMarkerINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceMarkerINTEL.html</a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     VUID-vkCmdSetPerformanceMarkerINTEL-commandBuffer-parameter commandBuffer must be a valid
    ///     VkCommandBuffer handle
    /// </param>
    /// <param name="pMarkerInfo">
    ///     VUID-vkCmdSetPerformanceMarkerINTEL-pMarkerInfo-parameter pMarkerInfo must be a valid
    ///     pointer to a valid VkPerformanceMarkerInfoINTEL structure
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPerformanceMarkerInfoINTEL* /*pMarkerInfo*/,
        VkResult> vkCmdSetPerformanceMarkerINTEL = null;

    /// <summary>
    ///     vkCmdSetPerformanceStreamMarkerINTEL - Markers -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceStreamMarkerINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceStreamMarkerINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">
    ///     VUID-vkCmdSetPerformanceStreamMarkerINTEL-commandBuffer-parameter commandBuffer must be a
    ///     valid VkCommandBuffer handle
    /// </param>
    /// <param name="pMarkerInfo">
    ///     VUID-vkCmdSetPerformanceStreamMarkerINTEL-pMarkerInfo-parameter pMarkerInfo must be a valid
    ///     pointer to a valid VkPerformanceStreamMarkerInfoINTEL structure
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPerformanceStreamMarkerInfoINTEL* /*pMarkerInfo*/,
        VkResult> vkCmdSetPerformanceStreamMarkerINTEL = null;

    /// <summary>
    ///     vkCmdSetPerformanceOverrideINTEL - Performance override settings -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceOverrideINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceOverrideINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer where the override takes place.</param>
    /// <param name="pOverrideInfo">
    ///     pOverrideInfo is a pointer to a VkPerformanceOverrideInfoINTEL structure selecting the
    ///     parameter to override.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPerformanceOverrideInfoINTEL* /*pOverrideInfo*/,
        VkResult> vkCmdSetPerformanceOverrideINTEL = null;

    /// <summary>
    ///     vkAcquirePerformanceConfigurationINTEL - Acquire the performance query capability -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquirePerformanceConfigurationINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquirePerformanceConfigurationINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that the performance query commands will be submitted to.</param>
    /// <param name="pAcquireInfo">
    ///     pAcquireInfo is a pointer to a VkPerformanceConfigurationAcquireInfoINTEL structure,
    ///     specifying the performance configuration to acquire.
    /// </param>
    /// <param name="pConfiguration">
    ///     pConfiguration is a pointer to a VkPerformanceConfigurationINTEL handle in which the
    ///     resulting configuration object is returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPerformanceConfigurationAcquireInfoINTEL* /*pAcquireInfo*/,
        VkPerformanceConfigurationINTEL* /*pConfiguration*/,
        VkResult> vkAcquirePerformanceConfigurationINTEL = null;

    /// <summary>
    ///     vkReleasePerformanceConfigurationINTEL - Release a configuration to capture performance data -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleasePerformanceConfigurationINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleasePerformanceConfigurationINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device associated to the configuration object to release.</param>
    /// <param name="configuration">configuration is the configuration object to release.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPerformanceConfigurationINTEL /*configuration*/,
        VkResult> vkReleasePerformanceConfigurationINTEL = null;

    /// <summary>
    ///     vkQueueSetPerformanceConfigurationINTEL - Set a performance query -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSetPerformanceConfigurationINTEL.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSetPerformanceConfigurationINTEL.html
    ///     </a>
    /// </summary>
    /// <param name="queue">queue is the queue on which the configuration will be used.</param>
    /// <param name="configuration">configuration is the configuration to use.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkQueue /*queue*/,
        VkPerformanceConfigurationINTEL /*configuration*/,
        VkResult> vkQueueSetPerformanceConfigurationINTEL = null;

    /// <summary>
    ///     vkGetPerformanceParameterINTEL - Query performance capabilities of the device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPerformanceParameterINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPerformanceParameterINTEL.html</a>
    /// </summary>
    /// <param name="device">device is the logical device to query.</param>
    /// <param name="parameter">parameter is the parameter to query.</param>
    /// <param name="pValue">
    ///     pValue is a pointer to a VkPerformanceValueINTEL structure in which the type and value of the
    ///     parameter are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_TOO_MANY_OBJECTS,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPerformanceParameterTypeINTEL /*parameter*/,
        VkPerformanceValueINTEL* /*pValue*/,
        VkResult> vkGetPerformanceParameterINTEL = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkInitializePerformanceApiINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkUninitializePerformanceApiINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPerformanceMarkerINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPerformanceStreamMarkerINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPerformanceOverrideINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkAcquirePerformanceConfigurationINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkReleasePerformanceConfigurationINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkQueueSetPerformanceConfigurationINTEL</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPerformanceParameterINTEL</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>* pvkInitializePerformanceApiINTEL = &vkInitializePerformanceApiINTEL)
        {
            *pvkInitializePerformanceApiINTEL = (delegate*<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6e49\u7469\u6169\u696c\u657a\u6550\u6672\u726f\u616d\u636e\u4165\u6970\u4e49\u4554\u004c");
        }

        fixed (delegate*<VkDevice, void>* pvkUninitializePerformanceApiINTEL = &vkUninitializePerformanceApiINTEL)
        {
            *pvkUninitializePerformanceApiINTEL = (delegate*<VkDevice, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6e55\u6e69\u7469\u6169\u696c\u657a\u6550\u6672\u726f\u616d\u636e\u4165\u6970\u4e49\u4554\u004c");
        }

        fixed (delegate*<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>* pvkCmdSetPerformanceMarkerINTEL = &vkCmdSetPerformanceMarkerINTEL)
        {
            *pvkCmdSetPerformanceMarkerINTEL = (delegate*<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6550\u6672\u726f\u616d\u636e\u4d65\u7261\u656b\u4972\u544e\u4c45\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>* pvkCmdSetPerformanceStreamMarkerINTEL = &vkCmdSetPerformanceStreamMarkerINTEL)
        {
            *pvkCmdSetPerformanceStreamMarkerINTEL = (delegate*<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6550\u6672\u726f\u616d\u636e\u5365\u7274\u6165\u4d6d\u7261\u656b\u4972\u544e\u4c45\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>* pvkCmdSetPerformanceOverrideINTEL = &vkCmdSetPerformanceOverrideINTEL)
        {
            *pvkCmdSetPerformanceOverrideINTEL = (delegate*<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6550\u6672\u726f\u616d\u636e\u4f65\u6576\u7272\u6469\u4965\u544e\u4c45\u0000");
        }

        fixed (delegate*<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult>* pvkAcquirePerformanceConfigurationINTEL =
                   &vkAcquirePerformanceConfigurationINTEL)
        {
            *pvkAcquirePerformanceConfigurationINTEL = (delegate*<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u5065\u7265\u6f66\u6d72\u6e61\u6563\u6f43\u666e\u6769\u7275\u7461\u6f69\u496e\u544e\u4c45\u0000");
        }

        fixed (delegate*<VkDevice, VkPerformanceConfigurationINTEL, VkResult>* pvkReleasePerformanceConfigurationINTEL = &vkReleasePerformanceConfigurationINTEL)
        {
            *pvkReleasePerformanceConfigurationINTEL = (delegate*<VkDevice, VkPerformanceConfigurationINTEL, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6552\u656c\u7361\u5065\u7265\u6f66\u6d72\u6e61\u6563\u6f43\u666e\u6769\u7275\u7461\u6f69\u496e\u544e\u4c45\u0000");
        }

        fixed (delegate*<VkQueue, VkPerformanceConfigurationINTEL, VkResult>* pvkQueueSetPerformanceConfigurationINTEL = &vkQueueSetPerformanceConfigurationINTEL)
        {
            *pvkQueueSetPerformanceConfigurationINTEL = (delegate*<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7551\u7565\u5365\u7465\u6550\u6672\u726f\u616d\u636e\u4365\u6e6f\u6966\u7567\u6172\u6974\u6e6f\u4e49\u4554\u004c");
        }

        fixed (delegate*<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult>* pvkGetPerformanceParameterINTEL = &vkGetPerformanceParameterINTEL)
        {
            *pvkGetPerformanceParameterINTEL = (delegate*<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5074\u7265\u6f66\u6d72\u6e61\u6563\u6150\u6172\u656d\u6574\u4972\u544e\u4c45\u0000");
        }
    }
}