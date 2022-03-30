#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtTransformFeedback;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_transform_feedback - device extension (nr. 29) - author 'NV' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_transform_feedback.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_transform_feedback.html</a>
/// </summary>
/// <remarks>
///     specialuse: glemulation,d3demulation,devtools
/// </remarks>
[VkRequires("VK_KHR_get_physical_device_properties2")]
[VkSpecialuse("glemulation,d3demulation,devtools")]
public static unsafe class VkExtTransformFeedback
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME = "VK_EXT_transform_feedback";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u545f\u4152\u534e\u4f46\u4d52\u465f\u4545\u4244\u4341\u5f4b\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdBindTransformFeedbackBuffersEXT - Bind transform feedback buffers to a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="firstBinding">
    ///     firstBinding is the index of the first transform feedback binding whose state is updated by
    ///     the command.
    /// </param>
    /// <param name="bindingCount">
    ///     bindingCount is the number of transform feedback bindings whose state is updated by the
    ///     command.
    /// </param>
    /// <param name="pBuffers">pBuffers is a pointer to an array of buffer handles.</param>
    /// <param name="pOffsets">pOffsets is a pointer to an array of buffer offsets.</param>
    /// <param name="pSizes">
    ///     pSizes is NULL or a pointer to an array of VkDeviceSizebuffer sizes, specifying the maximum number
    ///     of bytes to capture to the corresponding transform feedback buffer. If pSizes is NULL, or the value of the pSizes
    ///     array element is VK_WHOLE_SIZE, then the maximum number of bytes captured will be the size of the corresponding
    ///     buffer minus the buffer offset.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstBinding*/,
        uint /*bindingCount*/,
        VkBuffer* /*pBuffers*/,
        VkDeviceSize* /*pOffsets*/,
        VkDeviceSize* /*pSizes*/,
        void> vkCmdBindTransformFeedbackBuffersEXT = null;

    /// <summary>
    ///     vkCmdBeginTransformFeedbackEXT - Make transform feedback active in the command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="firstCounterBuffer">
    ///     firstCounterBuffer is the index of the first transform feedback buffer corresponding
    ///     to pCounterBuffers[0] and pCounterBufferOffsets[0].
    /// </param>
    /// <param name="counterBufferCount">
    ///     counterBufferCount is the size of the pCounterBuffers and pCounterBufferOffsets
    ///     arrays.
    /// </param>
    /// <param name="pCounterBuffers">
    ///     pCounterBuffers is NULL or a pointer to an array of VkBuffer handles to counter buffers.
    ///     Each buffer contains a 4 byte integer value representing the byte offset from the start of the corresponding
    ///     transform feedback buffer from where to start capturing vertex data. If the byte offset stored to the counter
    ///     buffer location was done using vkCmdEndTransformFeedbackEXT it can be used to resume transform feedback from the
    ///     previous location. If pCounterBuffers is NULL, then transform feedback will start capturing vertex data to byte
    ///     offset zero in all bound transform feedback buffers. For each element of pCounterBuffers that is VK_NULL_HANDLE,
    ///     transform feedback will start capturing vertex data to byte zero in the corresponding bound transform feedback
    ///     buffer.
    /// </param>
    /// <param name="pCounterBufferOffsets">
    ///     pCounterBufferOffsets is NULL or a pointer to an array of VkDeviceSize values
    ///     specifying offsets within each of the pCounterBuffers where the counter values were previously written. The
    ///     location in each counter buffer at these offsets must be large enough to contain 4 bytes of data. This data is the
    ///     number of bytes captured by the previous transform feedback to this buffer. If pCounterBufferOffsets is NULL, then
    ///     it is assumed the offsets are zero.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstCounterBuffer*/,
        uint /*counterBufferCount*/,
        VkBuffer* /*pCounterBuffers*/,
        VkDeviceSize* /*pCounterBufferOffsets*/,
        void> vkCmdBeginTransformFeedbackEXT = null;

    /// <summary>
    ///     vkCmdEndTransformFeedbackEXT - Make transform feedback inactive in the command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="firstCounterBuffer">
    ///     firstCounterBuffer is the index of the first transform feedback buffer corresponding
    ///     to pCounterBuffers[0] and pCounterBufferOffsets[0].
    /// </param>
    /// <param name="counterBufferCount">
    ///     counterBufferCount is the size of the pCounterBuffers and pCounterBufferOffsets
    ///     arrays.
    /// </param>
    /// <param name="pCounterBuffers">
    ///     pCounterBuffers is NULL or a pointer to an array of VkBuffer handles to counter buffers.
    ///     The counter buffers are used to record the current byte positions of each transform feedback buffer where the next
    ///     vertex output data would be captured. This can be used by a subsequent vkCmdBeginTransformFeedbackEXTcall to resume
    ///     transform feedback capture from this position. It can also be used by vkCmdDrawIndirectByteCountEXT to determine
    ///     the vertex count of the draw call.
    /// </param>
    /// <param name="pCounterBufferOffsets">
    ///     pCounterBufferOffsets is NULL or a pointer to an array of VkDeviceSize values
    ///     specifying offsets within each of the pCounterBuffers where the counter values can be written. The location in each
    ///     counter buffer at these offsets must be large enough to contain 4 bytes of data. The data stored at this location
    ///     is the byte offset from the start of the transform feedback buffer binding where the next vertex data would be
    ///     written. If pCounterBufferOffsets is NULL, then it is assumed the offsets are zero.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*firstCounterBuffer*/,
        uint /*counterBufferCount*/,
        VkBuffer* /*pCounterBuffers*/,
        VkDeviceSize* /*pCounterBufferOffsets*/,
        void> vkCmdEndTransformFeedbackEXT = null;

    /// <summary>
    ///     vkCmdBeginQueryIndexedEXT - Begin an indexed query -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQueryIndexedEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQueryIndexedEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the results of the query.</param>
    /// <param name="query">query is the query index within the query pool that will contain the results.</param>
    /// <param name="flags">
    ///     flags is a bitmask of VkQueryControlFlagBits specifying constraints on the types of queries that
    ///     can be performed.
    /// </param>
    /// <param name="index">
    ///     index is the query type specific index. When the query type is
    ///     VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXTor VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT, the index represents the
    ///     vertex stream.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkQueryPool /*queryPool*/,
        uint /*query*/,
        VkQueryControlFlags /*flags*/,
        uint /*index*/,
        void> vkCmdBeginQueryIndexedEXT = null;

    /// <summary>
    ///     vkCmdEndQueryIndexedEXT - Ends a query -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndQueryIndexedEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndQueryIndexedEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which this command will be recorded.</param>
    /// <param name="queryPool">queryPool is the query pool that is managing the results of the query.</param>
    /// <param name="query">query is the query index within the query pool where the result is stored.</param>
    /// <param name="index">index is the query type specific index.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkQueryPool /*queryPool*/,
        uint /*query*/,
        uint /*index*/,
        void> vkCmdEndQueryIndexedEXT = null;

    /// <summary>
    ///     vkCmdDrawIndirectByteCountEXT - Draw primitives with indirect parameters where the vertex count is derived
    ///     from the counter byte value in the counter buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectByteCountEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectByteCountEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="instanceCount">instanceCount is the number of instances to draw.</param>
    /// <param name="firstInstance">firstInstance is the instance ID of the first instance to draw.</param>
    /// <param name="counterBuffer">counterBuffer is the buffer handle from where the byte count is read.</param>
    /// <param name="counterBufferOffset">
    ///     counterBufferOffset is the offset into the buffer used to read the byte count, which
    ///     is used to calculate the vertex count for this draw call.
    /// </param>
    /// <param name="counterOffset">
    ///     counterOffset is subtracted from the byte count read from the counterBuffer at the
    ///     counterBufferOffset
    /// </param>
    /// <param name="vertexStride">
    ///     vertexStride is the stride in bytes between each element of the vertex data that is used to
    ///     calculate the vertex count from the counter value. This value is typically the same value that was used in the
    ///     graphics pipeline state when the transform feedback was captured as the XfbStride.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*instanceCount*/,
        uint /*firstInstance*/,
        VkBuffer /*counterBuffer*/,
        VkDeviceSize /*counterBufferOffset*/,
        uint /*counterOffset*/,
        uint /*vertexStride*/,
        void> vkCmdDrawIndirectByteCountEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBindTransformFeedbackBuffersEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBeginTransformFeedbackEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdEndTransformFeedbackEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBeginQueryIndexedEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdEndQueryIndexedEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDrawIndirectByteCountEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, void>* pvkCmdBindTransformFeedbackBuffersEXT = &vkCmdBindTransformFeedbackBuffersEXT)
        {
            *pvkCmdBindTransformFeedbackBuffersEXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u5464\u6172\u736e\u6f66\u6d72\u6546\u6465\u6162\u6b63\u7542\u6666\u7265\u4573\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void>* pvkCmdBeginTransformFeedbackEXT = &vkCmdBeginTransformFeedbackEXT)
        {
            *pvkCmdBeginTransformFeedbackEXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6765\u6e69\u7254\u6e61\u6673\u726f\u466d\u6565\u6264\u6361\u456b\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void>* pvkCmdEndTransformFeedbackEXT = &vkCmdEndTransformFeedbackEXT)
        {
            *pvkCmdEndTransformFeedbackEXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4564\u646e\u7254\u6e61\u6673\u726f\u466d\u6565\u6264\u6361\u456b\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void>* pvkCmdBeginQueryIndexedEXT = &vkCmdBeginQueryIndexedEXT)
        {
            *pvkCmdBeginQueryIndexedEXT = (delegate*<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6765\u6e69\u7551\u7265\u4979\u646e\u7865\u6465\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>* pvkCmdEndQueryIndexedEXT = &vkCmdEndQueryIndexedEXT)
        {
            *pvkCmdEndQueryIndexedEXT = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)GetVkFunction(device, "\u6b76\u6d43\u4564\u646e\u7551\u7265\u4979\u646e\u7865\u6465\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, uint, uint, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawIndirectByteCountEXT = &vkCmdDrawIndirectByteCountEXT)
        {
            *pvkCmdDrawIndirectByteCountEXT = (delegate*<VkCommandBuffer, uint, uint, VkBuffer, VkDeviceSize, uint, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4977\u646e\u7269\u6365\u4274\u7479\u4365\u756f\u746e\u5845\u0054");
        }
    }
}