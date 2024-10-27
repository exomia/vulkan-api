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
///     VkPhysicalDeviceCooperativeMatrix2FeaturesNV - Structure describing cooperative matrix features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2FeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2FeaturesNV.html
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
public unsafe struct VkPhysicalDeviceCooperativeMatrix2FeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     cooperativeMatrixWorkgroupScope indicates that the implementation supports workgroup scope cooperative
    ///     matrices.
    /// </summary>
    public VkBool32 cooperativeMatrixWorkgroupScope;

    /// <summary>
    ///     cooperativeMatrixFlexibleDimensions indicates that the implementation supports cooperative matrix sizes that
    ///     are a multiple of the granularity advertised in VkCooperativeMatrixFlexibleDimensionsPropertiesNV.
    /// </summary>
    public VkBool32 cooperativeMatrixFlexibleDimensions;

    /// <summary>
    ///     cooperativeMatrixReductions indicates that the implementation supports the CooperativeMatrixReductionsNV
    ///     SPIR-V capability. This allows performing (row, column, 2x2, or all element) reductions on matrices.
    /// </summary>
    public VkBool32 cooperativeMatrixReductions;

    /// <summary>
    ///     cooperativeMatrixConversions indicates that the implementation supports the CooperativeMatrixConversionsNV
    ///     SPIR-V capability. This allows converting accumulator matrices to A or B matrices.
    /// </summary>
    public VkBool32 cooperativeMatrixConversions;

    /// <summary>
    ///     cooperativeMatrixPerElementOperations indicates that the implementation supports the
    ///     CooperativeMatrixPerElementOperationsNVSPIR-V capability. This allows performing element-wise operations on matrix
    ///     elements using a callback function.
    /// </summary>
    public VkBool32 cooperativeMatrixPerElementOperations;

    /// <summary>
    ///     cooperativeMatrixTensorAddressing indicates that the implementation supports the TensorAddressingNV and
    ///     CooperativeMatrixTensorAddressingNV SPIR-V capabilities. This allows using tensor layout and tensor view types for
    ///     matrix loads and stores.
    /// </summary>
    public VkBool32 cooperativeMatrixTensorAddressing;

    /// <summary>
    ///     cooperativeMatrixBlockLoads indicates that the implementation supports the CooperativeMatrixBlockLoadsNV
    ///     SPIR-V capability. This allows setting block size for loads and using a callback function to decode block elements.
    /// </summary>
    public VkBool32 cooperativeMatrixBlockLoads;
}