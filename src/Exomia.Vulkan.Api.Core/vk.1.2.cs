#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core;

using System.Security;

/// <content>
///     VK_VERSION_1_2 - vulkan,vulkansc
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     vkCmdDrawIndirectCount - Draw primitives with indirect parameters and draw count -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCount.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCount.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="countBuffer">countBuffer is the buffer containing the draw count.</param>
    /// <param name="countBufferOffset">countBufferOffset is the byte offset into countBuffer where the draw count begins.</param>
    /// <param name="maxDrawCount">
    ///     maxDrawCount specifies the maximum number of draws that will be executed. The actual number
    ///     of executed draw calls is the minimum of the count specified in countBuffer and maxDrawCount.
    /// </param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndirectCount")]
    public static unsafe partial void vkCmdDrawIndirectCount(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndirectCount")]
    public static extern void vkCmdDrawIndirectCount(
#endif
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    /// <summary>
    ///     vkCmdDrawIndexedIndirectCount - Draw parameters with indirect parameters, indexed vertices, and draw count -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCount.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCount.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer containing draw parameters.</param>
    /// <param name="offset">offset is the byte offset into buffer where parameters begin.</param>
    /// <param name="countBuffer">countBuffer is the buffer containing the draw count.</param>
    /// <param name="countBufferOffset">countBufferOffset is the byte offset into countBuffer where the draw count begins.</param>
    /// <param name="maxDrawCount">
    ///     maxDrawCount specifies the maximum number of draws that will be executed. The actual number
    ///     of executed draw calls is the minimum of the count specified in countBuffer and maxDrawCount.
    /// </param>
    /// <param name="stride">stride is the byte stride between successive sets of draw parameters.</param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndexedIndirectCount")]
    public static unsafe partial void vkCmdDrawIndexedIndirectCount(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDrawIndexedIndirectCount")]
    public static extern void vkCmdDrawIndexedIndirectCount(
#endif
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    /// <summary>
    ///     vkCreateRenderPass2 - Create a new render pass object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the render pass.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkRenderPassCreateInfo2structure describing the parameters of
    ///     the render pass.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pRenderPass">
    ///     pRenderPass is a pointer to a VkRenderPass handle in which the resulting render pass object
    ///     is returned.
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
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCreateRenderPass2")]
    public static unsafe partial VkResult vkCreateRenderPass2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateRenderPass2")]
    public static extern unsafe VkResult vkCreateRenderPass2(
#endif
        VkDevice                 device,
        VkRenderPassCreateInfo2* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkRenderPass*            pRenderPass);

    /// <summary>
    ///     vkCmdBeginRenderPass2 - Begin a new render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pRenderPassBegin">
    ///     pRenderPassBegin is a pointer to a VkRenderPassBeginInfostructure specifying the render
    ///     pass to begin an instance of, and the framebuffer the instance uses.
    /// </param>
    /// <param name="pSubpassBeginInfo">
    ///     pSubpassBeginInfo is a pointer to a VkSubpassBeginInfostructure containing information
    ///     about the subpass which is about to begin rendering.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdBeginRenderPass2")]
    public static unsafe partial void vkCmdBeginRenderPass2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdBeginRenderPass2")]
    public static extern unsafe void vkCmdBeginRenderPass2(
#endif
        VkCommandBuffer        commandBuffer,
        VkRenderPassBeginInfo* pRenderPassBegin,
        VkSubpassBeginInfo*    pSubpassBeginInfo);

    /// <summary>
    ///     vkCmdNextSubpass2 - Transition to the next subpass of a render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to record the command.</param>
    /// <param name="pSubpassBeginInfo">
    ///     pSubpassBeginInfo is a pointer to a VkSubpassBeginInfostructure containing information
    ///     about the subpass which is about to begin rendering.
    /// </param>
    /// <param name="pSubpassEndInfo">
    ///     pSubpassEndInfo is a pointer to a VkSubpassEndInfo structure containing information about
    ///     how the previous subpass will be ended.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdNextSubpass2")]
    public static unsafe partial void vkCmdNextSubpass2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdNextSubpass2")]
    public static extern unsafe void vkCmdNextSubpass2(
#endif
        VkCommandBuffer     commandBuffer,
        VkSubpassBeginInfo* pSubpassBeginInfo,
        VkSubpassEndInfo*   pSubpassEndInfo);

    /// <summary>
    ///     vkCmdEndRenderPass2 - End the current render pass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which to end the current render pass instance.</param>
    /// <param name="pSubpassEndInfo">
    ///     pSubpassEndInfo is a pointer to a VkSubpassEndInfo structure containing information about
    ///     how the last subpass will be ended.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdEndRenderPass2")]
    public static unsafe partial void vkCmdEndRenderPass2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdEndRenderPass2")]
    public static extern unsafe void vkCmdEndRenderPass2(
#endif
        VkCommandBuffer   commandBuffer,
        VkSubpassEndInfo* pSubpassEndInfo);

    /// <summary>
    ///     vkResetQueryPool - Reset queries in a query pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetQueryPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkResetQueryPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the query pool.</param>
    /// <param name="queryPool">queryPool is the handle of the query pool managing the queries being reset.</param>
    /// <param name="firstQuery">firstQuery is the initial query index to reset.</param>
    /// <param name="queryCount">queryCount is the number of queries to reset.</param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkResetQueryPool")]
    public static unsafe partial void vkResetQueryPool(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkResetQueryPool")]
    public static extern void vkResetQueryPool(
#endif
        VkDevice    device,
        VkQueryPool queryPool,
        uint        firstQuery,
        uint        queryCount);

    /// <summary>
    ///     vkGetSemaphoreCounterValue - Query the current state of a timeline semaphore -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValue.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValue.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the semaphore.</param>
    /// <param name="semaphore">semaphore is the handle of the semaphore to query.</param>
    /// <param name="pValue">
    ///     pValue is a pointer to a 64-bit integer value in which the current counter value of the semaphore
    ///     is returned.
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
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetSemaphoreCounterValue")]
    public static unsafe partial VkResult vkGetSemaphoreCounterValue(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetSemaphoreCounterValue")]
    public static extern unsafe VkResult vkGetSemaphoreCounterValue(
#endif
        VkDevice    device,
        VkSemaphore semaphore,
        ulong*      pValue);

    /// <summary>
    ///     vkWaitSemaphores - Wait for timeline semaphores on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphores.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphores.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the semaphores.</param>
    /// <param name="pWaitInfo">
    ///     pWaitInfo is a pointer to a VkSemaphoreWaitInfo structure containing information about the wait
    ///     condition.
    /// </param>
    /// <param name="timeout">
    ///     timeout is the timeout period in units of nanoseconds. timeout is adjusted to the closest value
    ///     allowed by the implementation-dependent timeout accuracy, which may be substantially longer than one nanosecond,
    ///     and may be longer than the requested period.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_TIMEOUT</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkWaitSemaphores")]
    public static unsafe partial VkResult vkWaitSemaphores(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkWaitSemaphores")]
    public static extern unsafe VkResult vkWaitSemaphores(
#endif
        VkDevice             device,
        VkSemaphoreWaitInfo* pWaitInfo,
        ulong                timeout);

    /// <summary>
    ///     vkSignalSemaphore - Signal a timeline semaphore on the host -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphore.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphore.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the semaphore.</param>
    /// <param name="pSignalInfo">
    ///     pSignalInfo is a pointer to a VkSemaphoreSignalInfostructure containing information about the
    ///     signal operation.
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
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkSignalSemaphore")]
    public static unsafe partial VkResult vkSignalSemaphore(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkSignalSemaphore")]
    public static extern unsafe VkResult vkSignalSemaphore(
#endif
        VkDevice               device,
        VkSemaphoreSignalInfo* pSignalInfo);

    /// <summary>
    ///     vkGetBufferDeviceAddress - Query an address of a buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that the buffer was created on.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkBufferDeviceAddressInfo structure specifying the buffer to retrieve an
    ///     address for.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetBufferDeviceAddress")]
    public static unsafe partial VkDeviceAddress vkGetBufferDeviceAddress(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetBufferDeviceAddress")]
    public static extern unsafe VkDeviceAddress vkGetBufferDeviceAddress(
#endif
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    /// <summary>
    ///     vkGetBufferOpaqueCaptureAddress - Query an opaque capture address of a buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddress.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddress.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that the buffer was created on.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkBufferDeviceAddressInfo structure specifying the buffer to retrieve an
    ///     address for.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
    public static unsafe partial ulong vkGetBufferOpaqueCaptureAddress(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
    public static extern unsafe ulong vkGetBufferOpaqueCaptureAddress(
#endif
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    /// <summary>
    ///     vkGetDeviceMemoryOpaqueCaptureAddress - Query an opaque capture address of a memory object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that the memory object was allocated on.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkDeviceMemoryOpaqueCaptureAddressInfo structure specifying the memory
    ///     object to retrieve an address for.
    /// </param>
    [VkVersion("1.2")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
    public static unsafe partial ulong vkGetDeviceMemoryOpaqueCaptureAddress(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
    public static extern unsafe ulong vkGetDeviceMemoryOpaqueCaptureAddress(
#endif
        VkDevice                                device,
        VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);
}