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
///     VkPhysicalDeviceMeshShaderFeaturesNV - Structure describing mesh shading features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesNV.html
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
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     taskShader specifies whether task shaders are supported. If this feature is not enabled, the
    ///     VK_SHADER_STAGE_TASK_BIT_NVand VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV enum values must not be used.
    /// </summary>
    public VkBool32 taskShader;

    /// <summary>
    ///     meshShader specifies whether mesh shaders are supported. If this feature is not enabled, the
    ///     VK_SHADER_STAGE_MESH_BIT_NVand VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV enum values must not be used.
    /// </summary>
    public VkBool32 meshShader;
}