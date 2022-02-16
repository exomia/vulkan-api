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
///     VkPhysicalDeviceVulkan12Features - Structure describing the Vulkan 1.2 features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Features.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan12Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     samplerMirrorClampToEdge<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 samplerMirrorClampToEdge;

    /// <summary>
    ///     drawIndirectCount<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 drawIndirectCount;

    /// <summary>
    ///     storageBuffer8BitAccess<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 storageBuffer8BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer8BitAccess<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 uniformAndStorageBuffer8BitAccess;

    /// <summary>
    ///     storagePushConstant8<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 storagePushConstant8;

    /// <summary>
    ///     shaderBufferInt64Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderBufferInt64Atomics;

    /// <summary>
    ///     shaderSharedInt64Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderSharedInt64Atomics;

    /// <summary>
    ///     shaderFloat16<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderFloat16;

    /// <summary>
    ///     shaderInt8<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderInt8;

    /// <summary>
    ///     descriptorIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorIndexing;

    /// <summary>
    ///     shaderInputAttachmentArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderSampledImageArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderSampledImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageImageArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderInputAttachmentArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     descriptorBindingUniformBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingSampledImageUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingSampledImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageImageUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUniformTexelBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageTexelBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUpdateUnusedWhilePending<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUpdateUnusedWhilePending;

    /// <summary>
    ///     descriptorBindingPartiallyBound<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingPartiallyBound;

    /// <summary>
    ///     descriptorBindingVariableDescriptorCount<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingVariableDescriptorCount;

    /// <summary>
    ///     runtimeDescriptorArray<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 runtimeDescriptorArray;

    /// <summary>
    ///     samplerFilterMinmax<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 samplerFilterMinmax;

    /// <summary>
    ///     scalarBlockLayout<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 scalarBlockLayout;

    /// <summary>
    ///     imagelessFramebuffer<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 imagelessFramebuffer;

    /// <summary>
    ///     uniformBufferStandardLayout<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 uniformBufferStandardLayout;

    /// <summary>
    ///     shaderSubgroupExtendedTypes<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderSubgroupExtendedTypes;

    /// <summary>
    ///     separateDepthStencilLayouts<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 separateDepthStencilLayouts;

    /// <summary>
    ///     hostQueryReset<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 hostQueryReset;

    /// <summary>
    ///     timelineSemaphore<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 timelineSemaphore;

    /// <summary>
    ///     bufferDeviceAddress<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 bufferDeviceAddress;

    /// <summary>
    ///     bufferDeviceAddressCaptureReplay<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 bufferDeviceAddressCaptureReplay;

    /// <summary>
    ///     bufferDeviceAddressMultiDevice<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 bufferDeviceAddressMultiDevice;

    /// <summary>
    ///     vulkanMemoryModel<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 vulkanMemoryModel;

    /// <summary>
    ///     vulkanMemoryModelDeviceScope<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 vulkanMemoryModelDeviceScope;

    /// <summary>
    ///     vulkanMemoryModelAvailabilityVisibilityChains<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;

    /// <summary>
    ///     shaderOutputViewportIndex<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderOutputViewportIndex;

    /// <summary>
    ///     shaderOutputLayer<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderOutputLayer;

    /// <summary>
    ///     subgroupBroadcastDynamicId<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan12Features
    ///     </a>
    /// </summary>
    public VkBool32 subgroupBroadcastDynamicId;
}