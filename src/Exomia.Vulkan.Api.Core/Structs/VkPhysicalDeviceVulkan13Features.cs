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
///     VkPhysicalDeviceVulkan13Features - Structure describing the Vulkan 1.3 features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Features.html
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
public unsafe struct VkPhysicalDeviceVulkan13Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     robustImageAccess<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 robustImageAccess;

    /// <summary>
    ///     inlineUniformBlock<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 inlineUniformBlock;

    /// <summary>
    ///     descriptorBindingInlineUniformBlockUpdateAfterBind<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;

    /// <summary>
    ///     pipelineCreationCacheControl<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 pipelineCreationCacheControl;

    /// <summary>
    ///     privateData<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 privateData;

    /// <summary>
    ///     shaderDemoteToHelperInvocation<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderDemoteToHelperInvocation;

    /// <summary>
    ///     shaderTerminateInvocation<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderTerminateInvocation;

    /// <summary>
    ///     subgroupSizeControl<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 subgroupSizeControl;

    /// <summary>
    ///     computeFullSubgroups<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 computeFullSubgroups;

    /// <summary>
    ///     synchronization2<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 synchronization2;

    /// <summary>
    ///     textureCompressionASTC_HDR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 textureCompressionASTC_HDR;

    /// <summary>
    ///     shaderZeroInitializeWorkgroupMemory<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderZeroInitializeWorkgroupMemory;

    /// <summary>
    ///     dynamicRendering<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 dynamicRendering;

    /// <summary>
    ///     shaderIntegerDotProduct<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderIntegerDotProduct;

    /// <summary>
    ///     maintenance4<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan13Features
    ///     </a>
    /// </summary>
    public VkBool32 maintenance4;
}