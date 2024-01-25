#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

namespace Exomia.Vulkan.Api.Core;

using System.Security;

/// <content>
///     VK_VERSION_1_1 - vulkan,vulkansc
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     vkEnumerateInstanceVersion - Query instance-level version before instance creation -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceVersion.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceVersion.html</a>
    /// </summary>
    /// <param name="pApiVersion">
    ///     pApiVersion is a pointer to a uint32_t, which is the version of Vulkan supported by
    ///     instance-level functionality, encoded as described in
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#extendingvulkan-coreversions-versionnumbers.
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
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkEnumerateInstanceVersion")]
    public static unsafe partial VkResult vkEnumerateInstanceVersion(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumerateInstanceVersion")]
    public static extern unsafe VkResult vkEnumerateInstanceVersion(
#endif
        VkVersion* pApiVersion);

    /// <summary>
    ///     vkBindBufferMemory2 - Bind device memory to buffer objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffers and memory.</param>
    /// <param name="bindInfoCount">bindInfoCount is the number of elements in pBindInfos.</param>
    /// <param name="pBindInfos">
    ///     pBindInfos is a pointer to an array of bindInfoCountVkBindBufferMemoryInfo structures
    ///     describing buffers and memory to bind.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkBindBufferMemory2")]
    public static unsafe partial VkResult vkBindBufferMemory2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkBindBufferMemory2")]
    public static extern unsafe VkResult vkBindBufferMemory2(
#endif
        VkDevice                device,
        uint                    bindInfoCount,
        VkBindBufferMemoryInfo* pBindInfos);

    /// <summary>
    ///     vkBindImageMemory2 - Bind device memory to image objects -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the images and memory.</param>
    /// <param name="bindInfoCount">bindInfoCount is the number of elements in pBindInfos.</param>
    /// <param name="pBindInfos">
    ///     pBindInfos is a pointer to an array of VkBindImageMemoryInfostructures, describing images and
    ///     memory to bind.
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
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkBindImageMemory2")]
    public static unsafe partial VkResult vkBindImageMemory2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkBindImageMemory2")]
    public static extern unsafe VkResult vkBindImageMemory2(
#endif
        VkDevice               device,
        uint                   bindInfoCount,
        VkBindImageMemoryInfo* pBindInfos);

    /// <summary>
    ///     vkGetDeviceGroupPeerMemoryFeatures - Query supported peer memory features of a device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeatures.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeatures.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the memory.</param>
    /// <param name="heapIndex">heapIndex is the index of the memory heap from which the memory is allocated.</param>
    /// <param name="localDeviceIndex">
    ///     localDeviceIndex is the device index of the physical device that performs the memory
    ///     access.
    /// </param>
    /// <param name="remoteDeviceIndex">
    ///     remoteDeviceIndex is the device index of the physical device that the memory is
    ///     allocated for.
    /// </param>
    /// <param name="pPeerMemoryFeatures">
    ///     pPeerMemoryFeatures is a pointer to a VkPeerMemoryFeatureFlags bitmask indicating
    ///     which types of memory accesses are supported for the combination of heap, local, and remote devices.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
    public static unsafe partial void vkGetDeviceGroupPeerMemoryFeatures(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
    public static extern unsafe void vkGetDeviceGroupPeerMemoryFeatures(
#endif
        VkDevice                  device,
        uint                      heapIndex,
        uint                      localDeviceIndex,
        uint                      remoteDeviceIndex,
        VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

    /// <summary>
    ///     vkCmdSetDeviceMask - Modify device mask of a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMask.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMask.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is command buffer whose current device mask is modified.</param>
    /// <param name="deviceMask">deviceMask is the new value of the current device mask.</param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdSetDeviceMask")]
    public static unsafe partial void vkCmdSetDeviceMask(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdSetDeviceMask")]
    public static extern void vkCmdSetDeviceMask(
#endif
        VkCommandBuffer commandBuffer,
        uint            deviceMask);

    /// <summary>
    ///     vkCmdDispatchBase - Dispatch compute work items with non-zero base values for the workgroup IDs -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="baseGroupX">baseGroupX is the start value for the X component of WorkgroupId.</param>
    /// <param name="baseGroupY">baseGroupY is the start value for the Y component of WorkgroupId.</param>
    /// <param name="baseGroupZ">baseGroupZ is the start value for the Z component of WorkgroupId.</param>
    /// <param name="groupCountX">groupCountX is the number of local workgroups to dispatch in the X dimension.</param>
    /// <param name="groupCountY">groupCountY is the number of local workgroups to dispatch in the Y dimension.</param>
    /// <param name="groupCountZ">groupCountZ is the number of local workgroups to dispatch in the Z dimension.</param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCmdDispatchBase")]
    public static unsafe partial void vkCmdDispatchBase(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCmdDispatchBase")]
    public static extern void vkCmdDispatchBase(
#endif
        VkCommandBuffer commandBuffer,
        uint            baseGroupX,
        uint            baseGroupY,
        uint            baseGroupZ,
        uint            groupCountX,
        uint            groupCountY,
        uint            groupCountZ);

    /// <summary>
    ///     vkEnumeratePhysicalDeviceGroups - Enumerates groups of physical devices that can be used to create a single
    ///     logical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroups.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroups.html
    ///     </a>
    /// </summary>
    /// <param name="instance">instance is a handle to a Vulkan instance previously created with vkCreateInstance.</param>
    /// <param name="pPhysicalDeviceGroupCount">
    ///     pPhysicalDeviceGroupCount is a pointer to an integer related to the number of
    ///     device groups available or queried, as described below.
    /// </param>
    /// <param name="pPhysicalDeviceGroupProperties">
    ///     pPhysicalDeviceGroupProperties is either NULL or a pointer to an array of
    ///     VkPhysicalDeviceGroupProperties structures.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
    public static unsafe partial VkResult vkEnumeratePhysicalDeviceGroups(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
    public static extern unsafe VkResult vkEnumeratePhysicalDeviceGroups(
#endif
        VkInstance                       instance,
        uint*                            pPhysicalDeviceGroupCount,
        VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

    /// <summary>
    ///     vkGetImageMemoryRequirements2 - Returns the memory requirements for specified Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkImageMemoryRequirementsInfo2structure containing parameters required for
    ///     the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the image object are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetImageMemoryRequirements2")]
    public static unsafe partial void vkGetImageMemoryRequirements2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetImageMemoryRequirements2")]
    public static extern unsafe void vkGetImageMemoryRequirements2(
#endif
        VkDevice                        device,
        VkImageMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*          pMemoryRequirements);

    /// <summary>
    ///     vkGetBufferMemoryRequirements2 - Returns the memory requirements for specified Vulkan object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the buffer.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkBufferMemoryRequirementsInfo2structure containing parameters required for
    ///     the memory requirements query.
    /// </param>
    /// <param name="pMemoryRequirements">
    ///     pMemoryRequirements is a pointer to a VkMemoryRequirements2structure in which the
    ///     memory requirements of the buffer object are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetBufferMemoryRequirements2")]
    public static unsafe partial void vkGetBufferMemoryRequirements2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetBufferMemoryRequirements2")]
    public static extern unsafe void vkGetBufferMemoryRequirements2(
#endif
        VkDevice                         device,
        VkBufferMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*           pMemoryRequirements);

    /// <summary>
    ///     vkGetImageSparseMemoryRequirements2 - Query the memory requirements for a sparse image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkImageSparseMemoryRequirementsInfo2structure containing parameters
    ///     required for the memory requirements query.
    /// </param>
    /// <param name="pSparseMemoryRequirementCount">
    ///     pSparseMemoryRequirementCount is a pointer to an integer related to the
    ///     number of sparse memory requirements available or queried, as described below.
    /// </param>
    /// <param name="pSparseMemoryRequirements">
    ///     pSparseMemoryRequirements is either NULL or a pointer to an array of
    ///     VkSparseImageMemoryRequirements2 structures.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements2")]
    public static unsafe partial void vkGetImageSparseMemoryRequirements2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements2")]
    public static extern unsafe void vkGetImageSparseMemoryRequirements2(
#endif
        VkDevice                              device,
        VkImageSparseMemoryRequirementsInfo2* pInfo,
        uint*                                 pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements2*     pSparseMemoryRequirements);

    /// <summary>
    ///     vkGetPhysicalDeviceFeatures2 - Reports capabilities of a physical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the supported features.</param>
    /// <param name="pFeatures">
    ///     pFeatures is a pointer to a VkPhysicalDeviceFeatures2structure in which the physical device
    ///     features are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures2")]
    public static unsafe partial void vkGetPhysicalDeviceFeatures2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures2")]
    public static extern unsafe void vkGetPhysicalDeviceFeatures2(
#endif
        VkPhysicalDevice           physicalDevice,
        VkPhysicalDeviceFeatures2* pFeatures);

    /// <summary>
    ///     vkGetPhysicalDeviceProperties2 - Returns properties of a physical device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device whose properties will be queried.</param>
    /// <param name="pProperties">
    ///     pProperties is a pointer to a VkPhysicalDeviceProperties2structure in which properties are
    ///     returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties2")]
    public static unsafe partial void vkGetPhysicalDeviceProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties2")]
    public static extern unsafe void vkGetPhysicalDeviceProperties2(
#endif
        VkPhysicalDevice             physicalDevice,
        VkPhysicalDeviceProperties2* pProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceFormatProperties2 - Lists physical device's format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the format properties.</param>
    /// <param name="format">format is the format whose properties are queried.</param>
    /// <param name="pFormatProperties">
    ///     pFormatProperties is a pointer to a VkFormatProperties2structure in which physical
    ///     device properties for format are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
    public static unsafe partial void vkGetPhysicalDeviceFormatProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
    public static extern unsafe void vkGetPhysicalDeviceFormatProperties2(
#endif
        VkPhysicalDevice     physicalDevice,
        VkFormat             format,
        VkFormatProperties2* pFormatProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceImageFormatProperties2 - Lists physical device's image format capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the image capabilities.</param>
    /// <param name="pImageFormatInfo">
    ///     pImageFormatInfo is a pointer to a VkPhysicalDeviceImageFormatInfo2 structure describing
    ///     the parameters that would be consumed by vkCreateImage.
    /// </param>
    /// <param name="pImageFormatProperties">
    ///     pImageFormatProperties is a pointer to a VkImageFormatProperties2 structure in
    ///     which capabilities are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_FORMAT_NOT_SUPPORTED,VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR,VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
    public static unsafe partial VkResult vkGetPhysicalDeviceImageFormatProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
    public static extern unsafe VkResult vkGetPhysicalDeviceImageFormatProperties2(
#endif
        VkPhysicalDevice                  physicalDevice,
        VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo,
        VkImageFormatProperties2*         pImageFormatProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceQueueFamilyProperties2 - Reports properties of the queues of the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the physical device whose properties will be queried.</param>
    /// <param name="pQueueFamilyPropertyCount">
    ///     pQueueFamilyPropertyCount is a pointer to an integer related to the number of
    ///     queue families available or queried, as described in vkGetPhysicalDeviceQueueFamilyProperties.
    /// </param>
    /// <param name="pQueueFamilyProperties">
    ///     pQueueFamilyProperties is either NULL or a pointer to an array of
    ///     VkQueueFamilyProperties2 structures.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
    public static unsafe partial void vkGetPhysicalDeviceQueueFamilyProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
    public static extern unsafe void vkGetPhysicalDeviceQueueFamilyProperties2(
#endif
        VkPhysicalDevice          physicalDevice,
        uint*                     pQueueFamilyPropertyCount,
        VkQueueFamilyProperties2* pQueueFamilyProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceMemoryProperties2 - Reports memory information for the specified physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the handle to the device to query.</param>
    /// <param name="pMemoryProperties">
    ///     pMemoryProperties is a pointer to a VkPhysicalDeviceMemoryProperties2 structure in
    ///     which the properties are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
    public static unsafe partial void vkGetPhysicalDeviceMemoryProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
    public static extern unsafe void vkGetPhysicalDeviceMemoryProperties2(
#endif
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceSparseImageFormatProperties2 - Retrieve properties of an image format applied to sparse images -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device from which to query the sparse image format
    ///     properties.
    /// </param>
    /// <param name="pFormatInfo">
    ///     pFormatInfo is a pointer to a VkPhysicalDeviceSparseImageFormatInfo2 structure containing
    ///     input parameters to the command.
    /// </param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of sparse format
    ///     properties available or queried, as described below.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is either NULL or a pointer to an array of VkSparseImageFormatProperties2
    ///     structures.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
    public static unsafe partial void vkGetPhysicalDeviceSparseImageFormatProperties2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
    public static extern unsafe void vkGetPhysicalDeviceSparseImageFormatProperties2(
#endif
        VkPhysicalDevice                        physicalDevice,
        VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
        uint*                                   pPropertyCount,
        VkSparseImageFormatProperties2*         pProperties);

    /// <summary>
    ///     vkTrimCommandPool - Trim a command pool -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPool.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPool.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the command pool.</param>
    /// <param name="commandPool">commandPool is the command pool to trim.</param>
    /// <param name="flags">flags is reserved for future use.</param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkTrimCommandPool")]
    public static unsafe partial void vkTrimCommandPool(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkTrimCommandPool")]
    public static extern void vkTrimCommandPool(
#endif
        VkDevice               device,
        VkCommandPool          commandPool,
        VkCommandPoolTrimFlags flags);

    /// <summary>
    ///     vkGetDeviceQueue2 - Get a queue handle from a device -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue2.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the queue.</param>
    /// <param name="pQueueInfo">
    ///     pQueueInfo is a pointer to a VkDeviceQueueInfo2 structure, describing parameters of the device
    ///     queue to be retrieved.
    /// </param>
    /// <param name="pQueue">
    ///     pQueue is a pointer to a VkQueue object that will be filled with the handle for the requested
    ///     queue.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetDeviceQueue2")]
    public static unsafe partial void vkGetDeviceQueue2(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDeviceQueue2")]
    public static extern unsafe void vkGetDeviceQueue2(
#endif
        VkDevice            device,
        VkDeviceQueueInfo2* pQueueInfo,
        VkQueue*            pQueue);

    /// <summary>
    ///     vkCreateSamplerYcbcrConversion - Create a new Y′CBCR conversion -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversion.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversion.html</a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the sampler Y′CBCRconversion.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkSamplerYcbcrConversionCreateInfo structure specifying the
    ///     requested sampler Y′CBCR conversion.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pYcbcrConversion">
    ///     pYcbcrConversion is a pointer to a VkSamplerYcbcrConversionhandle in which the resulting
    ///     sampler Y′CBCR conversion is returned.
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
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCreateSamplerYcbcrConversion")]
    public static unsafe partial VkResult vkCreateSamplerYcbcrConversion(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateSamplerYcbcrConversion")]
    public static extern unsafe VkResult vkCreateSamplerYcbcrConversion(
#endif
        VkDevice                            device,
        VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkSamplerYcbcrConversion*           pYcbcrConversion);

    /// <summary>
    ///     vkDestroySamplerYcbcrConversion - Destroy a created Y′CBCR conversion -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversion.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversion.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that destroys the Y′CBCR conversion.</param>
    /// <param name="ycbcrConversion">ycbcrConversion is the conversion to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkDestroySamplerYcbcrConversion")]
    public static unsafe partial void vkDestroySamplerYcbcrConversion(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroySamplerYcbcrConversion")]
    public static extern unsafe void vkDestroySamplerYcbcrConversion(
#endif
        VkDevice                 device,
        VkSamplerYcbcrConversion ycbcrConversion,
        VkAllocationCallbacks*   pAllocator);

    /// <summary>
    ///     vkCreateDescriptorUpdateTemplate - Create a new descriptor update template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplate.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplate.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that creates the descriptor update template.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDescriptorUpdateTemplateCreateInfo structure specifying the
    ///     set of descriptors to update with a single call to vkCmdPushDescriptorSetWithTemplateKHR or
    ///     vkUpdateDescriptorSetWithTemplate.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pDescriptorUpdateTemplate">
    ///     pDescriptorUpdateTemplate is a pointer to a VkDescriptorUpdateTemplate handle
    ///     in which the resulting descriptor update template object is returned.
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
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkCreateDescriptorUpdateTemplate")]
    public static unsafe partial VkResult vkCreateDescriptorUpdateTemplate(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkCreateDescriptorUpdateTemplate")]
    public static extern unsafe VkResult vkCreateDescriptorUpdateTemplate(
#endif
        VkDevice                              device,
        VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
        VkAllocationCallbacks*                pAllocator,
        VkDescriptorUpdateTemplate*           pDescriptorUpdateTemplate);

    /// <summary>
    ///     vkDestroyDescriptorUpdateTemplate - Destroy a descriptor update template object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplate.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplate.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that has been used to create the descriptor update template</param>
    /// <param name="descriptorUpdateTemplate">descriptorUpdateTemplate is the descriptor update template to destroy.</param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
    public static unsafe partial void vkDestroyDescriptorUpdateTemplate(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
    public static extern unsafe void vkDestroyDescriptorUpdateTemplate(
#endif
        VkDevice                   device,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        VkAllocationCallbacks*     pAllocator);

    /// <summary>
    ///     vkUpdateDescriptorSetWithTemplate - Update the contents of a descriptor set object using an update template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplate.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplate.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that updates the descriptor set.</param>
    /// <param name="descriptorSet">descriptorSet is the descriptor set to update</param>
    /// <param name="descriptorUpdateTemplate">
    ///     descriptorUpdateTemplate is a VkDescriptorUpdateTemplateobject specifying the
    ///     update mapping between pData and the descriptor set to update.
    /// </param>
    /// <param name="pData">
    ///     pData is a pointer to memory containing one or more     VkDescriptorImageInfo,
    ///     VkDescriptorBufferInfo, or     VkBufferView structures or VkAccelerationStructureKHRor
    ///     VkAccelerationStructureNVhandles     used to write the descriptors.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
    public static unsafe partial void vkUpdateDescriptorSetWithTemplate(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
    public static extern unsafe void vkUpdateDescriptorSetWithTemplate(
#endif
        VkDevice                   device,
        VkDescriptorSet            descriptorSet,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        void*                      pData);

    /// <summary>
    ///     vkGetPhysicalDeviceExternalBufferProperties - Query external handle types supported by buffers -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the buffer capabilities.</param>
    /// <param name="pExternalBufferInfo">
    ///     pExternalBufferInfo is a pointer to a VkPhysicalDeviceExternalBufferInfo structure
    ///     describing the parameters that would be consumed by vkCreateBuffer.
    /// </param>
    /// <param name="pExternalBufferProperties">
    ///     pExternalBufferProperties is a pointer to a VkExternalBufferProperties
    ///     structure in which capabilities are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
    public static unsafe partial void vkGetPhysicalDeviceExternalBufferProperties(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
    public static extern unsafe void vkGetPhysicalDeviceExternalBufferProperties(
#endif
        VkPhysicalDevice                    physicalDevice,
        VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
        VkExternalBufferProperties*         pExternalBufferProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceExternalFenceProperties - Function for querying external fence handle capabilities. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFenceProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFenceProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the fence capabilities.</param>
    /// <param name="pExternalFenceInfo">
    ///     pExternalFenceInfo is a pointer to a VkPhysicalDeviceExternalFenceInfo structure
    ///     describing the parameters that would be consumed by vkCreateFence.
    /// </param>
    /// <param name="pExternalFenceProperties">
    ///     pExternalFenceProperties is a pointer to a VkExternalFenceProperties structure
    ///     in which capabilities are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
    public static unsafe partial void vkGetPhysicalDeviceExternalFenceProperties(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
    public static extern unsafe void vkGetPhysicalDeviceExternalFenceProperties(
#endif
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
        VkExternalFenceProperties*         pExternalFenceProperties);

    /// <summary>
    ///     vkGetPhysicalDeviceExternalSemaphoreProperties - Function for querying external semaphore handle capabilities. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphoreProperties.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphoreProperties.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device from which to query the semaphore capabilities.</param>
    /// <param name="pExternalSemaphoreInfo">
    ///     pExternalSemaphoreInfo is a pointer to a VkPhysicalDeviceExternalSemaphoreInfo
    ///     structure describing the parameters that would be consumed by vkCreateSemaphore.
    /// </param>
    /// <param name="pExternalSemaphoreProperties">
    ///     pExternalSemaphoreProperties is a pointer to a VkExternalSemaphoreProperties
    ///     structure in which capabilities are returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
    public static unsafe partial void vkGetPhysicalDeviceExternalSemaphoreProperties(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
    public static extern unsafe void vkGetPhysicalDeviceExternalSemaphoreProperties(
#endif
        VkPhysicalDevice                       physicalDevice,
        VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
        VkExternalSemaphoreProperties*         pExternalSemaphoreProperties);

    /// <summary>
    ///     vkGetDescriptorSetLayoutSupport - Query whether a descriptor set layout can be created -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupport.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupport.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that would create the descriptor set layout.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDescriptorSetLayoutCreateInfo structure specifying the state
    ///     of the descriptor set layout object.
    /// </param>
    /// <param name="pSupport">
    ///     pSupport is a pointer to a VkDescriptorSetLayoutSupportstructure, in which information about
    ///     support for the descriptor set layout object is returned.
    /// </param>
    [VkVersion("1.1")]
    [SuppressUnmanagedCodeSecurity]
#if NET7_0_OR_GREATER
    [LibraryImport(VK_IMPORT, EntryPoint = "vkGetDescriptorSetLayoutSupport")]
    public static unsafe partial void vkGetDescriptorSetLayoutSupport(
#else
    [DllImport(VK_IMPORT, EntryPoint = "vkGetDescriptorSetLayoutSupport")]
    public static extern unsafe void vkGetDescriptorSetLayoutSupport(
#endif
        VkDevice                         device,
        VkDescriptorSetLayoutCreateInfo* pCreateInfo,
        VkDescriptorSetLayoutSupport*    pSupport);
}