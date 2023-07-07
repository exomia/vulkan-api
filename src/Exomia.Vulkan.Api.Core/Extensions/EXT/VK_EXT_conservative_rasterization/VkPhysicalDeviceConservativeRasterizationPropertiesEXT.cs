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
///     VkPhysicalDeviceConservativeRasterizationPropertiesEXT - Structure describing conservative raster properties that
///     can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceConservativeRasterizationPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceConservativeRasterizationPropertiesEXT.html
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
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     primitiveOverestimationSizeis the size in pixels the generating primitive is increased at each of its edges
    ///     during conservative rasterization overestimation mode. Even with a size of 0.0, conservative rasterization
    ///     overestimation rules still apply and if any part of the pixel rectangle is covered by the generating primitive,
    ///     fragments are generated for the entire pixel. However implementations may make the pixel coverage area even more
    ///     conservative by increasing the size of the generating primitive.
    /// </summary>
    public float primitiveOverestimationSize;

    /// <summary>
    ///     maxExtraPrimitiveOverestimationSize is the maximum size in pixels of extra overestimation the implementation
    ///     supports in the pipeline state. A value of 0.0 means the implementation does not support any additional
    ///     overestimation of the generating primitive during conservative rasterization. A value above 0.0 allows the
    ///     application to further increase the size of the generating primitive during conservative rasterization
    ///     overestimation.
    /// </summary>
    public float maxExtraPrimitiveOverestimationSize;

    /// <summary>
    ///     extraPrimitiveOverestimationSizeGranularity is the granularity of extra overestimation that can be specified
    ///     in the pipeline state between 0.0 and maxExtraPrimitiveOverestimationSize inclusive. A value of 0.0 means the
    ///     implementation can use the smallest representable non-zero value in the screen space pixel fixed-point grid.
    /// </summary>
    public float extraPrimitiveOverestimationSizeGranularity;

    /// <summary>
    ///     primitiveUnderestimation is VK_TRUE if the implementation supports the
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT conservative rasterization mode in addition to
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT. Otherwise the implementation only supports
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT.
    /// </summary>
    public VkBool32 primitiveUnderestimation;

    /// <summary>
    ///     conservativePointAndLineRasterization is VK_TRUE if the implementation supports conservative rasterization of
    ///     point and line primitives as well as triangle primitives. Otherwise the implementation only supports triangle
    ///     primitives.
    /// </summary>
    public VkBool32 conservativePointAndLineRasterization;

    /// <summary>
    ///     degenerateTrianglesRasterized is VK_FALSE if the implementation culls primitives generated from triangles that
    ///     become zero area after they are quantized to the fixed-point rasterization pixel grid.
    ///     degenerateTrianglesRasterized is VK_TRUE if these primitives are not culled and the provoking vertex attributes and
    ///     depth value are used for the fragments. The primitive area calculation is done on the primitive generated from the
    ///     clipped triangle if applicable. Zero area primitives are backfacing and the application can enable backface culling
    ///     if desired.
    /// </summary>
    public VkBool32 degenerateTrianglesRasterized;

    /// <summary>
    ///     degenerateLinesRasterized is VK_FALSE if the implementation culls lines that become zero length after they
    ///     are quantized to the fixed-point rasterization pixel grid. degenerateLinesRasterized is VK_TRUE if zero length
    ///     lines are not culled and the provoking vertex attributes and depth value are used for the fragments.
    /// </summary>
    public VkBool32 degenerateLinesRasterized;

    /// <summary>
    ///     fullyCoveredFragmentShaderInputVariable is VK_TRUE if the implementation supports the SPIR-V builtin fragment
    ///     shader input variable FullyCoveredEXT specifying that conservative rasterization is enabled and the fragment area
    ///     is fully covered by the generating primitive.
    /// </summary>
    public VkBool32 fullyCoveredFragmentShaderInputVariable;

    /// <summary>
    ///     conservativeRasterizationPostDepthCoverage is VK_TRUE if the implementation supports conservative
    ///     rasterization with the PostDepthCoverage execution mode enabled. Otherwise the PostDepthCoverage execution mode
    ///     must not be used when conservative rasterization is enabled.
    /// </summary>
    public VkBool32 conservativeRasterizationPostDepthCoverage;
}