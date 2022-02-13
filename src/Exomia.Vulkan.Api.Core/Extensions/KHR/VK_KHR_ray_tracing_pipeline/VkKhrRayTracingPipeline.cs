#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_ray_tracing_pipeline - device extension (nr. 348) - author 'KHR' [platform '' | contact 'Daniel Koch
///     @dgkoch']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_pipeline.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_pipeline.html</a>
/// </summary>
[VkRequires("VK_KHR_spirv_1_4,VK_KHR_acceleration_structure")]
public static unsafe class VkKhrRayTracingPipeline
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME = "VK_KHR_ray_tracing_pipeline";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u525f\u5941\u545f\u4152\u4943\u474e\u505f\u5049\u4c45\u4e49\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     VK_SHADER_UNUSED_KHR - Sentinel for an unused shader index -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_UNUSED_KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_UNUSED_KHR.html</a>
    /// </summary>
    public const uint VK_SHADER_UNUSED_KHR = (~0U);

    /// <summary>
    ///     vkCmdTraceRaysKHR - Initialize a ray tracing dispatch -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pRaygenShaderBindingTable">
    ///     pRaygenShaderBindingTable is a VkStridedDeviceAddressRegionKHR that holds the
    ///     shader binding table data for the ray generation shader stage.
    /// </param>
    /// <param name="pMissShaderBindingTable">
    ///     pMissShaderBindingTable is a VkStridedDeviceAddressRegionKHRthat holds the shader
    ///     binding table data for the miss shader stage.
    /// </param>
    /// <param name="pHitShaderBindingTable">
    ///     pHitShaderBindingTable is a VkStridedDeviceAddressRegionKHRthat holds the shader
    ///     binding table data for the hit shader stage.
    /// </param>
    /// <param name="pCallableShaderBindingTable">
    ///     pCallableShaderBindingTable is a VkStridedDeviceAddressRegionKHR that holds
    ///     the shader binding table data for the callable shader stage.
    /// </param>
    /// <param name="width">width is the width of the ray trace query dimensions.</param>
    /// <param name="height">height is height of the ray trace query dimensions.</param>
    /// <param name="depth">depth is depth of the ray trace query dimensions.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkStridedDeviceAddressRegionKHR* /*pRaygenShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pMissShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pHitShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pCallableShaderBindingTable*/,
        uint /*width*/,
        uint /*height*/,
        uint /*depth*/,
        void> vkCmdTraceRaysKHR = null;

    /// <summary>
    ///     vkCreateRayTracingPipelinesKHR - Creates a new ray tracing pipeline object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesKHR.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the ray tracing pipelines.</param>
    /// <param name="deferredOperation">
    ///     deferredOperation is VK_NULL_HANDLE or the handle of a valid VkDeferredOperationKHR
    ///     request deferral object for this command.
    /// </param>
    /// <param name="pipelineCache">
    ///     pipelineCache is either VK_NULL_HANDLE, indicating that pipeline caching is disabled, or
    ///     the handle of a valid pipeline cache object, in which case use of that cache is enabled for the duration of the
    ///     command.
    /// </param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pPipelines arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkRayTracingPipelineCreateInfoKHR structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelines">
    ///     pPipelines is a pointer to an array in which the resulting ray tracing pipeline objects are
    ///     returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term>
    ///             <description>VK_SUCCESS,VK_OPERATION_DEFERRED_KHR,VK_OPERATION_NOT_DEFERRED_KHR,VK_PIPELINE_COMPILE_REQUIRED_EXT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeferredOperationKHR /*deferredOperation*/,
        VkPipelineCache /*pipelineCache*/,
        uint /*createInfoCount*/,
        VkRayTracingPipelineCreateInfoKHR* /*pCreateInfos*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkPipeline* /*pPipelines*/,
        VkResult> vkCreateRayTracingPipelinesKHR = null;

    /// <summary>
    ///     vkGetRayTracingShaderGroupHandlesKHR - Query ray tracing pipeline shader group handles -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device containing the ray tracing pipeline.</param>
    /// <param name="pipeline">pipeline is the ray tracing pipeline object containing the shaders.</param>
    /// <param name="firstGroup">
    ///     firstGroup is the index of the first group to retrieve a handle     for from the
    ///     VkRayTracingPipelineCreateInfoKHR::pGroupsor VkRayTracingPipelineCreateInfoNV::pGroups    array.
    /// </param>
    /// <param name="groupCount">groupCount is the number of shader handles to retrieve.</param>
    /// <param name="dataSize">dataSize is the size in bytes of the buffer pointed to by pData.</param>
    /// <param name="pData">pData is a pointer to a user-allocated buffer where the results will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*pipeline*/,
        uint /*firstGroup*/,
        uint /*groupCount*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        VkResult> vkGetRayTracingShaderGroupHandlesKHR = null;

    /// <summary>
    ///     vkGetRayTracingCaptureReplayShaderGroupHandlesKHR - Query ray tracing capture replay pipeline shader group handles
    ///     -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingCaptureReplayShaderGroupHandlesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingCaptureReplayShaderGroupHandlesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device containing the ray tracing pipeline.</param>
    /// <param name="pipeline">pipeline is the ray tracing pipeline object containing the shaders.</param>
    /// <param name="firstGroup">
    ///     firstGroup is the index of the first group to retrieve a handle for from the
    ///     VkRayTracingPipelineCreateInfoKHR::pGroupsarray.
    /// </param>
    /// <param name="groupCount">groupCount is the number of shader handles to retrieve.</param>
    /// <param name="dataSize">dataSize is the size in bytes of the buffer pointed to by pData.</param>
    /// <param name="pData">pData is a pointer to a user-allocated buffer where the results will be written.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*pipeline*/,
        uint /*firstGroup*/,
        uint /*groupCount*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR = null;

    /// <summary>
    ///     vkCmdTraceRaysIndirectKHR - Initialize an indirect ray tracing dispatch -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pRaygenShaderBindingTable">
    ///     pRaygenShaderBindingTable is a VkStridedDeviceAddressRegionKHR that holds the
    ///     shader binding table data for the ray generation shader stage.
    /// </param>
    /// <param name="pMissShaderBindingTable">
    ///     pMissShaderBindingTable is a VkStridedDeviceAddressRegionKHRthat holds the shader
    ///     binding table data for the miss shader stage.
    /// </param>
    /// <param name="pHitShaderBindingTable">
    ///     pHitShaderBindingTable is a VkStridedDeviceAddressRegionKHRthat holds the shader
    ///     binding table data for the hit shader stage.
    /// </param>
    /// <param name="pCallableShaderBindingTable">
    ///     pCallableShaderBindingTable is a VkStridedDeviceAddressRegionKHR that holds
    ///     the shader binding table data for the callable shader stage.
    /// </param>
    /// <param name="indirectDeviceAddress">
    ///     indirectDeviceAddress is a buffer device address which is a pointer to a
    ///     VkTraceRaysIndirectCommandKHR structure containing the trace ray parameters.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkStridedDeviceAddressRegionKHR* /*pRaygenShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pMissShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pHitShaderBindingTable*/,
        VkStridedDeviceAddressRegionKHR* /*pCallableShaderBindingTable*/,
        VkDeviceAddress /*indirectDeviceAddress*/,
        void> vkCmdTraceRaysIndirectKHR = null;

    /// <summary>
    ///     vkGetRayTracingShaderGroupStackSizeKHR - Query ray tracing pipeline shader group shader stack size -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupStackSizeKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupStackSizeKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device containing the ray tracing pipeline.</param>
    /// <param name="pipeline">pipeline is the ray tracing pipeline object containing the shaders groups.</param>
    /// <param name="group">group is the index of the shader group to query.</param>
    /// <param name="groupShader">groupShader is the type of shader from the group to query.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*pipeline*/,
        uint /*group*/,
        VkShaderGroupShaderKHR /*groupShader*/,
        VkDeviceSize> vkGetRayTracingShaderGroupStackSizeKHR = null;

    /// <summary>
    ///     vkCmdSetRayTracingPipelineStackSizeKHR - Set the stack size dynamically for a ray tracing pipeline -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRayTracingPipelineStackSizeKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRayTracingPipelineStackSizeKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pipelineStackSize">pipelineStackSize is the stack size to use for subsequent ray tracing trace commands.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*pipelineStackSize*/,
        void> vkCmdSetRayTracingPipelineStackSizeKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void
               >* pvkCmdTraceRaysKHR = &vkCmdTraceRaysKHR)
        {
            *pvkCmdTraceRaysKHR =
                (delegate*<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint,
                    void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5464\u6172\u6563\u6152\u7379\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult>* pvkCreateRayTracingPipelinesKHR =
                   &vkCreateRayTracingPipelinesKHR)
        {
            *pvkCreateRayTracingPipelinesKHR =
                (delegate*<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult>)Core.Vk.GetVkFunction(
                    device, "\u6b76\u7243\u6165\u6574\u6152\u5479\u6172\u6963\u676e\u6950\u6570\u696c\u656e\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>* pvkGetRayTracingShaderGroupHandlesKHR = &vkGetRayTracingShaderGroupHandlesKHR)
        {
            *pvkGetRayTracingShaderGroupHandlesKHR = (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5274\u7961\u7254\u6361\u6e69\u5367\u6168\u6564\u4772\u6f72\u7075\u6148\u646e\u656c\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>* pvkGetRayTracingCaptureReplayShaderGroupHandlesKHR = &vkGetRayTracingCaptureReplayShaderGroupHandlesKHR)
        {
            *pvkGetRayTracingCaptureReplayShaderGroupHandlesKHR = (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5274\u7961\u7254\u6361\u6e69\u4367\u7061\u7574\u6572\u6552\u6c70\u7961\u6853\u6461\u7265\u7247\u756f\u4870\u6e61\u6c64\u7365\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void>
               * pvkCmdTraceRaysIndirectKHR = &vkCmdTraceRaysIndirectKHR)
        {
            *pvkCmdTraceRaysIndirectKHR =
                (delegate*<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkDeviceAddress,
                    void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5464\u6172\u6563\u6152\u7379\u6e49\u6964\u6572\u7463\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, VkDeviceSize>* pvkGetRayTracingShaderGroupStackSizeKHR = &vkGetRayTracingShaderGroupStackSizeKHR)
        {
            *pvkGetRayTracingShaderGroupStackSizeKHR = (delegate*<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, VkDeviceSize>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5274\u7961\u7254\u6361\u6e69\u5367\u6168\u6564\u4772\u6f72\u7075\u7453\u6361\u536b\u7a69\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetRayTracingPipelineStackSizeKHR = &vkCmdSetRayTracingPipelineStackSizeKHR)
        {
            *pvkCmdSetRayTracingPipelineStackSizeKHR = (delegate*<VkCommandBuffer, uint, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6152\u5479\u6172\u6963\u676e\u6950\u6570\u696c\u656e\u7453\u6361\u536b\u7a69\u4b65\u5248\u0000");
        }
    }
}