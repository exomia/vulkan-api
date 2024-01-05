#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkPhysicalDeviceTransformFeedbackPropertiesEXT - Structure describing transform feedback properties that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTransformFeedbackPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTransformFeedbackPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxTransformFeedbackStreamsis the maximum number of vertex streams that can be output from geometry shaders
    ///     declared with the GeometryStreams capability. If the implementation does not support
    ///     VkPhysicalDeviceTransformFeedbackFeaturesEXT::geometryStreamsthen maxTransformFeedbackStreams must be set to 1.
    /// </summary>
    public uint maxTransformFeedbackStreams;

    /// <summary>
    ///     maxTransformFeedbackBuffersis the maximum number of transform feedback buffers that can be bound for
    ///     capturing shader outputs from the last pre-rasterization shader stage.
    /// </summary>
    public uint maxTransformFeedbackBuffers;

    /// <summary>
    ///     maxTransformFeedbackBufferSize is the maximum size that can be specified when binding a buffer for transform
    ///     feedback in vkCmdBindTransformFeedbackBuffersEXT.
    /// </summary>
    public VkDeviceSize maxTransformFeedbackBufferSize;

    /// <summary>
    ///     maxTransformFeedbackStreamDataSize is the maximum amount of data in bytes for each vertex that captured to one
    ///     or more transform feedback buffers associated with a specific vertex stream.
    /// </summary>
    public uint maxTransformFeedbackStreamDataSize;

    /// <summary>
    ///     maxTransformFeedbackBufferDataSize is the maximum amount of data in bytes for each vertex that can be captured
    ///     to a specific transform feedback buffer.
    /// </summary>
    public uint maxTransformFeedbackBufferDataSize;

    /// <summary>maxTransformFeedbackBufferDataStride is the maximum stride between each capture of vertex data to the buffer.</summary>
    public uint maxTransformFeedbackBufferDataStride;

    /// <summary>
    ///     transformFeedbackQueries is VK_TRUE if the implementation supports the
    ///     VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT query type. transformFeedbackQueries is VK_FALSE if queries of this
    ///     type cannot be created.
    /// </summary>
    public VkBool32 transformFeedbackQueries;

    /// <summary>
    ///     transformFeedbackStreamsLinesTriangles is VK_TRUE if the implementation supports the geometry shader
    ///     OpExecutionMode of OutputLineStrip and OutputTriangleStrip in addition to OutputPoints when more than one vertex
    ///     stream is output. If transformFeedbackStreamsLinesTriangles is VK_FALSE the implementation only supports an
    ///     OpExecutionMode of OutputPoints when more than one vertex stream is output from the geometry shader.
    /// </summary>
    public VkBool32 transformFeedbackStreamsLinesTriangles;

    /// <summary>
    ///     transformFeedbackRasterizationStreamSelect is VK_TRUE if the implementation supports the GeometryStreams
    ///     SPIR-V capability and the application can use VkPipelineRasterizationStateStreamCreateInfoEXT to modify which
    ///     vertex stream output is used for rasterization. Otherwise vertex stream 0 must always be used for rasterization.
    /// </summary>
    public VkBool32 transformFeedbackRasterizationStreamSelect;

    /// <summary>
    ///     transformFeedbackDraw is VK_TRUE if the implementation supports the vkCmdDrawIndirectByteCountEXT function
    ///     otherwise the function must not be called.
    /// </summary>
    public VkBool32 transformFeedbackDraw;
}