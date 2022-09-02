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
///     VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT - Structure describing features supported by
///     VK_EXT_shader_atomic_float2 -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderBufferFloat16Atomicsindicates whether shaders can perform 16-bit floating-point load, store, and
    ///     exchange atomic operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat16Atomics;

    /// <summary>
    ///     shaderBufferFloat16AtomicAdd indicates whether shaders canperform 16-bit floating-point add atomic operations
    ///     on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat16AtomicAdd;

    /// <summary>
    ///     shaderBufferFloat16AtomicMinMax indicates whether shaders canperform 16-bit floating-point min and max atomic
    ///     operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat16AtomicMinMax;

    /// <summary>
    ///     shaderBufferFloat32AtomicMinMax indicates whether shaders canperform 32-bit floating-point min and max atomic
    ///     operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat32AtomicMinMax;

    /// <summary>
    ///     shaderBufferFloat64AtomicMinMax indicates whether shaders canperform 64-bit floating-point min and max atomic
    ///     operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat64AtomicMinMax;

    /// <summary>
    ///     shaderSharedFloat16Atomicsindicates whether shaders can perform 16-bit floating-point load, store and
    ///     exchange atomic operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat16Atomics;

    /// <summary>
    ///     shaderSharedFloat16AtomicAdd indicates whether shaders canperform 16-bit floating-point add atomic operations
    ///     on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat16AtomicAdd;

    /// <summary>
    ///     shaderSharedFloat16AtomicMinMax indicates whether shaders canperform 16-bit floating-point min and max atomic
    ///     operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat16AtomicMinMax;

    /// <summary>
    ///     shaderSharedFloat32AtomicMinMax indicates whether shaders canperform 32-bit floating-point min and max atomic
    ///     operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat32AtomicMinMax;

    /// <summary>
    ///     shaderSharedFloat64AtomicMinMax indicates whether shaders canperform 64-bit floating-point min and max atomic
    ///     operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat64AtomicMinMax;

    /// <summary>
    ///     shaderImageFloat32AtomicMinMax indicates whether shaders canperform 32-bit floating-point min and max atomic
    ///     image operations.
    /// </summary>
    public VkBool32 shaderImageFloat32AtomicMinMax;

    /// <summary>
    ///     sparseImageFloat32AtomicMinMax indicates whether 32-bit floating-point min and max atomic operations can be
    ///     used on sparse images.
    /// </summary>
    public VkBool32 sparseImageFloat32AtomicMinMax;
}