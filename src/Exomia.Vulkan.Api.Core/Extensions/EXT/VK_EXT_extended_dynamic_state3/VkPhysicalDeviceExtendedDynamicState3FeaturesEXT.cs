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
///     VkPhysicalDeviceExtendedDynamicState3FeaturesEXT - Structure describing what extended dynamic state is supported by
///     the implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState3FeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedDynamicState3FeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     extendedDynamicState3TessellationDomainOrigin indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3TessellationDomainOrigin;

    /// <summary>
    ///     extendedDynamicState3DepthClampEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3DepthClampEnable;

    /// <summary>
    ///     extendedDynamicState3PolygonMode indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_POLYGON_MODE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3PolygonMode;

    /// <summary>
    ///     extendedDynamicState3RasterizationSamples indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3RasterizationSamples;

    /// <summary>
    ///     extendedDynamicState3SampleMask indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_SAMPLE_MASK_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3SampleMask;

    /// <summary>
    ///     extendedDynamicState3AlphaToCoverageEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3AlphaToCoverageEnable;

    /// <summary>
    ///     extendedDynamicState3AlphaToOneEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3AlphaToOneEnable;

    /// <summary>
    ///     extendedDynamicState3LogicOpEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3LogicOpEnable;

    /// <summary>
    ///     extendedDynamicState3ColorBlendEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ColorBlendEnable;

    /// <summary>
    ///     extendedDynamicState3ColorBlendEquation indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ColorBlendEquation;

    /// <summary>
    ///     extendedDynamicState3ColorWriteMask indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ColorWriteMask;

    /// <summary>
    ///     extendedDynamicState3RasterizationStream indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3RasterizationStream;

    /// <summary>
    ///     extendedDynamicState3ConservativeRasterizationMode indicates that the implementation supports the following
    ///     dynamic state:VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ConservativeRasterizationMode;

    /// <summary>
    ///     extendedDynamicState3ExtraPrimitiveOverestimationSize indicates that the implementation supports the following
    ///     dynamic state:VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;

    /// <summary>
    ///     extendedDynamicState3DepthClipEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3DepthClipEnable;

    /// <summary>
    ///     extendedDynamicState3SampleLocationsEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3SampleLocationsEnable;

    /// <summary>
    ///     extendedDynamicState3ColorBlendAdvanced indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ColorBlendAdvanced;

    /// <summary>
    ///     extendedDynamicState3ProvokingVertexMode indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3ProvokingVertexMode;

    /// <summary>
    ///     extendedDynamicState3LineRasterizationMode indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3LineRasterizationMode;

    /// <summary>
    ///     extendedDynamicState3LineStippleEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3LineStippleEnable;

    /// <summary>
    ///     extendedDynamicState3DepthClipNegativeOneToOne indicates that the implementation supports the following
    ///     dynamic state:VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT
    /// </summary>
    public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;

    /// <summary>
    ///     extendedDynamicState3ViewportWScalingEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3ViewportWScalingEnable;

    /// <summary>
    ///     extendedDynamicState3ViewportSwizzle indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3ViewportSwizzle;

    /// <summary>
    ///     extendedDynamicState3CoverageToColorEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageToColorEnable;

    /// <summary>
    ///     extendedDynamicState3CoverageToColorLocation indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageToColorLocation;

    /// <summary>
    ///     extendedDynamicState3CoverageModulationMode indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageModulationMode;

    /// <summary>
    ///     extendedDynamicState3CoverageModulationTableEnable indicates that the implementation supports the following
    ///     dynamic state:VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageModulationTableEnable;

    /// <summary>
    ///     extendedDynamicState3CoverageModulationTable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageModulationTable;

    /// <summary>
    ///     extendedDynamicState3CoverageReductionMode indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3CoverageReductionMode;

    /// <summary>
    ///     extendedDynamicState3RepresentativeFragmentTestEnable indicates that the implementation supports the following
    ///     dynamic state:VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;

    /// <summary>
    ///     extendedDynamicState3ShadingRateImageEnable indicates that the implementation supports the following dynamic
    ///     state:VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV
    /// </summary>
    public VkBool32 extendedDynamicState3ShadingRateImageEnable;
}