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
///     VkPhysicalDeviceShaderCorePropertiesAMD - Structure describing shader core properties that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCorePropertiesAMD.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCorePropertiesAMD.html
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
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     shaderEngineCount is an unsigned integer value indicating the number of shader engines found inside the
    ///     shader core of the physical device.
    /// </summary>
    public uint shaderEngineCount;

    /// <summary>
    ///     shaderArraysPerEngineCountis an unsigned integer value indicating the number of shader arrays inside a shader
    ///     engine. Each shader array has its own scan converter, set of compute units, and a render back end (color and depth
    ///     attachments). Shader arrays within a shader engine share shader processor input (wave launcher) and shader export
    ///     (export buffer) units. Currently, a shader engine can have one or two shader arrays.
    /// </summary>
    public uint shaderArraysPerEngineCount;

    /// <summary>
    ///     computeUnitsPerShaderArrayis an unsigned integer value indicating the physical number of compute units within
    ///     a shader array. The active number of compute units in a shader array may be lower. A compute unit houses a set of
    ///     SIMDs along with a sequencer module and a local data store.
    /// </summary>
    public uint computeUnitsPerShaderArray;

    /// <summary>
    ///     simdPerComputeUnit is an unsigned integer value indicating the number of SIMDs inside a compute unit. Each
    ///     SIMD processes a single instruction at a time.
    /// </summary>
    public uint simdPerComputeUnit;

    /// <summary>
    ///     wavefrontsPerSimd<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderCorePropertiesAMD">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceShaderCorePropertiesAMD
    ///     </a>
    /// </summary>
    public uint wavefrontsPerSimd;

    /// <summary> wavefrontSize is an unsigned integer value indicating the maximum size of a subgroup.</summary>
    public uint wavefrontSize;

    /// <summary>
    ///     sgprsPerSimd is an unsigned integer value indicating the number of physical Scalar General Purpose Registers
    ///     (SGPRs) per SIMD.
    /// </summary>
    public uint sgprsPerSimd;

    /// <summary> minSgprAllocation is an unsigned integer value indicating the minimum number of SGPRs allocated for a wave.</summary>
    public uint minSgprAllocation;

    /// <summary> maxSgprAllocation is an unsigned integer value indicating the maximum number of SGPRs allocated for a wave.</summary>
    public uint maxSgprAllocation;

    /// <summary>
    ///     sgprAllocationGranularity is an unsigned integer value indicating the granularity of SGPR allocation for a
    ///     wave.
    /// </summary>
    public uint sgprAllocationGranularity;

    /// <summary>
    ///     vgprsPerSimd is an unsigned integer value indicating the number of physical Vector General Purpose Registers
    ///     (VGPRs) per SIMD.
    /// </summary>
    public uint vgprsPerSimd;

    /// <summary> minVgprAllocation is an unsigned integer value indicating the minimum number of VGPRs allocated for a wave.</summary>
    public uint minVgprAllocation;

    /// <summary> maxVgprAllocation is an unsigned integer value indicating the maximum number of VGPRs allocated for a wave.</summary>
    public uint maxVgprAllocation;

    /// <summary>
    ///     vgprAllocationGranularity is an unsigned integer value indicating the granularity of VGPR allocation for a
    ///     wave.
    /// </summary>
    public uint vgprAllocationGranularity;
}