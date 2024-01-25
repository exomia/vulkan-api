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
///     VkPhysicalDeviceMeshShaderFeaturesEXT - Structure describing mesh shading features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMeshShaderFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     taskShader specifies whether task shaders are supported. If this feature is not enabled, the
    ///     VK_SHADER_STAGE_TASK_BIT_EXTand VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT enum values must not be used.
    /// </summary>
    public VkBool32 taskShader;

    /// <summary>
    ///     meshShader specifies whether mesh shaders are supported. If this feature is not enabled, the
    ///     VK_SHADER_STAGE_MESH_BIT_EXTand VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT enum values must not be used.
    /// </summary>
    public VkBool32 meshShader;

    /// <summary>
    ///     multiviewMeshShader specifies whether the implementation supports multiviewrendering within a render pass,
    ///     with mesh shaders. If this feature is not enabled, then a pipeline compiled against a subpass with a non-zero view
    ///     mask must not include a mesh shader.
    /// </summary>
    public VkBool32 multiviewMeshShader;

    /// <summary>
    ///     primitiveFragmentShadingRateMeshShader indicates that the implementation supports the primitive fragment
    ///     shading rate in mesh shaders.
    /// </summary>
    public VkBool32 primitiveFragmentShadingRateMeshShader;

    /// <summary>
    ///     meshShaderQueries indicates that the implementation supports creating query pools using the
    ///     VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT query type and statistic queries containing the
    ///     VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT and
    ///     VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT flags
    /// </summary>
    public VkBool32 meshShaderQueries;
}