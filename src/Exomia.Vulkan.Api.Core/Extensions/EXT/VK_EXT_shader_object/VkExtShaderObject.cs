#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtShaderObject;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_shader_object - device extension (nr. 483) - author 'EXT' [platform '' | contact 'Daniel Story
///     @daniel-story']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_object.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_object.html</a>
/// </summary>
[VkDepends("(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+(VK_KHR_dynamic_rendering,VK_VERSION_1_3)")]
[VkDeviceExt]
public static unsafe class VkExtShaderObject
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SHADER_OBJECT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SHADER_OBJECT_EXTENSION_NAME = "VK_EXT_shader_object";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SHADER_OBJECT_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SHADER_OBJECT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SHADER_OBJECT_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u535f\u4148\u4544\u5f52\u424f\u454a\u5443\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateShadersEXT - Create one or more new shaders -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateShadersEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateShadersEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the shader objects.</param>
    /// <param name="createInfoCount">createInfoCount is the length of the pCreateInfos and pShaders arrays.</param>
    /// <param name="pCreateInfos">pCreateInfos is a pointer to an array of VkShaderCreateInfoEXT structures.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pShaders">
    ///     pShaders is a pointer to an array of VkShaderEXT handles in which the resulting shader objects
    ///     are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_INCOMPATIBLE_SHADER_BINARY_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*createInfoCount*/,
        VkShaderCreateInfoEXT* /*pCreateInfos*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkShaderEXT* /*pShaders*/,
        VkResult> vkCreateShadersEXT = null;

    /// <summary>
    ///     vkDestroyShaderEXT - Destroy a shader object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the shader object.</param>
    /// <param name="shader">shader is the handle of the shader object to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkShaderEXT /*shader*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyShaderEXT = null;

    /// <summary>
    ///     vkGetShaderBinaryDataEXT - Get the binary shader code from a shader object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderBinaryDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetShaderBinaryDataEXT.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that shader object was created from.</param>
    /// <param name="shader">shader is the shader object to retrieve binary shader code from.</param>
    /// <param name="pDataSize">
    ///     pDataSize is a pointer to a size_t value related to the size of the binary shader code, as
    ///     described below.
    /// </param>
    /// <param name="pData">pData is either NULL or a pointer to a buffer.</param>
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
        VkShaderEXT /*shader*/,
        nuint* /*pDataSize*/,
        void* /*pData*/,
        VkResult> vkGetShaderBinaryDataEXT = null;

    /// <summary>
    ///     vkCmdBindShadersEXT - Bind shader objects to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadersEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadersEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the shader object will be bound to.</param>
    /// <param name="stageCount">stageCount is the length of the pStages and pShadersarrays.</param>
    /// <param name="pStages">
    ///     pStages is a pointer to an array of VkShaderStageFlagBitsvalues specifying one stage per array
    ///     index that is affected by the corresponding value in the pShaders array.
    /// </param>
    /// <param name="pShaders">
    ///     pShaders is a pointer to an array of VkShaderEXT handles and/or VK_NULL_HANDLE values describing
    ///     the shader binding operations to be performed on each stage in pStages.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*stageCount*/,
        VkShaderStageFlagBits* /*pStages*/,
        VkShaderEXT* /*pShaders*/,
        void> vkCmdBindShadersEXT = null;

    /// vkCmdSetCullModeEXT alias for vkCmdSetCullMode
    /// <summary>
    ///     vkCmdSetCullMode - Set cull mode dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCullModeFlags /*cullMode*/,
        void> vkCmdSetCullModeEXT = null;

    /// vkCmdSetFrontFaceEXT alias for vkCmdSetFrontFace
    /// <summary>
    ///     vkCmdSetFrontFace - Set front face orientation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkFrontFace /*frontFace*/,
        void> vkCmdSetFrontFaceEXT = null;

    /// vkCmdSetPrimitiveTopologyEXT alias for vkCmdSetPrimitiveTopology
    /// <summary>
    ///     vkCmdSetPrimitiveTopology - Set primitive topology state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPrimitiveTopology /*primitiveTopology*/,
        void> vkCmdSetPrimitiveTopologyEXT = null;

    /// vkCmdSetViewportWithCountEXT alias for vkCmdSetViewportWithCount
    /// <summary>
    ///     vkCmdSetViewportWithCount - Set the viewport count and viewports dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*viewportCount*/,
        VkViewport* /*pViewports*/,
        void> vkCmdSetViewportWithCountEXT = null;

    /// vkCmdSetScissorWithCountEXT alias for vkCmdSetScissorWithCount
    /// <summary>
    ///     vkCmdSetScissorWithCount - Set the scissor count and scissor rectangular bounds dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*scissorCount*/,
        VkRect2D* /*pScissors*/,
        void> vkCmdSetScissorWithCountEXT = null;

    /// vkCmdBindVertexBuffers2EXT alias for vkCmdBindVertexBuffers2
    /// <summary>
    ///     vkCmdBindVertexBuffers2 - Bind vertex buffers to a command buffer and dynamically set strides -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstBinding*/,
        uint /*bindingCount*/,
        VkBuffer* /*pBuffers*/,
        VkDeviceSize* /*pOffsets*/,
        VkDeviceSize* /*pSizes*/,
        VkDeviceSize* /*pStrides*/,
        void> vkCmdBindVertexBuffers2EXT = null;

    /// vkCmdSetDepthTestEnableEXT alias for vkCmdSetDepthTestEnable
    /// <summary>
    ///     vkCmdSetDepthTestEnable - Set depth test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthTestEnable*/,
        void> vkCmdSetDepthTestEnableEXT = null;

    /// vkCmdSetDepthWriteEnableEXT alias for vkCmdSetDepthWriteEnable
    /// <summary>
    ///     vkCmdSetDepthWriteEnable - Set depth write enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthWriteEnable*/,
        void> vkCmdSetDepthWriteEnableEXT = null;

    /// vkCmdSetDepthCompareOpEXT alias for vkCmdSetDepthCompareOp
    /// <summary>
    ///     vkCmdSetDepthCompareOp - Set depth comparison operator dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCompareOp /*depthCompareOp*/,
        void> vkCmdSetDepthCompareOpEXT = null;

    /// vkCmdSetDepthBoundsTestEnableEXT alias for vkCmdSetDepthBoundsTestEnable
    /// <summary>
    ///     vkCmdSetDepthBoundsTestEnable - Set depth bounds test enable dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthBoundsTestEnable*/,
        void> vkCmdSetDepthBoundsTestEnableEXT = null;

    /// vkCmdSetStencilTestEnableEXT alias for vkCmdSetStencilTestEnable
    /// <summary>
    ///     vkCmdSetStencilTestEnable - Set stencil test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*stencilTestEnable*/,
        void> vkCmdSetStencilTestEnableEXT = null;

    /// vkCmdSetStencilOpEXT alias for vkCmdSetStencilOp
    /// <summary>
    ///     vkCmdSetStencilOp - Set stencil operation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkStencilFaceFlags /*faceMask*/,
        VkStencilOp /*failOp*/,
        VkStencilOp /*passOp*/,
        VkStencilOp /*depthFailOp*/,
        VkCompareOp /*compareOp*/,
        void> vkCmdSetStencilOpEXT = null;

    /// <summary>
    ///     vkCmdSetVertexInputEXT - Set the vertex input state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="vertexBindingDescriptionCount">
    ///     vertexBindingDescriptionCount is the number of vertex binding descriptions
    ///     provided in pVertexBindingDescriptions.
    /// </param>
    /// <param name="pVertexBindingDescriptions">
    ///     pVertexBindingDescriptions is a pointer to an array of
    ///     VkVertexInputBindingDescription2EXT structures.
    /// </param>
    /// <param name="vertexAttributeDescriptionCount">
    ///     vertexAttributeDescriptionCount is the number of vertex attribute
    ///     descriptions provided in pVertexAttributeDescriptions.
    /// </param>
    /// <param name="pVertexAttributeDescriptions">
    ///     pVertexAttributeDescriptions is a pointer to an array of
    ///     VkVertexInputAttributeDescription2EXT structures.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*vertexBindingDescriptionCount*/,
        VkVertexInputBindingDescription2EXT* /*pVertexBindingDescriptions*/,
        uint /*vertexAttributeDescriptionCount*/,
        VkVertexInputAttributeDescription2EXT* /*pVertexAttributeDescriptions*/,
        void> vkCmdSetVertexInputEXT = null;

    /// <summary>
    ///     vkCmdSetPatchControlPointsEXT - Specify the number of control points per patch dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="patchControlPoints">patchControlPoints specifies the number of control points per patch.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*patchControlPoints*/,
        void> vkCmdSetPatchControlPointsEXT = null;

    /// vkCmdSetRasterizerDiscardEnableEXT alias for vkCmdSetRasterizerDiscardEnable
    /// <summary>
    ///     vkCmdSetRasterizerDiscardEnable - Control whether primitives are discarded before the rasterization stage
    ///     dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*rasterizerDiscardEnable*/,
        void> vkCmdSetRasterizerDiscardEnableEXT = null;

    /// vkCmdSetDepthBiasEnableEXT alias for vkCmdSetDepthBiasEnable
    /// <summary>
    ///     vkCmdSetDepthBiasEnable - Control whether to bias fragment depth values dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthBiasEnable*/,
        void> vkCmdSetDepthBiasEnableEXT = null;

    /// <summary>
    ///     vkCmdSetLogicOpEXT - Select which logical operation to apply for blend state dynamically for a command buffer
    ///     -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="logicOp">logicOp specifies the logical operation to apply for blend state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkLogicOp /*logicOp*/,
        void> vkCmdSetLogicOpEXT = null;

    /// vkCmdSetPrimitiveRestartEnableEXT alias for vkCmdSetPrimitiveRestartEnable
    /// <summary>
    ///     vkCmdSetPrimitiveRestartEnable - Set primitive assembly restart state dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*primitiveRestartEnable*/,
        void> vkCmdSetPrimitiveRestartEnableEXT = null;

    /// <summary>
    ///     vkCmdSetTessellationDomainOriginEXT - Specify the origin of the tessellation domain space dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetTessellationDomainOriginEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetTessellationDomainOriginEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="domainOrigin">domainOrigin specifies the origin of the tessellation domain space.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkTessellationDomainOrigin /*domainOrigin*/,
        void> vkCmdSetTessellationDomainOriginEXT = null;

    /// <summary>
    ///     vkCmdSetDepthClampEnableEXT - Specify dynamically whether depth clamping is enabled in the command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthClampEnable">depthClampEnable specifies whether depth clamping is enabled.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthClampEnable*/,
        void> vkCmdSetDepthClampEnableEXT = null;

    /// <summary>
    ///     vkCmdSetPolygonModeEXT - Specify polygon mode dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPolygonModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPolygonModeEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="polygonMode">polygonMode specifies polygon mode.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPolygonMode /*polygonMode*/,
        void> vkCmdSetPolygonModeEXT = null;

    /// <summary>
    ///     vkCmdSetRasterizationSamplesEXT - Specify the rasterization samples dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationSamplesEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationSamplesEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="rasterizationSamples">rasterizationSamples specifies rasterizationSamples.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSampleCountFlagBits /*rasterizationSamples*/,
        void> vkCmdSetRasterizationSamplesEXT = null;

    /// <summary>
    ///     vkCmdSetSampleMaskEXT - Specify the sample mask dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleMaskEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleMaskEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="samples">samples specifies the number of sample bits in the pSampleMask.</param>
    /// <param name="pSampleMask">
    ///     pSampleMask is a pointer to an array of VkSampleMaskvalues, where the array size is based on
    ///     the samples parameter.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSampleCountFlagBits /*samples*/,
        VkSampleMask* /*pSampleMask*/,
        void> vkCmdSetSampleMaskEXT = null;

    /// <summary>
    ///     vkCmdSetAlphaToCoverageEnableEXT - Specify the alpha to coverage enable state dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToCoverageEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToCoverageEnableEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="alphaToCoverageEnable">alphaToCoverageEnable specifies the alphaToCoverageEnablestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*alphaToCoverageEnable*/,
        void> vkCmdSetAlphaToCoverageEnableEXT = null;

    /// <summary>
    ///     vkCmdSetAlphaToOneEnableEXT - Specify the alpha to one enable state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToOneEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToOneEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="alphaToOneEnable">alphaToOneEnable specifies the alphaToOneEnable state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*alphaToOneEnable*/,
        void> vkCmdSetAlphaToOneEnableEXT = null;

    /// <summary>
    ///     vkCmdSetLogicOpEnableEXT - Specify dynamically whether logical operations are enabled for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="logicOpEnable">logicOpEnable specifies whether logical operations are enabled.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*logicOpEnable*/,
        void> vkCmdSetLogicOpEnableEXT = null;

    /// <summary>
    ///     vkCmdSetColorBlendEnableEXT - Specify the pname:blendEnable for each attachment dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstAttachment">firstAttachment the first color attachment the color blending enable applies.</param>
    /// <param name="attachmentCount">attachmentCount the number of color blending enables in the pColorBlendEnables array.</param>
    /// <param name="pColorBlendEnables">
    ///     pColorBlendEnables an array of booleans to indicate whether color blending is enabled
    ///     for the corresponding attachment.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstAttachment*/,
        uint /*attachmentCount*/,
        VkBool32* /*pColorBlendEnables*/,
        void> vkCmdSetColorBlendEnableEXT = null;

    /// <summary>
    ///     vkCmdSetColorBlendEquationEXT - Specify the blend factors and operations dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEquationEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEquationEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstAttachment">
    ///     firstAttachment the first color attachment the color blend factors and operations apply
    ///     to.
    /// </param>
    /// <param name="attachmentCount">
    ///     attachmentCount the number of VkColorBlendEquationEXTelements in the pColorBlendEquations
    ///     array.
    /// </param>
    /// <param name="pColorBlendEquations">
    ///     pColorBlendEquations an array of VkColorBlendEquationEXTstructs that specify the
    ///     color blend factors and operations for the corresponding attachments.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstAttachment*/,
        uint /*attachmentCount*/,
        VkColorBlendEquationEXT* /*pColorBlendEquations*/,
        void> vkCmdSetColorBlendEquationEXT = null;

    /// <summary>
    ///     vkCmdSetColorWriteMaskEXT - Specify the color write masks for each attachment dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteMaskEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteMaskEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstAttachment">firstAttachment the first color attachment the color write masks apply to.</param>
    /// <param name="attachmentCount">attachmentCount the number of VkColorComponentFlags values in the pColorWriteMasks array.</param>
    /// <param name="pColorWriteMasks">
    ///     pColorWriteMasks an array of VkColorComponentFlags values that specify the color write
    ///     masks of the corresponding attachments.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstAttachment*/,
        uint /*attachmentCount*/,
        VkColorComponentFlags* /*pColorWriteMasks*/,
        void> vkCmdSetColorWriteMaskEXT = null;

    /// <summary>
    ///     vkCmdSetRasterizationStreamEXT - Specify the rasterization stream dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationStreamEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationStreamEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="rasterizationStream">rasterizationStream specifies the rasterizationStream state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*rasterizationStream*/,
        void> vkCmdSetRasterizationStreamEXT = null;

    /// <summary>
    ///     vkCmdSetConservativeRasterizationModeEXT - Specify the conservative rasterization mode dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetConservativeRasterizationModeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetConservativeRasterizationModeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="conservativeRasterizationMode">
    ///     conservativeRasterizationMode specifies the conservativeRasterizationMode
    ///     state.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkConservativeRasterizationModeEXT /*conservativeRasterizationMode*/,
        void> vkCmdSetConservativeRasterizationModeEXT = null;

    /// <summary>
    ///     vkCmdSetExtraPrimitiveOverestimationSizeEXT - Specify the conservative rasterization extra primitive overestimation
    ///     size dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetExtraPrimitiveOverestimationSizeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetExtraPrimitiveOverestimationSizeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="extraPrimitiveOverestimationSize">
    ///     extraPrimitiveOverestimationSize specifies the
    ///     extraPrimitiveOverestimationSize.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        float /*extraPrimitiveOverestimationSize*/,
        void> vkCmdSetExtraPrimitiveOverestimationSizeEXT = null;

    /// <summary>
    ///     vkCmdSetDepthClipEnableEXT - Specify dynamically whether depth clipping is enabled in the command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthClipEnable">depthClipEnable specifies whether depth clipping is enabled.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*depthClipEnable*/,
        void> vkCmdSetDepthClipEnableEXT = null;

    /// <summary>
    ///     vkCmdSetSampleLocationsEnableEXT - Specify the samples locations enable state dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEnableEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="sampleLocationsEnable">sampleLocationsEnable specifies the sampleLocationsEnablestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*sampleLocationsEnable*/,
        void> vkCmdSetSampleLocationsEnableEXT = null;

    /// <summary>
    ///     vkCmdSetColorBlendAdvancedEXT - Specify the advanced color blend state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendAdvancedEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendAdvancedEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstAttachment">firstAttachment the first color attachment the advanced blend parameters apply to.</param>
    /// <param name="attachmentCount">
    ///     attachmentCount the number of VkColorBlendAdvancedEXTelements in the pColorBlendAdvanced
    ///     array.
    /// </param>
    /// <param name="pColorBlendAdvanced">
    ///     pColorBlendAdvanced an array of VkColorBlendAdvancedEXTstructs that specify the
    ///     advanced color blend parameters for the corresponding attachments.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstAttachment*/,
        uint /*attachmentCount*/,
        VkColorBlendAdvancedEXT* /*pColorBlendAdvanced*/,
        void> vkCmdSetColorBlendAdvancedEXT = null;

    /// <summary>
    ///     vkCmdSetProvokingVertexModeEXT - Specify the provoking vertex mode dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetProvokingVertexModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetProvokingVertexModeEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="provokingVertexMode">provokingVertexMode specifies the provokingVertexMode state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkProvokingVertexModeEXT /*provokingVertexMode*/,
        void> vkCmdSetProvokingVertexModeEXT = null;

    /// <summary>
    ///     vkCmdSetLineRasterizationModeEXT - Specify the line rasterization mode dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineRasterizationModeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineRasterizationModeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="lineRasterizationMode">lineRasterizationMode specifies the lineRasterizationModestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkLineRasterizationModeEXT /*lineRasterizationMode*/,
        void> vkCmdSetLineRasterizationModeEXT = null;

    /// <summary>
    ///     vkCmdSetLineStippleEnableEXT - Specify the line stipple enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEnableEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEnableEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="stippledLineEnable">stippledLineEnable specifies the stippledLineEnable state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*stippledLineEnable*/,
        void> vkCmdSetLineStippleEnableEXT = null;

    /// <summary>
    ///     vkCmdSetDepthClipNegativeOneToOneEXT - Specify the negative one to one depth clip mode dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipNegativeOneToOneEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipNegativeOneToOneEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="negativeOneToOne">negativeOneToOne specifies the negativeOneToOne state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*negativeOneToOne*/,
        void> vkCmdSetDepthClipNegativeOneToOneEXT = null;

    /// <summary>
    ///     vkCmdSetViewportWScalingEnableNV - Specify the viewport W scaling enable state dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingEnableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingEnableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="viewportWScalingEnable">viewportWScalingEnable specifies the viewportWScalingEnablestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*viewportWScalingEnable*/,
        void> vkCmdSetViewportWScalingEnableNV = null;

    /// <summary>
    ///     vkCmdSetViewportSwizzleNV - Specify the viewport swizzle state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportSwizzleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportSwizzleNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="firstViewport">
    ///     firstViewport is the index of the first viewport whose parameters are updated by the
    ///     command.
    /// </param>
    /// <param name="viewportCount">viewportCount is the number of viewports whose parameters are updated by the command.</param>
    /// <param name="pViewportSwizzles">
    ///     pViewportSwizzles is a pointer to an array of VkViewportSwizzleNV structures specifying
    ///     viewport swizzles.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstViewport*/,
        uint /*viewportCount*/,
        VkViewportSwizzleNV* /*pViewportSwizzles*/,
        void> vkCmdSetViewportSwizzleNV = null;

    /// <summary>
    ///     vkCmdSetCoverageToColorEnableNV - Specify the coverage to color enable state dynamically for a command buffer
    ///     -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorEnableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorEnableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageToColorEnable">coverageToColorEnable specifies the coverageToColorEnablestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*coverageToColorEnable*/,
        void> vkCmdSetCoverageToColorEnableNV = null;

    /// <summary>
    ///     vkCmdSetCoverageToColorLocationNV - Specify the coverage to color location dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorLocationNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorLocationNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageToColorLocation">coverageToColorLocation specifies the coverageToColorLocation state.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*coverageToColorLocation*/,
        void> vkCmdSetCoverageToColorLocationNV = null;

    /// <summary>
    ///     vkCmdSetCoverageModulationModeNV - Specify the coverage modulation mode dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationModeNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationModeNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageModulationMode">coverageModulationMode specifies the coverageModulationModestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCoverageModulationModeNV /*coverageModulationMode*/,
        void> vkCmdSetCoverageModulationModeNV = null;

    /// <summary>
    ///     vkCmdSetCoverageModulationTableEnableNV - Specify the coverage modulation table enable state dynamically for a
    ///     command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableEnableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableEnableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageModulationTableEnable">
    ///     coverageModulationTableEnable specifies the coverageModulationTableEnable
    ///     state.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*coverageModulationTableEnable*/,
        void> vkCmdSetCoverageModulationTableEnableNV = null;

    /// <summary>
    ///     vkCmdSetCoverageModulationTableNV - Specify the coverage modulation table dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageModulationTableCount">
    ///     coverageModulationTableCount specifies the number of elements in
    ///     pCoverageModulationTable.
    /// </param>
    /// <param name="pCoverageModulationTable">
    ///     pCoverageModulationTable specifies the table of modulation factors containing a
    ///     value for each number of covered samples.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*coverageModulationTableCount*/,
        float* /*pCoverageModulationTable*/,
        void> vkCmdSetCoverageModulationTableNV = null;

    /// <summary>
    ///     vkCmdSetShadingRateImageEnableNV - Specify the shading rate image enable state dynamically for a command
    ///     buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetShadingRateImageEnableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetShadingRateImageEnableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="shadingRateImageEnable">shadingRateImageEnable specifies the shadingRateImageEnablestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*shadingRateImageEnable*/,
        void> vkCmdSetShadingRateImageEnableNV = null;

    /// <summary>
    ///     vkCmdSetRepresentativeFragmentTestEnableNV - Specify the representative fragment test enable dynamically for a
    ///     command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRepresentativeFragmentTestEnableNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRepresentativeFragmentTestEnableNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="representativeFragmentTestEnable">
    ///     representativeFragmentTestEnable specifies the
    ///     representativeFragmentTestEnable state.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBool32 /*representativeFragmentTestEnable*/,
        void> vkCmdSetRepresentativeFragmentTestEnableNV = null;

    /// <summary>
    ///     vkCmdSetCoverageReductionModeNV - Specify the coverage reduction mode dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageReductionModeNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageReductionModeNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="coverageReductionMode">coverageReductionMode specifies the coverageReductionModestate.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkCoverageReductionModeNV /*coverageReductionMode*/,
        void> vkCmdSetCoverageReductionModeNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateShadersEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyShaderEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetShaderBinaryDataEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindShadersEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCullModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetFrontFaceEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPrimitiveTopologyEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetViewportWithCountEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetScissorWithCountEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindVertexBuffers2EXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthWriteEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthCompareOpEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthBoundsTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetStencilTestEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetStencilOpEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetVertexInputEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPatchControlPointsEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetRasterizerDiscardEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthBiasEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetLogicOpEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPrimitiveRestartEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetTessellationDomainOriginEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthClampEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetPolygonModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetRasterizationSamplesEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetSampleMaskEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetAlphaToCoverageEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetAlphaToOneEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetLogicOpEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetColorBlendEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetColorBlendEquationEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetColorWriteMaskEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetRasterizationStreamEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetConservativeRasterizationModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetExtraPrimitiveOverestimationSizeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthClipEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetSampleLocationsEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetColorBlendAdvancedEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetProvokingVertexModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetLineRasterizationModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetLineStippleEnableEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDepthClipNegativeOneToOneEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetViewportWScalingEnableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetViewportSwizzleNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageToColorEnableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageToColorLocationNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageModulationModeNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageModulationTableEnableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageModulationTableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetShadingRateImageEnableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetRepresentativeFragmentTestEnableNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetCoverageReductionModeNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult>* pvkCreateShadersEXT = &vkCreateShadersEXT)
        {
            *pvkCreateShadersEXT =
                (delegate*<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult>)GetVkFunction(
                    device, "\u6b76\u7243\u6165\u6574\u6853\u6461\u7265\u4573\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>* pvkDestroyShaderEXT = &vkDestroyShaderEXT)
        {
            *pvkDestroyShaderEXT = (delegate*<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>)GetVkFunction(device, "\u6b76\u6544\u7473\u6f72\u5379\u6168\u6564\u4572\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkShaderEXT, nuint*, void*, VkResult>* pvkGetShaderBinaryDataEXT = &vkGetShaderBinaryDataEXT)
        {
            *pvkGetShaderBinaryDataEXT = (delegate*<VkDevice, VkShaderEXT, nuint*, void*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6168\u6564\u4272\u6e69\u7261\u4479\u7461\u4561\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void>* pvkCmdBindShadersEXT = &vkCmdBindShadersEXT)
        {
            *pvkCmdBindShadersEXT = (delegate*<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void>)GetVkFunction(device, "\u6b76\u6d43\u4264\u6e69\u5364\u6168\u6564\u7372\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkCullModeFlags, void>* pvkCmdSetCullModeEXT = &vkCmdSetCullModeEXT)
        {
            *pvkCmdSetCullModeEXT = (delegate*<VkCommandBuffer, VkCullModeFlags, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u7543\u6c6c\u6f4d\u6564\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkFrontFace, void>* pvkCmdSetFrontFaceEXT = &vkCmdSetFrontFaceEXT)
        {
            *pvkCmdSetFrontFaceEXT = (delegate*<VkCommandBuffer, VkFrontFace, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u7246\u6e6f\u4674\u6361\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPrimitiveTopology, void>* pvkCmdSetPrimitiveTopologyEXT = &vkCmdSetPrimitiveTopologyEXT)
        {
            *pvkCmdSetPrimitiveTopologyEXT = (delegate*<VkCommandBuffer, VkPrimitiveTopology, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7250\u6d69\u7469\u7669\u5465\u706f\u6c6f\u676f\u4579\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkViewport*, void>* pvkCmdSetViewportWithCountEXT = &vkCmdSetViewportWithCountEXT)
        {
            *pvkCmdSetViewportWithCountEXT = (delegate*<VkCommandBuffer, uint, VkViewport*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u6957\u6874\u6f43\u6e75\u4574\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkRect2D*, void>* pvkCmdSetScissorWithCountEXT = &vkCmdSetScissorWithCountEXT)
        {
            *pvkCmdSetScissorWithCountEXT = (delegate*<VkCommandBuffer, uint, VkRect2D*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6353\u7369\u6f73\u5772\u7469\u4368\u756f\u746e\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>* pvkCmdBindVertexBuffers2EXT = &vkCmdBindVertexBuffers2EXT)
        {
            *pvkCmdBindVertexBuffers2EXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u5664\u7265\u6574\u4278\u6675\u6566\u7372\u4532\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthTestEnableEXT = &vkCmdSetDepthTestEnableEXT)
        {
            *pvkCmdSetDepthTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u5468\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthWriteEnableEXT = &vkCmdSetDepthWriteEnableEXT)
        {
            *pvkCmdSetDepthWriteEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u5768\u6972\u6574\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkCompareOp, void>* pvkCmdSetDepthCompareOpEXT = &vkCmdSetDepthCompareOpEXT)
        {
            *pvkCmdSetDepthCompareOpEXT = (delegate*<VkCommandBuffer, VkCompareOp, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u6d6f\u6170\u6572\u704f\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthBoundsTestEnableEXT = &vkCmdSetDepthBoundsTestEnableEXT)
        {
            *pvkCmdSetDepthBoundsTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4268\u756f\u646e\u5473\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetStencilTestEnableEXT = &vkCmdSetStencilTestEnableEXT)
        {
            *pvkCmdSetStencilTestEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7453\u6e65\u6963\u546c\u7365\u4574\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>* pvkCmdSetStencilOpEXT = &vkCmdSetStencilOpEXT)
        {
            *pvkCmdSetStencilOpEXT = (delegate*<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7453\u6e65\u6963\u4f6c\u4570\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>* pvkCmdSetVertexInputEXT = &vkCmdSetVertexInputEXT)
        {
            *pvkCmdSetVertexInputEXT = (delegate*<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6556\u7472\u7865\u6e49\u7570\u4574\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetPatchControlPointsEXT = &vkCmdSetPatchControlPointsEXT)
        {
            *pvkCmdSetPatchControlPointsEXT = (delegate*<VkCommandBuffer, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6150\u6374\u4368\u6e6f\u7274\u6c6f\u6f50\u6e69\u7374\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetRasterizerDiscardEnableEXT = &vkCmdSetRasterizerDiscardEnableEXT)
        {
            *pvkCmdSetRasterizerDiscardEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6152\u7473\u7265\u7a69\u7265\u6944\u6373\u7261\u4564\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthBiasEnableEXT = &vkCmdSetDepthBiasEnableEXT)
        {
            *pvkCmdSetDepthBiasEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4268\u6169\u4573\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkLogicOp, void>* pvkCmdSetLogicOpEXT = &vkCmdSetLogicOpEXT)
        {
            *pvkCmdSetLogicOpEXT = (delegate*<VkCommandBuffer, VkLogicOp, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6f4c\u6967\u4f63\u4570\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetPrimitiveRestartEnableEXT = &vkCmdSetPrimitiveRestartEnableEXT)
        {
            *pvkCmdSetPrimitiveRestartEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7250\u6d69\u7469\u7669\u5265\u7365\u6174\u7472\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkTessellationDomainOrigin, void>* pvkCmdSetTessellationDomainOriginEXT = &vkCmdSetTessellationDomainOriginEXT)
        {
            *pvkCmdSetTessellationDomainOriginEXT = (delegate*<VkCommandBuffer, VkTessellationDomainOrigin, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6554\u7373\u6c65\u616c\u6974\u6e6f\u6f44\u616d\u6e69\u724f\u6769\u6e69\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthClampEnableEXT = &vkCmdSetDepthClampEnableEXT)
        {
            *pvkCmdSetDepthClampEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u616c\u706d\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkPolygonMode, void>* pvkCmdSetPolygonModeEXT = &vkCmdSetPolygonModeEXT)
        {
            *pvkCmdSetPolygonModeEXT = (delegate*<VkCommandBuffer, VkPolygonMode, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6f50\u796c\u6f67\u4d6e\u646f\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkSampleCountFlagBits, void>* pvkCmdSetRasterizationSamplesEXT = &vkCmdSetRasterizationSamplesEXT)
        {
            *pvkCmdSetRasterizationSamplesEXT = (delegate*<VkCommandBuffer, VkSampleCountFlagBits, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6152\u7473\u7265\u7a69\u7461\u6f69\u536e\u6d61\u6c70\u7365\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkSampleCountFlagBits, VkSampleMask*, void>* pvkCmdSetSampleMaskEXT = &vkCmdSetSampleMaskEXT)
        {
            *pvkCmdSetSampleMaskEXT =
                (delegate*<VkCommandBuffer, VkSampleCountFlagBits, VkSampleMask*, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6153\u706d\u656c\u614d\u6b73\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetAlphaToCoverageEnableEXT = &vkCmdSetAlphaToCoverageEnableEXT)
        {
            *pvkCmdSetAlphaToCoverageEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6c41\u6870\u5461\u436f\u766f\u7265\u6761\u4565\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetAlphaToOneEnableEXT = &vkCmdSetAlphaToOneEnableEXT)
        {
            *pvkCmdSetAlphaToOneEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6c41\u6870\u5461\u4f6f\u656e\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetLogicOpEnableEXT = &vkCmdSetLogicOpEnableEXT)
        {
            *pvkCmdSetLogicOpEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6f4c\u6967\u4f63\u4570\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBool32*, void>* pvkCmdSetColorBlendEnableEXT = &vkCmdSetColorBlendEnableEXT)
        {
            *pvkCmdSetColorBlendEnableEXT = (delegate*<VkCommandBuffer, uint, uint, VkBool32*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6f6c\u4272\u656c\u646e\u6e45\u6261\u656c\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void>* pvkCmdSetColorBlendEquationEXT = &vkCmdSetColorBlendEquationEXT)
        {
            *pvkCmdSetColorBlendEquationEXT = (delegate*<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6f6c\u4272\u656c\u646e\u7145\u6175\u6974\u6e6f\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void>* pvkCmdSetColorWriteMaskEXT = &vkCmdSetColorWriteMaskEXT)
        {
            *pvkCmdSetColorWriteMaskEXT = (delegate*<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6f6c\u5772\u6972\u6574\u614d\u6b73\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetRasterizationStreamEXT = &vkCmdSetRasterizationStreamEXT)
        {
            *pvkCmdSetRasterizationStreamEXT = (delegate*<VkCommandBuffer, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6152\u7473\u7265\u7a69\u7461\u6f69\u536e\u7274\u6165\u456d\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>* pvkCmdSetConservativeRasterizationModeEXT = &vkCmdSetConservativeRasterizationModeEXT)
        {
            *pvkCmdSetConservativeRasterizationModeEXT = (delegate*<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u736e\u7265\u6176\u6974\u6576\u6152\u7473\u7265\u7a69\u7461\u6f69\u4d6e\u646f\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, float, void>* pvkCmdSetExtraPrimitiveOverestimationSizeEXT = &vkCmdSetExtraPrimitiveOverestimationSizeEXT)
        {
            *pvkCmdSetExtraPrimitiveOverestimationSizeEXT = (delegate*<VkCommandBuffer, float, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7845\u7274\u5061\u6972\u696d\u6974\u6576\u764f\u7265\u7365\u6974\u616d\u6974\u6e6f\u6953\u657a\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthClipEnableEXT = &vkCmdSetDepthClipEnableEXT)
        {
            *pvkCmdSetDepthClipEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u696c\u4570\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetSampleLocationsEnableEXT = &vkCmdSetSampleLocationsEnableEXT)
        {
            *pvkCmdSetSampleLocationsEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6153\u706d\u656c\u6f4c\u6163\u6974\u6e6f\u4573\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void>* pvkCmdSetColorBlendAdvancedEXT = &vkCmdSetColorBlendAdvancedEXT)
        {
            *pvkCmdSetColorBlendAdvancedEXT = (delegate*<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6f6c\u4272\u656c\u646e\u6441\u6176\u636e\u6465\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkProvokingVertexModeEXT, void>* pvkCmdSetProvokingVertexModeEXT = &vkCmdSetProvokingVertexModeEXT)
        {
            *pvkCmdSetProvokingVertexModeEXT = (delegate*<VkCommandBuffer, VkProvokingVertexModeEXT, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7250\u766f\u6b6f\u6e69\u5667\u7265\u6574\u4d78\u646f\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkLineRasterizationModeEXT, void>* pvkCmdSetLineRasterizationModeEXT = &vkCmdSetLineRasterizationModeEXT)
        {
            *pvkCmdSetLineRasterizationModeEXT = (delegate*<VkCommandBuffer, VkLineRasterizationModeEXT, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u694c\u656e\u6152\u7473\u7265\u7a69\u7461\u6f69\u4d6e\u646f\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetLineStippleEnableEXT = &vkCmdSetLineStippleEnableEXT)
        {
            *pvkCmdSetLineStippleEnableEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u694c\u656e\u7453\u7069\u6c70\u4565\u616e\u6c62\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetDepthClipNegativeOneToOneEXT = &vkCmdSetDepthClipNegativeOneToOneEXT)
        {
            *pvkCmdSetDepthClipNegativeOneToOneEXT = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u696c\u4e70\u6765\u7461\u7669\u4f65\u656e\u6f54\u6e4f\u4565\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetViewportWScalingEnableNV = &vkCmdSetViewportWScalingEnableNV)
        {
            *pvkCmdSetViewportWScalingEnableNV = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u5357\u6163\u696c\u676e\u6e45\u6261\u656c\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void>* pvkCmdSetViewportSwizzleNV = &vkCmdSetViewportSwizzleNV)
        {
            *pvkCmdSetViewportSwizzleNV = (delegate*<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6956\u7765\u6f70\u7472\u7753\u7a69\u6c7a\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetCoverageToColorEnableNV = &vkCmdSetCoverageToColorEnableNV)
        {
            *pvkCmdSetCoverageToColorEnableNV = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6f54\u6f43\u6f6c\u4572\u616e\u6c62\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetCoverageToColorLocationNV = &vkCmdSetCoverageToColorLocationNV)
        {
            *pvkCmdSetCoverageToColorLocationNV = (delegate*<VkCommandBuffer, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6f54\u6f43\u6f6c\u4c72\u636f\u7461\u6f69\u4e6e\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkCoverageModulationModeNV, void>* pvkCmdSetCoverageModulationModeNV = &vkCmdSetCoverageModulationModeNV)
        {
            *pvkCmdSetCoverageModulationModeNV = (delegate*<VkCommandBuffer, VkCoverageModulationModeNV, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6f4d\u7564\u616c\u6974\u6e6f\u6f4d\u6564\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetCoverageModulationTableEnableNV = &vkCmdSetCoverageModulationTableEnableNV)
        {
            *pvkCmdSetCoverageModulationTableEnableNV = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6f4d\u7564\u616c\u6974\u6e6f\u6154\u6c62\u4565\u616e\u6c62\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, uint, float*, void>* pvkCmdSetCoverageModulationTableNV = &vkCmdSetCoverageModulationTableNV)
        {
            *pvkCmdSetCoverageModulationTableNV = (delegate*<VkCommandBuffer, uint, float*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6f4d\u7564\u616c\u6974\u6e6f\u6154\u6c62\u4e65\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetShadingRateImageEnableNV = &vkCmdSetShadingRateImageEnableNV)
        {
            *pvkCmdSetShadingRateImageEnableNV = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6853\u6461\u6e69\u5267\u7461\u4965\u616d\u6567\u6e45\u6261\u656c\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkBool32, void>* pvkCmdSetRepresentativeFragmentTestEnableNV = &vkCmdSetRepresentativeFragmentTestEnableNV)
        {
            *pvkCmdSetRepresentativeFragmentTestEnableNV = (delegate*<VkCommandBuffer, VkBool32, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6552\u7270\u7365\u6e65\u6174\u6974\u6576\u7246\u6761\u656d\u746e\u6554\u7473\u6e45\u6261\u656c\u564e\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkCoverageReductionModeNV, void>* pvkCmdSetCoverageReductionModeNV = &vkCmdSetCoverageReductionModeNV)
        {
            *pvkCmdSetCoverageReductionModeNV = (delegate*<VkCommandBuffer, VkCoverageReductionModeNV, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6f43\u6576\u6172\u6567\u6552\u7564\u7463\u6f69\u4d6e\u646f\u4e65\u0056");
        }
    }
}