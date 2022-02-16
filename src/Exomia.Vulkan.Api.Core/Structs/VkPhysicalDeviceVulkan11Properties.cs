#region License

// Copyright (c) 2018-2022, exomia
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
///     VkPhysicalDeviceVulkan11Properties - Structure specifying physical device properties for functionality
///     promoted to Vulkan 1.1 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Properties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Properties.html
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
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     deviceUUID is an array of VK_UUID_SIZE uint8_t values representing a universally unique identifier for the
    ///     device.
    /// </summary>
    public fixed byte deviceUUID[(int)VK_UUID_SIZE];

    /// <summary>
    ///     driverUUID is an array of VK_UUID_SIZE uint8_t values representing a universally unique identifier for the
    ///     driver build in use by the device.
    /// </summary>
    public fixed byte driverUUID[(int)VK_UUID_SIZE];

    /// <summary>deviceLUID is an array of VK_LUID_SIZE uint8_t values representing a locally unique identifier for the device.</summary>
    public fixed byte deviceLUID[(int)VK_LUID_SIZE];

    /// <summary>
    ///     deviceNodeMask is a uint32_t bitfield identifying the node within a linked device adapter corresponding to the
    ///     device.
    /// </summary>
    public uint deviceNodeMask;

    /// <summary>
    ///     deviceLUIDValid is a boolean value that will be VK_TRUE if deviceLUID contains a valid LUID and deviceNodeMask
    ///     contains a valid node mask, and VK_FALSE if they do not.
    /// </summary>
    public VkBool32 deviceLUIDValid;

    /// <summary>
    ///     subgroupSize is the default number of invocations in each subgroup. subgroupSize is at least 1 if any of the
    ///     physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or VK_QUEUE_COMPUTE_BIT. subgroupSize is a
    ///     power-of-two.
    /// </summary>
    public uint subgroupSize;

    /// <summary>
    ///     subgroupSupportedStages is a bitfield of VkShaderStageFlagBits describing the shader stages that group
    ///     operations with subgroup scope are supported in. subgroupSupportedStages will have the VK_SHADER_STAGE_COMPUTE_BIT
    ///     bit set if any of the physical device&#8217;s queues support VK_QUEUE_COMPUTE_BIT.
    /// </summary>
    public VkShaderStageFlags subgroupSupportedStages;

    /// <summary>
    ///     subgroupSupportedOperations is a bitmask of VkSubgroupFeatureFlagBits specifying the sets of group operations
    ///     with subgroup scope supported on this device. subgroupSupportedOperations will have the
    ///     VK_SUBGROUP_FEATURE_BASIC_BIT bit set if any of the physical device&#8217;s queues support VK_QUEUE_GRAPHICS_BIT or
    ///     VK_QUEUE_COMPUTE_BIT.
    /// </summary>
    public VkSubgroupFeatureFlags subgroupSupportedOperations;

    /// <summary>
    ///     subgroupQuadOperationsInAllStages is a boolean specifying whether quad group operations are available in all
    ///     stages, or are restricted to fragment and compute stages.
    /// </summary>
    public VkBool32 subgroupQuadOperationsInAllStages;

    /// <summary>
    ///     pointClippingBehavior is a VkPointClippingBehavior value specifying the point clipping behavior supported by
    ///     the implementation.
    /// </summary>
    public VkPointClippingBehavior pointClippingBehavior;

    /// <summary>maxMultiviewViewCount is one greater than the maximum view index that can be used in a subpass.</summary>
    public uint maxMultiviewViewCount;

    /// <summary>
    ///     maxMultiviewInstanceIndex is the maximum valid value of instance index allowed to be generated by a drawing
    ///     command recorded within a subpass of a multiview render pass instance.
    /// </summary>
    public uint maxMultiviewInstanceIndex;

    /// <summary>
    ///     protectedNoFaultspecifies how an implementation behaves when an application attempts to write to unprotected
    ///     memory in a protected queue operation, read from protected memory in an unprotected queue operation, or perform a
    ///     query in a protected queue operation. If this limit is VK_TRUE, such writes will be discarded or have undefined
    ///     values written, reads and queries will return undefined values. If this limit is VK_FALSE, applications must not
    ///     perform these operations. See [memory-protected-access-rules] for more information.
    /// </summary>
    public VkBool32 protectedNoFault;

    /// <summary>
    ///     maxPerSetDescriptors is a maximum number of descriptors (summed over all descriptor types) in a single
    ///     descriptor set that is guaranteed to satisfy any implementation-dependent constraints on the size of a descriptor
    ///     set itself. Applications can query whether a descriptor set that goes beyond this limit is supported using
    ///     vkGetDescriptorSetLayoutSupport.
    /// </summary>
    public uint maxPerSetDescriptors;

    /// <summary>
    ///     maxMemoryAllocationSize is the maximum size of a memory allocation that can be created, even if there is more
    ///     space available in the heap.
    /// </summary>
    public VkDeviceSize maxMemoryAllocationSize;
}