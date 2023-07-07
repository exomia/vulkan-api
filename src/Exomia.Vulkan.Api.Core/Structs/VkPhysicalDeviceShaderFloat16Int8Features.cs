#region License

// Copyright (c) 2018-2023, exomia
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
///     VkPhysicalDeviceShaderFloat16Int8Features - Structure describing features supported by VK_KHR_shader_float16_int8 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFloat16Int8Features.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFloat16Int8Features.html
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
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderFloat16 indicates whether 16-bit floats (halfs) are supported in shader code. This also indicates
    ///     whether shader modules can declare the Float16capability. However, this only enables a subset of the storage
    ///     classes that SPIR-V allows for the Float16 SPIR-V capability: Declaring and using 16-bit floats in the Private,
    ///     Workgroup (for non-Block variables), and Function storage classes is enabled, while declaring them in the interface
    ///     storage classes (e.g., UniformConstant, Uniform, StorageBuffer, Input, Output, and PushConstant) is not enabled.
    /// </summary>
    public VkBool32 shaderFloat16;

    /// <summary>
    ///     shaderInt8 indicates whether 8-bit integers (signed and unsigned) are supported in shader code. This also
    ///     indicates whether shader modules can declare the Int8capability. However, this only enables a subset of the storage
    ///     classes that SPIR-V allows for the Int8 SPIR-V capability: Declaring and using 8-bit integers in the Private,
    ///     Workgroup (for non-Block variables), and Function storage classes is enabled, while declaring them in the interface
    ///     storage classes (e.g., UniformConstant, Uniform, StorageBuffer, Input, Output, and PushConstant) is not enabled.
    /// </summary>
    public VkBool32 shaderInt8;
}