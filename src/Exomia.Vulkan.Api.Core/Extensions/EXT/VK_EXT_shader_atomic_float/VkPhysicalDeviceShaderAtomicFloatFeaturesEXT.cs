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
///     VkPhysicalDeviceShaderAtomicFloatFeaturesEXT - Structure describing features supported by
///     VK_EXT_shader_atomic_float -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloatFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloatFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderBufferFloat32Atomicsindicates whether shaders can perform 32-bit floating-point load, store and
    ///     exchange atomic operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat32Atomics;

    /// <summary>
    ///     shaderBufferFloat32AtomicAdd indicates whether shaders canperform 32-bit floating-point add atomic operations
    ///     on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat32AtomicAdd;

    /// <summary>
    ///     shaderBufferFloat64Atomicsindicates whether shaders can perform 64-bit floating-point load, store and
    ///     exchange atomic operations on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat64Atomics;

    /// <summary>
    ///     shaderBufferFloat64AtomicAdd indicates whether shaders canperform 64-bit floating-point add atomic operations
    ///     on storage buffers.
    /// </summary>
    public VkBool32 shaderBufferFloat64AtomicAdd;

    /// <summary>
    ///     shaderSharedFloat32Atomicsindicates whether shaders can perform 32-bit floating-point load, store and
    ///     exchange atomic operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat32Atomics;

    /// <summary>
    ///     shaderSharedFloat32AtomicAdd indicates whether shaders canperform 32-bit floating-point add atomic operations
    ///     on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat32AtomicAdd;

    /// <summary>
    ///     shaderSharedFloat64Atomicsindicates whether shaders can perform 64-bit floating-point load, store and
    ///     exchange atomic operations on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat64Atomics;

    /// <summary>
    ///     shaderSharedFloat64AtomicAdd indicates whether shaders canperform 64-bit floating-point add atomic operations
    ///     on shared and payload memory.
    /// </summary>
    public VkBool32 shaderSharedFloat64AtomicAdd;

    /// <summary>
    ///     shaderImageFloat32Atomicsindicates whether shaders can perform 32-bit floating-point load, store and exchange
    ///     atomic image operations.
    /// </summary>
    public VkBool32 shaderImageFloat32Atomics;

    /// <summary>
    ///     shaderImageFloat32AtomicAdd indicates whether shaders can perform 32-bit floating-point add atomic image
    ///     operations.
    /// </summary>
    public VkBool32 shaderImageFloat32AtomicAdd;

    /// <summary>
    ///     sparseImageFloat32Atomicsindicates whether 32-bit floating-point load, store and exchange atomic operations
    ///     can be used on sparse images.
    /// </summary>
    public VkBool32 sparseImageFloat32Atomics;

    /// <summary>
    ///     sparseImageFloat32AtomicAdd indicates whether 32-bit floating-point add atomic operations can be used on
    ///     sparse images.
    /// </summary>
    public VkBool32 sparseImageFloat32AtomicAdd;
}