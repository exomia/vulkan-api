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
///     VkPhysicalDeviceDescriptorIndexingFeatures - Structure describing descriptor indexing features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingFeatures.html
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
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderInputAttachmentArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayDynamicIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;

    /// <summary>
    ///     shaderUniformBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderSampledImageArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderSampledImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageImageArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageImageArrayNonUniformIndexing;

    /// <summary>
    ///     shaderInputAttachmentArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;

    /// <summary>
    ///     shaderUniformTexelBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     shaderStorageTexelBufferArrayNonUniformIndexing<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;

    /// <summary>
    ///     descriptorBindingUniformBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingSampledImageUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingSampledImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageImageUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageImageUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUniformTexelBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingStorageTexelBufferUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;

    /// <summary>
    ///     descriptorBindingUpdateUnusedWhilePending<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingUpdateUnusedWhilePending;

    /// <summary>
    ///     descriptorBindingPartiallyBound<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingPartiallyBound;

    /// <summary>
    ///     descriptorBindingVariableDescriptorCount<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingVariableDescriptorCount;

    /// <summary>
    ///     runtimeDescriptorArray<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceDescriptorIndexingFeatures
    ///     </a>
    /// </summary>
    public VkBool32 runtimeDescriptorArray;
}