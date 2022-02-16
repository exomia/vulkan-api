#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvRayTracing;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_ray_tracing - device extension (nr. 166) - author 'NV' [platform '' | contact 'Eric Werness @ewerness-nv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_ray_tracing.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_ray_tracing.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_get_memory_requirements2")]
public static unsafe class VkNvRayTracing
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_RAY_TRACING_SPEC_VERSION = 3;

    /// <summary> The extension name. </summary>
    public const string VK_NV_RAY_TRACING_EXTENSION_NAME = "VK_NV_ray_tracing";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_RAY_TRACING_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_RAY_TRACING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_RAY_TRACING_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4152\u5f59\u5254\u4341\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     VK_SHADER_UNUSED_KHR - Sentinel for an unused shader index -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_UNUSED_KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SHADER_UNUSED_KHR.html</a>
    /// </summary>
    /// <remarks> VK_SHADER_UNUSED_NV alias for VK_SHADER_UNUSED_NV. </remarks>
    public const uint VK_SHADER_UNUSED_NV = VK_SHADER_UNUSED_KHR;

    /// <summary>
    ///     vkCreateAccelerationStructureNV - Create a new acceleration structure object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the buffer object.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkAccelerationStructureCreateInfoNV structure containing
    ///     parameters affecting creation of the acceleration structure.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pAccelerationStructure">
    ///     pAccelerationStructure is a pointer to a VkAccelerationStructureNV handle in which
    ///     the resulting acceleration structure object is returned.
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
        VkAccelerationStructureCreateInfoNV* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkAccelerationStructureNV* /*pAccelerationStructure*/,
        VkResult> vkCreateAccelerationStructureNV = null;

    /// <summary>
    ///     vkDestroyAccelerationStructureNV - Destroy an acceleration structure object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the buffer.</param>
    /// <param name="accelerationStructure">accelerationStructure is the acceleration structure to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureNV /*accelerationStructure*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyAccelerationStructureNV = null;

    /// <summary>
    ///     vkGetAccelerationStructureMemoryRequirementsNV - Get acceleration structure memory requirements -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureMemoryRequirementsNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureMemoryRequirementsNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device on which the acceleration structure was created.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkAccelerationStructureMemoryRequirementsInfoNV structure specifying the
    ///     acceleration structure to get memory requirements for.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2KHR structure in which the
    ///     requested acceleration structure memory requirements are returned.
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAccelerationStructureMemoryRequirementsInfoNV* /*pInfo*/,
        VkMemoryRequirements2KHR* /*pMemoryRequirements*/,
        void> vkGetAccelerationStructureMemoryRequirementsNV = null;

    /// <summary>
    ///     vkBindAccelerationStructureMemoryNV - Bind acceleration structure memory -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindAccelerationStructureMemoryNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindAccelerationStructureMemoryNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the acceleration structures and memory.</param>
    /// <param name="bindInfoCount">bindInfoCount is the number of elements in pBindInfos.</param>
    /// <param name="pBindInfos">
    ///     pBindInfos is a pointer to an array of VkBindAccelerationStructureMemoryInfoNV structures
    ///     describing acceleration structures and memory to bind.
    /// </param>
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
        uint /*bindInfoCount*/,
        VkBindAccelerationStructureMemoryInfoNV* /*pBindInfos*/,
        VkResult> vkBindAccelerationStructureMemoryNV = null;

    /// <summary>
    ///     vkCmdBuildAccelerationStructureNV - Build an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pInfo">pInfo contains the shared information for the acceleration structure&#8217;s structure.</param>
    /// <param name="instanceData">
    ///     instanceData is the buffer containing an array of VkAccelerationStructureInstanceKHR
    ///     structures defining acceleration structures. This parameter must be NULL for bottom level acceleration structures.
    /// </param>
    /// <param name="instanceOffset">
    ///     instanceOffset is the offset in bytes (relative to the start of instanceData) at which the
    ///     instance data is located.
    /// </param>
    /// <param name="update">update specifies whether to update the dst acceleration structure with the data in src.</param>
    /// <param name="dst">dst is a pointer to the target acceleration structure for the build.</param>
    /// <param name="src">
    ///     src is a pointer to an existing acceleration structure that is to be used to update the dst
    ///     acceleration structure.
    /// </param>
    /// <param name="scratch">scratch is the VkBuffer that will be used as scratch memory for the build.</param>
    /// <param name="scratchOffset">
    ///     scratchOffset is the offset in bytes relative to the start of scratch that will be used as
    ///     a scratch memory.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkAccelerationStructureInfoNV* /*pInfo*/,
        VkBuffer /*instanceData*/,
        VkDeviceSize /*instanceOffset*/,
        VkBool32 /*update*/,
        VkAccelerationStructureNV /*dst*/,
        VkAccelerationStructureNV /*src*/,
        VkBuffer /*scratch*/,
        VkDeviceSize /*scratchOffset*/,
        void> vkCmdBuildAccelerationStructureNV = null;

    /// <summary>
    ///     vkCmdCopyAccelerationStructureNV - Copy an acceleration structure -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="dst">dst is the target acceleration structure for the copy.</param>
    /// <param name="src">src is the source acceleration structure for the copy.</param>
    /// <param name="mode">
    ///     mode is a VkCopyAccelerationStructureModeKHR value specifying additional operations to perform
    ///     during the copy.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkAccelerationStructureNV /*dst*/,
        VkAccelerationStructureNV /*src*/,
        VkCopyAccelerationStructureModeKHR /*mode*/,
        void> vkCmdCopyAccelerationStructureNV = null;

    /// <summary>
    ///     vkCmdTraceRaysNV - Initialize a ray tracing dispatch -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="raygenShaderBindingTableBuffer">
    ///     raygenShaderBindingTableBuffer is the buffer object that holds the shader
    ///     binding table data for the ray generation shader stage.
    /// </param>
    /// <param name="raygenShaderBindingOffset">
    ///     raygenShaderBindingOffset is the offset in bytes (relative to
    ///     raygenShaderBindingTableBuffer) of the ray generation shader being used for the trace.
    /// </param>
    /// <param name="missShaderBindingTableBuffer">
    ///     missShaderBindingTableBuffer is the buffer object that holds the shader
    ///     binding table data for the miss shader stage.
    /// </param>
    /// <param name="missShaderBindingOffset">
    ///     missShaderBindingOffset is the offset in bytes (relative to
    ///     missShaderBindingTableBuffer) of the miss shader being used for the trace.
    /// </param>
    /// <param name="missShaderBindingStride">
    ///     missShaderBindingStride is the size in bytes of each shader binding table record
    ///     in missShaderBindingTableBuffer.
    /// </param>
    /// <param name="hitShaderBindingTableBuffer">
    ///     hitShaderBindingTableBuffer is the buffer object that holds the shader
    ///     binding table data for the hit shader stages.
    /// </param>
    /// <param name="hitShaderBindingOffset">
    ///     hitShaderBindingOffset is the offset in bytes (relative to
    ///     hitShaderBindingTableBuffer) of the hit shader group being used for the trace.
    /// </param>
    /// <param name="hitShaderBindingStride">
    ///     hitShaderBindingStride is the size in bytes of each shader binding table record in
    ///     hitShaderBindingTableBuffer.
    /// </param>
    /// <param name="callableShaderBindingTableBuffer">
    ///     callableShaderBindingTableBuffer is the buffer object that holds the
    ///     shader binding table data for the callable shader stage.
    /// </param>
    /// <param name="callableShaderBindingOffset">
    ///     callableShaderBindingOffset is the offset in bytes (relative to
    ///     callableShaderBindingTableBuffer) of the callable shader being used for the trace.
    /// </param>
    /// <param name="callableShaderBindingStride">
    ///     callableShaderBindingStride is the size in bytes of each shader binding table
    ///     record in callableShaderBindingTableBuffer.
    /// </param>
    /// <param name="width">width is the width of the ray trace query dimensions.</param>
    /// <param name="height">height is height of the ray trace query dimensions.</param>
    /// <param name="depth">depth is depth of the ray trace query dimensions.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*raygenShaderBindingTableBuffer*/,
        VkDeviceSize /*raygenShaderBindingOffset*/,
        VkBuffer /*missShaderBindingTableBuffer*/,
        VkDeviceSize /*missShaderBindingOffset*/,
        VkDeviceSize /*missShaderBindingStride*/,
        VkBuffer /*hitShaderBindingTableBuffer*/,
        VkDeviceSize /*hitShaderBindingOffset*/,
        VkDeviceSize /*hitShaderBindingStride*/,
        VkBuffer /*callableShaderBindingTableBuffer*/,
        VkDeviceSize /*callableShaderBindingOffset*/,
        VkDeviceSize /*callableShaderBindingStride*/,
        uint /*width*/,
        uint /*height*/,
        uint /*depth*/,
        void> vkCmdTraceRaysNV = null;

    /// <summary>
    ///     vkCreateRayTracingPipelinesNV - Creates a new ray tracing pipeline object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the ray tracing pipelines.</param>
    /// <param name="pipelineCache">
    ///     pipelineCache is either VK_NULL_HANDLE, indicating that pipeline caching is disabled, or
    ///     the handle of a valid pipeline cache object, in which case use of that cache is enabled for the duration of the
    ///     command.
    /// </param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pPipelines arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkRayTracingPipelineCreateInfoNV structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPipelines">
    ///     pPipelines is a pointer to an array in which the resulting ray tracing pipeline objects are
    ///     returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_PIPELINE_COMPILE_REQUIRED_EXT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_SHADER_NV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipelineCache /*pipelineCache*/,
        uint /*createInfoCount*/,
        VkRayTracingPipelineCreateInfoNV* /*pCreateInfos*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkPipeline* /*pPipelines*/,
        VkResult> vkCreateRayTracingPipelinesNV = null;

    /// vkGetRayTracingShaderGroupHandlesNV alias for vkGetRayTracingShaderGroupHandlesKHR
    /// <summary>
    ///     vkGetRayTracingShaderGroupHandlesKHR - Query ray tracing pipeline shader group handles -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesNV.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkPipeline /*pipeline*/,
        uint /*firstGroup*/,
        uint /*groupCount*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        VkResult> vkGetRayTracingShaderGroupHandlesNV = null;

    /// <summary>
    ///     vkGetAccelerationStructureHandleNV - Get opaque acceleration structure handle -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureHandleNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureHandleNV.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the acceleration structures.</param>
    /// <param name="accelerationStructure">accelerationStructure is the acceleration structure.</param>
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
        VkAccelerationStructureNV /*accelerationStructure*/,
        nuint /*dataSize*/,
        void* /*pData*/,
        VkResult> vkGetAccelerationStructureHandleNV = null;

    /// <summary>
    ///     vkCmdWriteAccelerationStructuresPropertiesNV - Write acceleration structure result parameters to query results. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="accelerationStructureCount">
    ///     accelerationStructureCount is the count of acceleration structures for which
    ///     to query the property.
    /// </param>
    /// <param name="pAccelerationStructures">
    ///     pAccelerationStructures is a pointer to an array of existing previously built
    ///     acceleration structures.
    /// </param>
    /// <param name="queryType">queryType is a VkQueryType value specifying the type of queries managed by the pool.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the results of the query.</param>
    /// <param name="firstQuery">
    ///     firstQuery is the first query index within the query pool that will contain the
    ///     accelerationStructureCount number of results.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*accelerationStructureCount*/,
        VkAccelerationStructureNV* /*pAccelerationStructures*/,
        VkQueryType /*queryType*/,
        VkQueryPool /*queryPool*/,
        uint /*firstQuery*/,
        void> vkCmdWriteAccelerationStructuresPropertiesNV = null;

    /// <summary>
    ///     vkCompileDeferredNV - Deferred compilation of shaders -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCompileDeferredNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCompileDeferredNV.html</a>
    /// </summary>
    /// <param name="device">device is the logical device containing the ray tracing pipeline.</param>
    /// <param name="pipeline">pipeline is the ray tracing pipeline object containing the shaders.</param>
    /// <param name="shader">shader is the index of the shader to compile.</param>
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
        uint /*shader*/,
        VkResult> vkCompileDeferredNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateAccelerationStructureNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyAccelerationStructureNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetAccelerationStructureMemoryRequirementsNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkBindAccelerationStructureMemoryNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBuildAccelerationStructureNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyAccelerationStructureNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdTraceRaysNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateRayTracingPipelinesNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetRayTracingShaderGroupHandlesNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetAccelerationStructureHandleNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdWriteAccelerationStructuresPropertiesNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCompileDeferredNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult>* pvkCreateAccelerationStructureNV =
                   &vkCreateAccelerationStructureNV)
        {
            *pvkCreateAccelerationStructureNV = (delegate*<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4e65\u0056");
        }

        fixed (delegate*<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>* pvkDestroyAccelerationStructureNV = &vkDestroyAccelerationStructureNV)
        {
            *pvkDestroyAccelerationStructureNV = (delegate*<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6544\u7473\u6f72\u4179\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2KHR*, void>* pvkGetAccelerationStructureMemoryRequirementsNV =
                   &vkGetAccelerationStructureMemoryRequirementsNV)
        {
            *pvkGetAccelerationStructureMemoryRequirementsNV = (delegate*<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2KHR*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4174\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u654d\u6f6d\u7972\u6552\u7571\u7269\u6d65\u6e65\u7374\u564e\u0000");
        }

        fixed (delegate*<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>* pvkBindAccelerationStructureMemoryNV = &vkBindAccelerationStructureMemoryNV)
        {
            *pvkBindAccelerationStructureMemoryNV = (delegate*<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6942\u646e\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4d65\u6d65\u726f\u4e79\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, VkDeviceSize, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, VkDeviceSize, void>*
               pvkCmdBuildAccelerationStructureNV = &vkCmdBuildAccelerationStructureNV)
        {
            *pvkCmdBuildAccelerationStructureNV =
                (delegate*<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, VkDeviceSize, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, VkDeviceSize, void>)
                Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u4264\u6975\u646c\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void>* pvkCmdCopyAccelerationStructureNV =
                   &vkCmdCopyAccelerationStructureNV)
        {
            *pvkCmdCopyAccelerationStructureNV = (delegate*<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4179\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, uint, uint, uint,
               void>* pvkCmdTraceRaysNV = &vkCmdTraceRaysNV)
        {
            *pvkCmdTraceRaysNV =
                (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, VkBuffer, VkDeviceSize, VkDeviceSize, uint, uint, uint,
                    void>)Core.Vk.GetVkFunction(device, "\u6b76\u6d43\u5464\u6172\u6563\u6152\u7379\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult>* pvkCreateRayTracingPipelinesNV =
                   &vkCreateRayTracingPipelinesNV)
        {
            *pvkCreateRayTracingPipelinesNV = (delegate*<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u7243\u6165\u6574\u6152\u5479\u6172\u6963\u676e\u6950\u6570\u696c\u656e\u4e73\u0056");
        }

        fixed (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>* pvkGetRayTracingShaderGroupHandlesNV = &vkGetRayTracingShaderGroupHandlesNV)
        {
            *pvkGetRayTracingShaderGroupHandlesNV = (delegate*<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u5274\u7961\u7254\u6361\u6e69\u5367\u6168\u6564\u4772\u6f72\u7075\u6148\u646e\u656c\u4e73\u0056");
        }

        fixed (delegate*<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>* pvkGetAccelerationStructureHandleNV = &vkGetAccelerationStructureHandleNV)
        {
            *pvkGetAccelerationStructureHandleNV = (delegate*<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6547\u4174\u6363\u6c65\u7265\u7461\u6f69\u536e\u7274\u6375\u7574\u6572\u6148\u646e\u656c\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void>* pvkCmdWriteAccelerationStructuresPropertiesNV =
                   &vkCmdWriteAccelerationStructuresPropertiesNV)
        {
            *pvkCmdWriteAccelerationStructuresPropertiesNV = (delegate*<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5764\u6972\u6574\u6341\u6563\u656c\u6172\u6974\u6e6f\u7453\u7572\u7463\u7275\u7365\u7250\u706f\u7265\u6974\u7365\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkPipeline, uint, VkResult>* pvkCompileDeferredNV = &vkCompileDeferredNV)
        {
            *pvkCompileDeferredNV = (delegate*<VkDevice, VkPipeline, uint, VkResult>)Core.Vk.GetVkFunction(device, "\u6b76\u6f43\u706d\u6c69\u4465\u6665\u7265\u6572\u4e64\u0056");
        }
    }
}