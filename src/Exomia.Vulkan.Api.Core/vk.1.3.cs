#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core;

/// <content>
///     VK_VERSION_1_3 - vulkan
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     vkGetPhysicalDeviceToolProperties - Reports properties of tools active on the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device to query for active tools.</param>
    /// <param name="pToolCount">pToolCount is a pointer to an integer describing the number of tools active on physicalDevice.</param>
    /// <param name="pToolProperties">
    ///     pToolProperties is either NULL or a pointer to an array of VkPhysicalDeviceToolProperties
    ///     structures.
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
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceToolProperties")]
    public static extern unsafe VkResult vkGetPhysicalDeviceToolProperties(
        VkPhysicalDevice                physicalDevice,
        uint*                           pToolCount,
        VkPhysicalDeviceToolProperties* pToolProperties);

    /// <summary>
    ///     vkCreatePrivateDataSlot - Create a slot for private data storage -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlot.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlot.html</a>
    /// </summary>
    /// <param name="device">
    ///     device is the logical device associated with the creation of the object(s) holding the private
    ///     data slot.
    /// </param>
    /// <param name="pCreateInfo">pCreateInfo is a pointer to a VkPrivateDataSlotCreateInfo</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pPrivateDataSlot">
    ///     pPrivateDataSlot is a pointer to a VkPrivateDataSlot handle in which the resulting
    ///     private data slot is returned
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
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCreatePrivateDataSlot")]
    public static extern unsafe VkResult vkCreatePrivateDataSlot(
        VkDevice                     device,
        VkPrivateDataSlotCreateInfo* pCreateInfo,
        VkAllocationCallbacks*       pAllocator,
        VkPrivateDataSlot*           pPrivateDataSlot);

    /// <summary>
    ///     vkDestroyPrivateDataSlot - Destroy a private data slot -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlot.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlot.html</a>
    /// </summary>
    /// <param name="device">
    ///     device is the logical device associated with the creation of the object(s) holding the private
    ///     data slot.
    /// </param>
    /// <param name="privateDataSlot">privateDataSlot is the private data slot to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyPrivateDataSlot")]
    public static extern unsafe void vkDestroyPrivateDataSlot(
        VkDevice               device,
        VkPrivateDataSlot      privateDataSlot,
        VkAllocationCallbacks* pAllocator);

    /// <summary>
    ///     vkSetPrivateData - Associate data with a Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetPrivateData.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetPrivateData.html</a>
    /// </summary>
    /// <param name="device">device is the device that created the object.</param>
    /// <param name="objectType">objectType is a VkObjectType specifying the type of object to associate data with.</param>
    /// <param name="objectHandle">objectHandle is a handle to the object to associate data with.</param>
    /// <param name="privateDataSlot">
    ///     privateDataSlot is a handle to a VkPrivateDataSlotspecifying location of private data
    ///     storage.
    /// </param>
    /// <param name="data">data is user defined data to associate the object with. This data will be stored at privateDataSlot.</param>
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
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkSetPrivateData")]
    public static extern VkResult vkSetPrivateData(
        VkDevice          device,
        VkObjectType      objectType,
        ulong             objectHandle,
        VkPrivateDataSlot privateDataSlot,
        ulong             data);

    /// <summary>
    ///     vkGetPrivateData - Retrieve data associated with a Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPrivateData.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPrivateData.html</a>
    /// </summary>
    /// <param name="device">device is the device that created the object</param>
    /// <param name="objectType">objectType is a VkObjectType specifying the type of object data is associated with.</param>
    /// <param name="objectHandle">objectHandle is a handle to the object data is associated with.</param>
    /// <param name="privateDataSlot">
    ///     privateDataSlot is a handle to a VkPrivateDataSlotspecifying location of private data
    ///     pointer storage.
    /// </param>
    /// <param name="pData">
    ///     pData is a pointer to specify where user data is returned. 0 will be written in the absence of a
    ///     previous call to vkSetPrivateData using the object specified by objectHandle.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPrivateData")]
    public static extern unsafe void vkGetPrivateData(
        VkDevice          device,
        VkObjectType      objectType,
        ulong             objectHandle,
        VkPrivateDataSlot privateDataSlot,
        ulong*            pData);

    /// <summary>
    ///     vkCmdSetEvent2 - Set an event object to signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="event">event is the event that will be signaled.</param>
    /// <param name="pDependencyInfo">
    ///     pDependencyInfo is a pointer to a VkDependencyInfo structure defining the first scopes of
    ///     this operation.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetEvent2")]
    public static extern unsafe void vkCmdSetEvent2(
        VkCommandBuffer   commandBuffer,
        VkEvent           @event,
        VkDependencyInfo* pDependencyInfo);

    /// <summary>
    ///     vkCmdResetEvent2 - Reset an event object to non-signaled state -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="event">event is the event that will be unsignaled.</param>
    /// <param name="stageMask">
    ///     stageMask is a VkPipelineStageFlags2 mask of pipeline stages used to determine the first
    ///     synchronization scope.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdResetEvent2")]
    public static extern void vkCmdResetEvent2(
        VkCommandBuffer       commandBuffer,
        VkEvent               @event,
        VkPipelineStageFlags2 stageMask);

    /// <summary>
    ///     vkCmdWaitEvents2 - Wait for one or more events -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="eventCount">eventCount is the length of the pEvents array.</param>
    /// <param name="pEvents">pEvents is a pointer to an array of eventCount events to wait on.</param>
    /// <param name="pDependencyInfos">
    ///     pDependencyInfos is a pointer to an array of eventCountVkDependencyInfo structures,
    ///     defining the second synchronization scope.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdWaitEvents2")]
    public static extern unsafe void vkCmdWaitEvents2(
        VkCommandBuffer   commandBuffer,
        uint              eventCount,
        VkEvent*          pEvents,
        VkDependencyInfo* pDependencyInfos);

    /// <summary>
    ///     vkCmdPipelineBarrier2 - Insert a memory dependency -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="pDependencyInfo">
    ///     pDependencyInfo is a pointer to a VkDependencyInfo structure defining the scopes of this
    ///     operation.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdPipelineBarrier2")]
    public static extern unsafe void vkCmdPipelineBarrier2(
        VkCommandBuffer   commandBuffer,
        VkDependencyInfo* pDependencyInfo);

    /// <summary>
    ///     vkCmdWriteTimestamp2 - Write a device timestamp into a query object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="stage">stage specifies a stage of the pipeline.</param>
    /// <param name="queryPool">queryPool is the query pool that will manage the timestamp.</param>
    /// <param name="query">query is the query within the query pool that will contain the timestamp.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdWriteTimestamp2")]
    public static extern void vkCmdWriteTimestamp2(
        VkCommandBuffer       commandBuffer,
        VkPipelineStageFlags2 stage,
        VkQueryPool           queryPool,
        uint                  query);

    /// <summary>
    ///     vkQueueSubmit2 - Submits command buffers to a queue -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2.html</a>
    /// </summary>
    /// <param name="queue">queue is the queue that the command buffers will be submitted to.</param>
    /// <param name="submitCount">submitCount is the number of elements in the pSubmits array.</param>
    /// <param name="pSubmits">
    ///     pSubmits is a pointer to an array of VkSubmitInfo2structures, each specifying a command buffer
    ///     submission batch.
    /// </param>
    /// <param name="fence">
    ///     fence is an optional handle to a fence to be signaled once all submitted command buffers have
    ///     completed execution. If fence is not VK_NULL_HANDLE, it defines a fence signal operation.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkQueueSubmit2")]
    public static extern unsafe VkResult vkQueueSubmit2(
        VkQueue        queue,
        uint           submitCount,
        VkSubmitInfo2* pSubmits,
        VkFence        fence);

    /// <summary>
    ///     vkCmdCopyBuffer2 - Copy data between buffer regions -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pCopyBufferInfo">
    ///     pCopyBufferInfo is a pointer to a VkCopyBufferInfo2structure describing the copy
    ///     parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyBuffer2")]
    public static extern unsafe void vkCmdCopyBuffer2(
        VkCommandBuffer    commandBuffer,
        VkCopyBufferInfo2* pCopyBufferInfo);

    /// <summary>
    ///     vkCmdCopyImage2 - Copy data between images -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pCopyImageInfo">
    ///     pCopyImageInfo is a pointer to a VkCopyImageInfo2 structure describing the copy
    ///     parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyImage2")]
    public static extern unsafe void vkCmdCopyImage2(
        VkCommandBuffer   commandBuffer,
        VkCopyImageInfo2* pCopyImageInfo);

    /// <summary>
    ///     vkCmdCopyBufferToImage2 - Copy data from a buffer into an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pCopyBufferToImageInfo">
    ///     pCopyBufferToImageInfo is a pointer to a VkCopyBufferToImageInfo2 structure
    ///     describing the copy parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyBufferToImage2")]
    public static extern unsafe void vkCmdCopyBufferToImage2(
        VkCommandBuffer           commandBuffer,
        VkCopyBufferToImageInfo2* pCopyBufferToImageInfo);

    /// <summary>
    ///     vkCmdCopyImageToBuffer2 - Copy image data into a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pCopyImageToBufferInfo">
    ///     pCopyImageToBufferInfo is a pointer to a VkCopyImageToBufferInfo2 structure
    ///     describing the copy parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdCopyImageToBuffer2")]
    public static extern unsafe void vkCmdCopyImageToBuffer2(
        VkCommandBuffer           commandBuffer,
        VkCopyImageToBufferInfo2* pCopyImageToBufferInfo);

    /// <summary>
    ///     vkCmdBlitImage2 - Copy regions of an image, potentially performing format conversion, -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pBlitImageInfo">
    ///     pBlitImageInfo is a pointer to a VkBlitImageInfo2 structure describing the blit
    ///     parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBlitImage2")]
    public static extern unsafe void vkCmdBlitImage2(
        VkCommandBuffer   commandBuffer,
        VkBlitImageInfo2* pBlitImageInfo);

    /// <summary>
    ///     vkCmdResolveImage2 - Resolve regions of an image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pResolveImageInfo">
    ///     pResolveImageInfo is a pointer to a VkResolveImageInfo2structure describing the resolve
    ///     parameters.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdResolveImage2")]
    public static extern unsafe void vkCmdResolveImage2(
        VkCommandBuffer      commandBuffer,
        VkResolveImageInfo2* pResolveImageInfo);

    /// <summary>
    ///     vkCmdBeginRendering - Begin a dynamic render pass instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRendering.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRendering.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pRenderingInfo">
    ///     pRenderingInfo is a pointer to a VkRenderingInfo structure specifying details of the
    ///     render pass instance to begin.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBeginRendering")]
    public static extern unsafe void vkCmdBeginRendering(
        VkCommandBuffer  commandBuffer,
        VkRenderingInfo* pRenderingInfo);

    /// <summary>
    ///     vkCmdEndRendering - End a dynamic render pass instance -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdEndRendering")]
    public static extern void vkCmdEndRendering(VkCommandBuffer commandBuffer);

    /// <summary>
    ///     vkCmdSetCullMode - Set cull mode dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="cullMode">cullMode specifies the cull mode property to use for drawing.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetCullMode")]
    public static extern void vkCmdSetCullMode(
        VkCommandBuffer commandBuffer,
        VkCullModeFlags cullMode);

    /// <summary>
    ///     vkCmdSetFrontFace - Set front face orientation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="frontFace">
    ///     frontFace is a VkFrontFace value specifying the front-facing triangle orientation to be used
    ///     for culling.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetFrontFace")]
    public static extern void vkCmdSetFrontFace(
        VkCommandBuffer commandBuffer,
        VkFrontFace     frontFace);

    /// <summary>
    ///     vkCmdSetPrimitiveTopology - Set primitive topology state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="primitiveTopology">primitiveTopology specifies the primitive topology to use for drawing.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetPrimitiveTopology")]
    public static extern void vkCmdSetPrimitiveTopology(
        VkCommandBuffer     commandBuffer,
        VkPrimitiveTopology primitiveTopology);

    /// <summary>
    ///     vkCmdSetViewportWithCount - Set the viewport count and viewports dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="viewportCount">viewportCount specifies the viewport count.</param>
    /// <param name="pViewports">pViewports specifies the viewports to use for drawing.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetViewportWithCount")]
    public static extern unsafe void vkCmdSetViewportWithCount(
        VkCommandBuffer commandBuffer,
        uint            viewportCount,
        VkViewport*     pViewports);

    /// <summary>
    ///     vkCmdSetScissorWithCount - Set the scissor count and scissor rectangular bounds dynamically for a command
    ///     buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="scissorCount">scissorCount specifies the scissor count.</param>
    /// <param name="pScissors">pScissors specifies the scissors to use for drawing.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetScissorWithCount")]
    public static extern unsafe void vkCmdSetScissorWithCount(
        VkCommandBuffer commandBuffer,
        uint            scissorCount,
        VkRect2D*       pScissors);

    /// <summary>
    ///     vkCmdBindVertexBuffers2 - Bind vertex buffers to a command buffer and dynamically set strides -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="firstBinding">
    ///     firstBinding is the index of the first vertex input binding whose state is updated by the
    ///     command.
    /// </param>
    /// <param name="bindingCount">bindingCount is the number of vertex input bindings whose state is updated by the command.</param>
    /// <param name="pBuffers">pBuffers is a pointer to an array of buffer handles.</param>
    /// <param name="pOffsets">pOffsets is a pointer to an array of buffer offsets.</param>
    /// <param name="pSizes">pSizes is NULL or a pointer to an array of the size in bytes of vertex data bound from pBuffers.</param>
    /// <param name="pStrides">pStrides is NULL or a pointer to an array of buffer strides.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBindVertexBuffers2")]
    public static extern unsafe void vkCmdBindVertexBuffers2(
        VkCommandBuffer commandBuffer,
        uint            firstBinding,
        uint            bindingCount,
        VkBuffer*       pBuffers,
        VkDeviceSize*   pOffsets,
        VkDeviceSize*   pSizes,
        VkDeviceSize*   pStrides);

    /// <summary>
    ///     vkCmdSetDepthTestEnable - Set depth test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthTestEnable">depthTestEnable specifies if the depth test is enabled.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthTestEnable")]
    public static extern void vkCmdSetDepthTestEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        depthTestEnable);

    /// <summary>
    ///     vkCmdSetDepthWriteEnable - Set depth write enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthWriteEnable">depthWriteEnable specifies if depth writes are enabled.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthWriteEnable")]
    public static extern void vkCmdSetDepthWriteEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        depthWriteEnable);

    /// <summary>
    ///     vkCmdSetDepthCompareOp - Set depth comparison operator dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthCompareOp">depthCompareOp specifies the depth comparison operator.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthCompareOp")]
    public static extern void vkCmdSetDepthCompareOp(
        VkCommandBuffer commandBuffer,
        VkCompareOp     depthCompareOp);

    /// <summary>
    ///     vkCmdSetDepthBoundsTestEnable - Set depth bounds test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthBoundsTestEnable">depthBoundsTestEnable specifies if the depth bounds test is enabled.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthBoundsTestEnable")]
    public static extern void vkCmdSetDepthBoundsTestEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        depthBoundsTestEnable);

    /// <summary>
    ///     vkCmdSetStencilTestEnable - Set stencil test enable dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="stencilTestEnable">stencilTestEnable specifies if the stencil test is enabled.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetStencilTestEnable")]
    public static extern void vkCmdSetStencilTestEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        stencilTestEnable);

    /// <summary>
    ///     vkCmdSetStencilOp - Set stencil operation dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="faceMask">
    ///     faceMask is a bitmask of VkStencilFaceFlagBits specifying the set of stencil state for which to
    ///     update the stencil operation.
    /// </param>
    /// <param name="failOp">
    ///     failOp is a VkStencilOp value specifying the action performed on samples that fail the stencil
    ///     test.
    /// </param>
    /// <param name="passOp">
    ///     passOp is a VkStencilOp value specifying the action performed on samples that pass both the depth
    ///     and stencil tests.
    /// </param>
    /// <param name="depthFailOp">
    ///     depthFailOp is a VkStencilOp value specifying the action performed on samples that pass the
    ///     stencil test and fail the depth test.
    /// </param>
    /// <param name="compareOp">compareOp is a VkCompareOp value specifying the comparison operator used in the stencil test.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetStencilOp")]
    public static extern void vkCmdSetStencilOp(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        VkStencilOp        failOp,
        VkStencilOp        passOp,
        VkStencilOp        depthFailOp,
        VkCompareOp        compareOp);

    /// <summary>
    ///     vkCmdSetRasterizerDiscardEnable - Control whether primitives are discarded before the rasterization stage
    ///     dynamically for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="rasterizerDiscardEnable">
    ///     rasterizerDiscardEnable controls whether primitives are discarded immediately
    ///     before the rasterization stage.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetRasterizerDiscardEnable")]
    public static extern void vkCmdSetRasterizerDiscardEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        rasterizerDiscardEnable);

    /// <summary>
    ///     vkCmdSetDepthBiasEnable - Control whether to bias fragment depth values dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthBiasEnable">depthBiasEnable controls whether to bias fragment depth values.</param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDepthBiasEnable")]
    public static extern void vkCmdSetDepthBiasEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        depthBiasEnable);

    /// <summary>
    ///     vkCmdSetPrimitiveRestartEnable - Set primitive assembly restart state dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="primitiveRestartEnable">
    ///     primitiveRestartEnable controls whether a special vertex index value is treated as
    ///     restarting the assembly of primitives. It behaves in the same way as
    ///     VkPipelineInputAssemblyStateCreateInfo::primitiveRestartEnable
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetPrimitiveRestartEnable")]
    public static extern void vkCmdSetPrimitiveRestartEnable(
        VkCommandBuffer commandBuffer,
        VkBool32        primitiveRestartEnable);

    /// <summary>
    ///     vkGetDeviceBufferMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirements.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirements.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device intended to own the buffer.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkDeviceBufferMemoryRequirementsstructure containing parameters required
    ///     for the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the buffer object are returned.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceBufferMemoryRequirements")]
    public static extern unsafe void vkGetDeviceBufferMemoryRequirements(
        VkDevice                          device,
        VkDeviceBufferMemoryRequirements* pInfo,
        VkMemoryRequirements2*            pMemoryRequirements);

    /// <summary>
    ///     vkGetDeviceImageMemoryRequirements - Returns the memory requirements for specified Vulkan object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirements.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirements.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device intended to own the image.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkDeviceImageMemoryRequirementsstructure containing parameters required for
    ///     the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the image object are returned.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceImageMemoryRequirements")]
    public static extern unsafe void vkGetDeviceImageMemoryRequirements(
        VkDevice                         device,
        VkDeviceImageMemoryRequirements* pInfo,
        VkMemoryRequirements2*           pMemoryRequirements);

    /// <summary>
    ///     vkGetDeviceImageSparseMemoryRequirements - Query the memory requirements for a sparse image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirements.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirements.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device intended to own the image.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkDeviceImageMemoryRequirementsstructure containing parameters required for
    ///     the memory requirements query.
    /// </param>
    /// <param name="pSparseMemoryRequirementCount">
    ///     pSparseMemoryRequirementCount is a pointer to an integer related to the
    ///     number of sparse memory requirements available or queried, as described below.
    /// </param>
    /// <param name="pSparseMemoryRequirements">
    ///     pSparseMemoryRequirements is either NULL or a pointer to an array of
    ///     VkSparseImageMemoryRequirements2 structures.
    /// </param>
    [VkVersion("1.3")]
    [SuppressUnmanagedCodeSecurity]
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceImageSparseMemoryRequirements")]
    public static extern unsafe void vkGetDeviceImageSparseMemoryRequirements(
        VkDevice                          device,
        VkDeviceImageMemoryRequirements*  pInfo,
        uint*                             pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
}