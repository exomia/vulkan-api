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
    ///     shaderBufferFloat32Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderBufferFloat32Atomics;

    /// <summary>
    ///     shaderBufferFloat32AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderBufferFloat32AtomicAdd;

    /// <summary>
    ///     shaderBufferFloat64Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderBufferFloat64Atomics;

    /// <summary>
    ///     shaderBufferFloat64AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderBufferFloat64AtomicAdd;

    /// <summary>
    ///     shaderSharedFloat32Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderSharedFloat32Atomics;

    /// <summary>
    ///     shaderSharedFloat32AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderSharedFloat32AtomicAdd;

    /// <summary>
    ///     shaderSharedFloat64Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderSharedFloat64Atomics;

    /// <summary>
    ///     shaderSharedFloat64AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderSharedFloat64AtomicAdd;

    /// <summary>
    ///     shaderImageFloat32Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderImageFloat32Atomics;

    /// <summary>
    ///     shaderImageFloat32AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 shaderImageFloat32AtomicAdd;

    /// <summary>
    ///     sparseImageFloat32Atomics<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 sparseImageFloat32Atomics;

    /// <summary>
    ///     sparseImageFloat32AtomicAdd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    ///     </a>
    /// </summary>
    public VkBool32 sparseImageFloat32AtomicAdd;
}