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

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     storageBuffer16BitAccess specifies whether objects in the     StorageBuffer, ShaderRecordBufferKHR,     or
    ///     PhysicalStorageBuffer    storage class with the Block decoration can have 16-bit integer     and 16-bit
    ///     floating-point members.     If this feature is not enabled, 16-bit integer or 16-bit floating-point     members
    ///     must not be used in such objects.     This also specifies whether shader modules can declare the
    ///     StorageBuffer16BitAccess capability.
    /// </summary>
    public VkBool32 storageBuffer16BitAccess;

    /// <summary>
    ///     uniformAndStorageBuffer16BitAccess specifies whether objects in the Uniform storage class with the Block
    ///     decoration can have 16-bit integer and 16-bit floating-point members. If this feature is not enabled, 16-bit
    ///     integer or 16-bit floating-point members must not be used in such objects. This also specifies whether shader
    ///     modules can declare the UniformAndStorageBuffer16BitAccess capability.
    /// </summary>
    public VkBool32 uniformAndStorageBuffer16BitAccess;

    /// <summary>
    ///     storagePushConstant16 specifies whether objects in the PushConstant storage class can have 16-bit integer and
    ///     16-bit floating-point members. If this feature is not enabled, 16-bit integer or floating-point members must not be
    ///     used in such objects. This also specifies whether shader modules can declare the StoragePushConstant16 capability.
    /// </summary>
    public VkBool32 storagePushConstant16;

    /// <summary>
    ///     storageInputOutput16 specifies whether objects in the Inputand Output storage classes can have 16-bit integer
    ///     and 16-bit floating-point members. If this feature is not enabled, 16-bit integer or 16-bit floating-point members
    ///     must not be used in such objects. This also specifies whether shader modules can declare the StorageInputOutput16
    ///     capability.
    /// </summary>
    public VkBool32 storageInputOutput16;

    /// <summary>
    ///     multiview specifies whether the implementation supports multiview rendering within a render pass. If this
    ///     feature is not enabled, the view mask of each subpass mustalways be zero.
    /// </summary>
    public VkBool32 multiview;

    /// <summary>
    ///     multiviewGeometryShaderspecifies whether the implementation supports multiview rendering within a render
    ///     pass, with geometry shaders. If this feature is not enabled, then a pipeline compiled against a subpass with a
    ///     non-zero view mask must not include a geometry shader.
    /// </summary>
    public VkBool32 multiviewGeometryShader;

    /// <summary>
    ///     multiviewTessellationShader specifies whether the implementation supports multiview rendering within a render
    ///     pass, with tessellation shaders. If this feature is not enabled, then a pipeline compiled against a subpass with a
    ///     non-zero view mask must not include any tessellation shaders.
    /// </summary>
    public VkBool32 multiviewTessellationShader;

    /// <summary>
    ///     variablePointersStorageBuffer specifies whether the implementation supports the SPIR-V
    ///     VariablePointersStorageBuffer capability. When this feature is not enabled, shader modules must not declare the
    ///     SPV_KHR_variable_pointers extension or the VariablePointersStorageBuffer capability.
    /// </summary>
    public VkBool32 variablePointersStorageBuffer;

    /// <summary>
    ///     variablePointersspecifies whether the implementation supports the SPIR-V VariablePointers capability. When
    ///     this feature is not enabled, shader modules must not declare the VariablePointers capability.
    /// </summary>
    public VkBool32 variablePointers;

    /// <summary> protectedMemoryspecifies whether protected memory is supported.</summary>
    public VkBool32 protectedMemory;

    /// <summary>
    ///     samplerYcbcrConversion specifies whether the implementation supports sampler Y′CBCR conversion. If
    ///     samplerYcbcrConversion is VK_FALSE, sampler Y′CBCRconversion is not supported, and samplers using sampler
    ///     Y′CBCRconversion must not be used.
    /// </summary>
    public VkBool32 samplerYcbcrConversion;

    /// <summary>
    ///     shaderDrawParameters specifies whether the implementation supports the SPIR-V DrawParameters capability. When
    ///     this feature is not enabled, shader modules must not declare the SPV_KHR_shader_draw_parameters extension or the
    ///     DrawParameterscapability.
    /// </summary>
    public VkBool32 shaderDrawParameters;
}