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
///     VkPhysicalDeviceVulkan11Features - Structure describing the Vulkan 1.1 features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Features.html
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
public unsafe struct VkPhysicalDeviceVulkan11Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffer16BitAccess<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 storageBuffer16BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer16BitAccess<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 uniformAndStorageBuffer16BitAccess;

    /// <summary>
    ///     storagePushConstant16<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 storagePushConstant16;

    /// <summary>
    ///     storageInputOutput16<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 storageInputOutput16;

    /// <summary>
    ///     multiview<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 multiview;

    /// <summary>
    ///     multiviewGeometryShader<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 multiviewGeometryShader;

    /// <summary>
    ///     multiviewTessellationShader<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 multiviewTessellationShader;

    /// <summary>
    ///     variablePointersStorageBuffer<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 variablePointersStorageBuffer;

    /// <summary>
    ///     variablePointers<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 variablePointers;

    /// <summary>
    ///     protectedMemory<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 protectedMemory;

    /// <summary>
    ///     samplerYcbcrConversion<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 samplerYcbcrConversion;

    /// <summary>
    ///     shaderDrawParameters<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceVulkan11Features
    ///     </a>
    /// </summary>
    public VkBool32 shaderDrawParameters;
}