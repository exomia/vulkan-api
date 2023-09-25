#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Provisional.VkAmdxShaderEnqueue;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VK_AMDX_shader_enqueue - device extension (nr. 135) - author 'AMD' [platform 'provisional' | contact 'Tobias Hector
///     @tobski']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMDX_shader_enqueue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMDX_shader_enqueue.html</a>
/// </summary>
/// <remarks>
///     provisional: true
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2+VK_KHR_synchronization2+VK_KHR_pipeline_library+VK_KHR_spirv_1_4")]
[VkProvisional("true")]
[VkDeviceExt]
public static unsafe class VkAmdxShaderEnqueue
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME = "VK_AMDX_shader_enqueue";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME_UTF8_NT = "\u4b56\u415f\u444d\u5f58\u4853\u4441\u5245\u455f\u514e\u4555\u4555\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_SHADER_INDEX_UNUSED_AMDX - Sentinel for an unused shader index -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_INDEX_UNUSED_AMDX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_INDEX_UNUSED_AMDX.html</a>
    /// </summary>
    public const uint VK_SHADER_INDEX_UNUSED_AMDX = (~0U);

    /// <summary>
    ///     vkCreateExecutionGraphPipelinesAMDX - Creates a new execution graph pipeline object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateExecutionGraphPipelinesAMDX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateExecutionGraphPipelinesAMDX.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the execution graph pipelines.</param>
    /// <param name="pipelineCache">
    ///     pipelineCache is either VK_NULL_HANDLE, indicating that pipeline caching is disabled; or
    ///     the handle of a valid pipeline cache object, in which case use of that cache is enabled for the duration of the
    ///     command.
    /// </param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pPipelines arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkExecutionGraphPipelineCreateInfoAMDX structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelines">
    ///     pPipelines is a pointer to an array of VkPipeline handles in which the resulting execution
    ///     graph pipeline objects are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_PIPELINE_COMPILE_REQUIRED_EXT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineCache /*pipelineCache*/,
        uint /*createInfoCount*/,
        VkExecutionGraphPipelineCreateInfoAMDX* /*pCreateInfos*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkPipeline* /*pPipelines*/,
        VkResult> vkCreateExecutionGraphPipelinesAMDX = null;

    /// <summary>
    ///     vkGetExecutionGraphPipelineScratchSizeAMDX - Query scratch space required to dispatch an execution graph -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineScratchSizeAMDX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineScratchSizeAMDX.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the that executionGraph was created on.</param>
    /// <param name="executionGraph">executionGraph is the execution graph pipeline to query the scratch space for.</param>
    /// <param name="pSizeInfo">
    ///     pSizeInfo is a pointer to a VkExecutionGraphPipelineScratchSizeAMDX structure that will contain
    ///     the required scratch size.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*executionGraph*/,
        VkExecutionGraphPipelineScratchSizeAMDX* /*pSizeInfo*/,
        VkResult> vkGetExecutionGraphPipelineScratchSizeAMDX = null;

    /// <summary>
    ///     vkGetExecutionGraphPipelineNodeIndexAMDX - Query internal id of a node in an execution graph -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineNodeIndexAMDX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineNodeIndexAMDX.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the that executionGraph was created on.</param>
    /// <param name="executionGraph">executionGraph is the execution graph pipeline to query the internal node index for.</param>
    /// <param name="pNodeInfo">
    ///     pNodeInfo is a pointer to a VkPipelineShaderStageNodeCreateInfoAMDX structure identifying the
    ///     name and index of the node to query.
    /// </param>
    /// <param name="pNodeIndex">pNodeIndex is the returned internal node index of the identified node.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*executionGraph*/,
        VkPipelineShaderStageNodeCreateInfoAMDX* /*pNodeInfo*/,
        uint* /*pNodeIndex*/,
        VkResult> vkGetExecutionGraphPipelineNodeIndexAMDX = null;

    /// <summary>
    ///     vkCmdInitializeGraphScratchMemoryAMDX - Initialize scratch memory for an execution graph -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdInitializeGraphScratchMemoryAMDX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdInitializeGraphScratchMemoryAMDX.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="scratch">scratch is a pointer to the scratch memory to be initialized.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*scratch*/,
        void> vkCmdInitializeGraphScratchMemoryAMDX = null;

    /// <summary>
    ///     vkCmdDispatchGraphAMDX - Dispatch an execution graph -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphAMDX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphAMDX.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="scratch">scratch is a pointer to the scratch memory to be used.</param>
    /// <param name="pCountInfo">
    ///     pCountInfo is a host pointer to a VkDispatchGraphCountInfoAMDX structure defining the nodes
    ///     which will be initially executed.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*scratch*/,
        VkDispatchGraphCountInfoAMDX* /*pCountInfo*/,
        void> vkCmdDispatchGraphAMDX = null;

    /// <summary>
    ///     vkCmdDispatchGraphIndirectAMDX - Dispatch an execution graph with node and payload parameters read on the
    ///     device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectAMDX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectAMDX.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="scratch">scratch is a pointer to the scratch memory to be used.</param>
    /// <param name="pCountInfo">
    ///     pCountInfo is a host pointer to a VkDispatchGraphCountInfoAMDX structure defining the nodes
    ///     which will be initially executed.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*scratch*/,
        VkDispatchGraphCountInfoAMDX* /*pCountInfo*/,
        void> vkCmdDispatchGraphIndirectAMDX = null;

    /// <summary>
    ///     vkCmdDispatchGraphIndirectCountAMDX - Dispatch an execution graph with all parameters read on the device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectCountAMDX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectCountAMDX.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="scratch">scratch is a pointer to the scratch memory to be used.</param>
    /// <param name="countInfo">
    ///     countInfo is a device address of a VkDispatchGraphCountInfoAMDX structure defining the nodes
    ///     which will be initially executed.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*scratch*/,
        VkDeviceAddress /*countInfo*/,
        void> vkCmdDispatchGraphIndirectCountAMDX = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateExecutionGraphPipelinesAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetExecutionGraphPipelineScratchSizeAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetExecutionGraphPipelineNodeIndexAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdInitializeGraphScratchMemoryAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDispatchGraphAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDispatchGraphIndirectAMDX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDispatchGraphIndirectCountAMDX</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult>* pvkCreateExecutionGraphPipelinesAMDX =
            &vkCreateExecutionGraphPipelinesAMDX)
        {
            *pvkCreateExecutionGraphPipelinesAMDX = (delegate*<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult>)GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u7845\u6365\u7475\u6f69\u476e\u6172\u6870\u6950\u6570\u696c\u656e\u4173\u444d\u0058");
        }

        fixed (delegate*<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult>* pvkGetExecutionGraphPipelineScratchSizeAMDX = &vkGetExecutionGraphPipelineScratchSizeAMDX)
        {
            *pvkGetExecutionGraphPipelineScratchSizeAMDX = (delegate*<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4574\u6578\u7563\u6974\u6e6f\u7247\u7061\u5068\u7069\u6c65\u6e69\u5365\u7263\u7461\u6863\u6953\u657a\u4d41\u5844\u0000");
        }

        fixed (delegate*<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult>* pvkGetExecutionGraphPipelineNodeIndexAMDX = &vkGetExecutionGraphPipelineNodeIndexAMDX)
        {
            *pvkGetExecutionGraphPipelineNodeIndexAMDX = (delegate*<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4574\u6578\u7563\u6974\u6e6f\u7247\u7061\u5068\u7069\u6c65\u6e69\u4e65\u646f\u4965\u646e\u7865\u4d41\u5844\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, void>* pvkCmdInitializeGraphScratchMemoryAMDX = &vkCmdInitializeGraphScratchMemoryAMDX)
        {
            *pvkCmdInitializeGraphScratchMemoryAMDX = (delegate*<VkCommandBuffer, VkDeviceAddress, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4964\u696e\u6974\u6c61\u7a69\u4765\u6172\u6870\u6353\u6172\u6374\u4d68\u6d65\u726f\u4179\u444d\u0058");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, VkDispatchGraphCountInfoAMDX*, void>* pvkCmdDispatchGraphAMDX = &vkCmdDispatchGraphAMDX)
        {
            *pvkCmdDispatchGraphAMDX = (delegate*<VkCommandBuffer, VkDeviceAddress, VkDispatchGraphCountInfoAMDX*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u7369\u6170\u6374\u4768\u6172\u6870\u4d41\u5844\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, VkDispatchGraphCountInfoAMDX*, void>* pvkCmdDispatchGraphIndirectAMDX = &vkCmdDispatchGraphIndirectAMDX)
        {
            *pvkCmdDispatchGraphIndirectAMDX = (delegate*<VkCommandBuffer, VkDeviceAddress, VkDispatchGraphCountInfoAMDX*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u7369\u6170\u6374\u4768\u6172\u6870\u6e49\u6964\u6572\u7463\u4d41\u5844\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, void>* pvkCmdDispatchGraphIndirectCountAMDX = &vkCmdDispatchGraphIndirectCountAMDX)
        {
            *pvkCmdDispatchGraphIndirectCountAMDX = (delegate*<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u7369\u6170\u6374\u4768\u6172\u6870\u6e49\u6964\u6572\u7463\u6f43\u6e75\u4174\u444d\u0058");
        }
    }
}